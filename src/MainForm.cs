using AutoUpdaterDotNET;
using ByteSizeLib;
using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.Auth.Microsoft;
using CmlLib.Core.Installer.Forge;
using CmlLib.Core.Installer.NeoForge;
using CmlLib.Core.ModLoaders.FabricMC;
using CmlLib.Core.ModLoaders.LiteLoader;
using CmlLib.Core.ModLoaders.QuiltMC;
using CmlLib.Core.ProcessBuilder;
using CuoreUI.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YAMCL
{
    public partial class MainForm : Form
    {
        private JELoginHandler loginHandler;
        private MSession session;
        public MinecraftLauncher launcher = new MinecraftLauncher();
        private List<VersionInstance> instances = new List<VersionInstance>();
        public Dictionary<string, bool> config = new Dictionary<string, bool>();
        private List<Process> processes = new List<Process>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void OnSignOut()
        {
            signInBtn.Content = "Sign in";
            playerHead.Image = null;
            unameLbl.Content = "USERNAME";
            uuidLbl.Content = "UUID";
        }

        private void OnSignIn()
        {
            signInBtn.Content = "Sign out";
            string url = $"https://nmsr.nickac.dev/bust/{session.UUID}";
            playerHead.ImageLocation = url;

            unameLbl.Content = session.Username;
            uuidLbl.Content = session.UUID;
        }

        private async void signInBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (session != null)
                {
                    var result = MessageBox.Show("Are you sure you want to sign out?", "YAMCL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        await loginHandler.Signout();
                        session = null;
                        OnSignOut();
                        MessageBox.Show("Successfully signed out!", "YAMCL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return;
                }

                session = await loginHandler.Authenticate();
                OnSignIn();

                MessageBox.Show($"Successfully signed in as {session.Username}", "YAMCL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private VersionInstance.ModLoader GetModLoader(string name)
        {
            return (VersionInstance.ModLoader)Enum.Parse(typeof(VersionInstance.ModLoader), name);
        }

        private void LoadInstances()
        {
            string appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "YAMCL");
            string instancesDirPath = Path.Combine(appDataFolder, "instances");

            foreach (var dir in Directory.GetDirectories(instancesDirPath))
            {
                string instanceDataFile = Path.Combine(dir, "instance.dat");

                string[] instanceData = File.ReadAllText(instanceDataFile).Split(';');

                // Name;BaseVersion;Version;ModLoader is the format
                var instance = new VersionInstance(instanceData[0], instanceData[2], GetModLoader(instanceData[3]), dir);
                instance.BaseVersion = instanceData[1];
                instances.Add(instance);
                var loader = instance.Loader == VersionInstance.ModLoader.None ? "Vanilla" : instance.Loader.ToString();
                instanceList.Items.Add($"{instance.Name} [{instance.BaseVersion}, {loader}]");
            }
        }

        private void LoadConfigFile()
        {
            string configFilePath = Path.Combine(Program.YAMCLFolder, "config.cfg");
            if (!File.Exists(configFilePath)) return;

            string[] lines = File.ReadAllLines(configFilePath);

            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line) || line.StartsWith("#")) continue;

                string[] parts = line.Split('=');

                if (parts.Length != 2)
                    continue;

                string key = parts[0].Trim();
                string value = parts[1].Trim();

                bool bVal = false;

                if (value == "yes")
                    bVal = true;
                else if (value == "maybe")
                {
                    var rand = new Random();
                    bVal = rand.NextDouble() < 0.5;
                }

                config[key] = bVal;
            }
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            #if DEBUG
                AutoUpdater.InstalledVersion = new Version(1, 0, 0);
            #endif

            AutoUpdater.UpdateMode = Mode.ForcedDownload;
            AutoUpdater.AppTitle = "YAMCL";
            AutoUpdater.OpenDownloadPage = true;

            LoadConfigFile();
            LoadInstances();

            loginHandler = JELoginHandlerBuilder.BuildDefault();
            
            if (config["autoSignIn"])
            {
                session = await loginHandler.Authenticate();
                OnSignIn();
            }

            if (Program.frm.config["autoUpdate"])
            {
                AutoUpdater.Start("https://raw.githubusercontent.com/PolishBoi-Software/Yet-Another-Minecraft-Launcher/main/version.xml");
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private bool InstanceAlreadyExists(string name)
        {
            return instances.Find(i => i.Name == name) != null;
        }

        private void createInst_Click(object sender, EventArgs e)
        {
            using (var dial = new InstanceDialog())
            {
                var result = dial.ShowDialog();

                if (result == DialogResult.OK && !dial.Failed)
                {
                    if (InstanceAlreadyExists(dial.InstanceName))
                    {
                        var msgResult = MessageBox.Show("An instance already exists with that name!\nAre you sure you want to overwrite it?\n\nThis cannot be undone.", "YAMCL", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        
                        if (msgResult == DialogResult.No)
                            return;
                    }

                    dial.InstanceObject.CreateDataFiles();
                    instances.Clear();
                    instanceList.Items.Clear();
                    LoadInstances();
                    instanceList.Refresh();
                }
            }
        }

        private void rmInstanceBtn_Click(object sender, EventArgs e)
        {
            if (instanceList.SelectedItem == null)
                return;

            var instance = instances[instanceList.SelectedIndex];
            var result = MessageBox.Show($"Are you sure you want to remove instance \"{instance.Name}\"?\n\nThis cannot be undone.", "YAMCL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                instance.Remove();

                instances.Remove(instance);
                instances.Clear();
                instanceList.Items.Clear();
                LoadInstances();
                instanceList.Refresh();

                MessageBox.Show($"Successfully removed instance \"{instance.Name}\"!", "YAMCL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task<string> InstallLoader(string mcVersion, MinecraftLauncher launcher, VersionInstance.ModLoader loader)
        {
            switch (loader)
            {
                case VersionInstance.ModLoader.Fabric:
                    var fabric = new FabricInstaller(new System.Net.Http.HttpClient());
                    return await fabric.Install(mcVersion, launcher.MinecraftPath);

                case VersionInstance.ModLoader.Forge:
                    var forge = new ForgeInstaller(launcher);
                    return await forge.Install(mcVersion);

                case VersionInstance.ModLoader.NeoForge:
                    var neoForge = new NeoForgeInstaller(launcher);
                    return await neoForge.Install(mcVersion);

                case VersionInstance.ModLoader.Quilt:
                    var quilt = new QuiltInstaller(new System.Net.Http.HttpClient());
                    return await quilt.Install(mcVersion, launcher.MinecraftPath);

                case VersionInstance.ModLoader.LiteLoader:
                    var liteLoader = new LiteLoaderInstaller(new System.Net.Http.HttpClient());
                    var version = new LiteLoaderVersion();
                    return await liteLoader.Install(version, await launcher.GetVersionAsync(mcVersion), launcher.MinecraftPath);

                default:
                    return string.Empty;
            }
        }

        private async void launchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (instanceList.SelectedItem == null)
                {
                    MessageBox.Show("Please select an instance!", "YAMCL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (session == null)
                {
                    MessageBox.Show("Please sign in!", "YAMCL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                launchBtn.Enabled = false;
                launchBtn.Content = "Launching...";

                progBar.Value = 0;
                taskbarState.ProgressValue = 0;
                taskbarState.State = CuoreUI.Components.cuiTaskbarStateController.TaskbarStates.Progress;

                var instance = instances[instanceList.SelectedIndex];
                launcher = new MinecraftLauncher(instance.DirectoryPath);

                launcher.FileProgressChanged += (s, ev) =>
                {
                    this.Invoke(new Action(() =>
                    {
                        progBar.Value = ev.ProgressedTasks;
                        taskbarState.ProgressValue = ev.ProgressedTasks;
                        progBar.MaxValue = ev.TotalTasks;
                        taskbarState.MaxValue = ev.TotalTasks;
                        taskLbl.Content = ev.Name;
                    }));
                };

                launcher.ByteProgressChanged += (s, ev) =>
                {
                    this.Invoke(new Action(() => downloadProgressLbl.Content = $"{ByteSize.FromBytes(ev.ProgressedBytes)} / {ByteSize.FromBytes(ev.TotalBytes)}"));
                };

                if (instance.Loader != VersionInstance.ModLoader.None && (instance.Version == instance.BaseVersion))
                {
                    taskLbl.Content = $"Installing {instance.Loader}";
                    instance.Version = await InstallLoader(instance.BaseVersion, launcher, instance.Loader);
                    instance.CreateDataFiles();
                }

                var proc = await launcher.InstallAndBuildProcessAsync(instance.Version, new MLaunchOption()
                {
                    Session = session,
                    MaximumRamMb = 4096,
                    Path = new MinecraftPath(instance.DirectoryPath)
                });

                processes.Add(proc);

                proc.Start();
            }
            catch (Exception ex)
            {
                taskbarState.State = CuoreUI.Components.cuiTaskbarStateController.TaskbarStates.Error;
                MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            taskbarState.ProgressValue = 0;
            taskbarState.State = CuoreUI.Components.cuiTaskbarStateController.TaskbarStates.Default;
            launchBtn.Enabled = true;
            launchBtn.Content = "Launch";
            taskLbl.Content = "Finished";
            progBar.Value = 0;
            downloadProgressLbl.Content = "0 bytes / 0 bytes";
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            using (var dial = new SettingsDialog())
            {
                var result = dial.ShowDialog();

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Don't forget to close and reopen the app!", "YAMCL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void SaveConfigFile()
        {
            string configFilePath = Path.Combine(Program.YAMCLFolder, "config.cfg");
            if (!File.Exists(configFilePath)) return;

            string[] oldLines = File.ReadAllLines(configFilePath);
            string[] newLines = new string[oldLines.Length];
            int i = 0;

            foreach (string line in oldLines)
            {
                if (string.IsNullOrEmpty(line) || line.StartsWith("#") || !line.Contains('='))
                {
                    newLines[i++] = line;
                    continue;
                }

                string name = line.Split('=')[0].Trim();

                if (!config.ContainsKey(name))
                {
                    newLines[i++] = line;
                    continue;
                }

                string val = config[name] ? "yes" : "no";

                newLines[i++] = $"{name} = {val}";
            }

            File.WriteAllLines(configFilePath, newLines);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            SaveConfigFile();

            e.Cancel = false;
        }

        private void killBtn_Click(object sender, EventArgs e)
        {
            if (processes.Count == 0)
            {
                MessageBox.Show("Minecraft is not running!", "YAMCL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to kill Minecraft?\n\nThis may cause your instance to get corrupted, and should be used when Minecraft crashes.", "YAMCL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (var proc in processes.ToList())
                {
                    if (proc.HasExited)
                    {
                        processes.Remove(proc);
                        continue;
                    }

                    try
                    {
                        proc.Kill();
                        proc.WaitForExit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        proc.Close();
                        processes.Remove(proc);
                    }
                }
            }
        }

        private void addModBtn_Click(object sender, EventArgs e)
        {
            if (instanceList.SelectedItem == null)
            {
                MessageBox.Show("Please select an instance!", "YAMCL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var instance = instances[instanceList.SelectedIndex];
            
            try
            {
                string modDir = Path.Combine(instance.DirectoryPath, "mods");

                if (!Directory.Exists(modDir))
                    Directory.CreateDirectory(modDir);

                using (var dial = new OpenFileDialog())
                {
                    dial.Filter = "Minecraft Mods (*.jar)|*.jar";

                    var dialResult = dial.ShowDialog();
                    if (dialResult == DialogResult.OK)
                    {
                        string modFile = Path.Combine(modDir, dial.SafeFileName);
                        File.Copy(dial.FileName, modFile, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
