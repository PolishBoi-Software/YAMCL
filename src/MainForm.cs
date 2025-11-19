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
using System.Net;
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
        public bool checkForUpdateBtnClicked = false;
        public MinecraftLauncher launcher = new MinecraftLauncher();
        private bool UpdateDownloadFinished;
        private string UpdateFileName;
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

        private async void MainForm_Load(object sender, EventArgs e)
        {
            #if DEBUG
                AutoUpdater.InstalledVersion = new Version(1, 0, 0);
            #endif

            AutoUpdater.CheckForUpdateEvent += (ev) =>
            {
                if (ev.IsUpdateAvailable)
                {
                    using (var dial = new UpdateDialog(ev.InstalledVersion, ev.CurrentVersion, ev.ChangelogURL))
                    {
                        var result = dial.ShowDialog();

                        if (result == DialogResult.Yes)
                        {
                            using (var web = new WebClient())
                            {
                                string path = Path.Combine(Path.GetTempPath(), Path.ChangeExtension(Guid.NewGuid().ToString(), "exe"));

                                web.DownloadProgressChanged += (_s, _e) =>
                                {
                                    this.Invoke(new Action(() =>
                                    {
                                        if (progBar.MaxValue != 100)
                                            progBar.MaxValue = 100;
                                        progBar.Value = _e.ProgressPercentage;

                                        downloadProgressLbl.Content = $"{ByteSize.FromBytes(_e.BytesReceived)} / {ByteSize.FromBytes(_e.TotalBytesToReceive)}";
                                    }));
                                };

                                web.DownloadFileCompleted += (_s, _e) =>
                                {
                                    UpdateDownloadFinished = true;
                                    taskLbl.Content = "Finished!";
                                };

                                UpdateFileName = path;

                                taskLbl.Content = "Downloading update";
                                web.DownloadFileAsync(new Uri(ev.DownloadURL), path);
                            }                            
                        }
                    }
                }
                else
                {
                    if (checkForUpdateBtnClicked)
                    {
                        MessageBox.Show("You have the latest version of YAMCL!", "YAMCL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        checkForUpdateBtnClicked = false;
                    }
                }
            };

            ConfigManager.LoadConfig();
            LoadInstances();
            loginHandler = JELoginHandlerBuilder.BuildDefault();

            if ((bool)ConfigManager.Config["autoUpdate"])
            {
                this.BeginInvoke(new Action(() => AutoUpdater.Start("https://raw.githubusercontent.com/PolishBoi-Software/Yet-Another-Minecraft-Launcher/main/version.xml")));
            }

            if ((bool)ConfigManager.Config["autoSignIn"])
            {
                session = await loginHandler.Authenticate();
                OnSignIn();
            }

            if ((bool)ConfigManager.Config["discordRpc"])
            {
                RichPresenceHandler.Init();
            }
        }

        private void LoadInstances()
        {
            InstanceManager.LoadInstances();

            foreach (var inst in InstanceManager.Instances)
            {
                string loader = inst.Loader != MinecraftInstance.ModLoader.None ? inst.Loader.ToString() : "Vanilla";
                instanceList.Items.Add($"{inst.Name} [{inst.BaseVersion}, {loader}]");
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
            return InstanceManager.Instances.Find(i => i.Name == name) != null;
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
                    InstanceManager.Instances.Clear();
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

            var instance = InstanceManager.Instances[instanceList.SelectedIndex];
            var result = MessageBox.Show($"Are you sure you want to remove instance \"{instance.Name}\"?\n\nThis cannot be undone.", "YAMCL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                instance.Remove();

                InstanceManager.Instances.Remove(instance);
                InstanceManager.Instances.Clear();
                instanceList.Items.Clear();
                LoadInstances();
                instanceList.Refresh();

                MessageBox.Show($"Successfully removed instance \"{instance.Name}\"!", "YAMCL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task<string> InstallLoader(string mcVersion, MinecraftLauncher launcher, MinecraftInstance.ModLoader loader)
        {
            switch (loader)
            {
                case MinecraftInstance.ModLoader.Fabric:
                    var fabric = new FabricInstaller(new System.Net.Http.HttpClient());
                    return await fabric.Install(mcVersion, launcher.MinecraftPath);

                case MinecraftInstance.ModLoader.Forge:
                    var forge = new ForgeInstaller(launcher);
                    return await forge.Install(mcVersion);

                case MinecraftInstance.ModLoader.NeoForge:
                    var neoForge = new NeoForgeInstaller(launcher);
                    return await neoForge.Install(mcVersion);

                case MinecraftInstance.ModLoader.Quilt:
                    var quilt = new QuiltInstaller(new System.Net.Http.HttpClient());
                    return await quilt.Install(mcVersion, launcher.MinecraftPath);

                case MinecraftInstance.ModLoader.LiteLoader:
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

                var instance = InstanceManager.Instances[instanceList.SelectedIndex];
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

                if (instance.Loader != MinecraftInstance.ModLoader.None && (instance.Version == instance.BaseVersion))
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
                    ConfigManager.SaveConfig();
                    taskLbl.Content = "Saved config!";
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            ConfigManager.SaveConfig();

            if (UpdateDownloadFinished)
            {
                var proc = Process.Start(UpdateFileName);
            }

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

            var instance = InstanceManager.Instances[instanceList.SelectedIndex];
            
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
