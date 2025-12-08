using CmlLib.Core;
using CmlLib.Core.ProcessBuilder;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CmlLib.Core.ModLoaders.FabricMC;
using System.Net.Http;
using CmlLib.Core.Installer.Forge;
using CmlLib.Core.Installer.NeoForge;
using CmlLib.Core.ModLoaders.LiteLoader;
using CmlLib.Core.ModLoaders.QuiltMC;
using CmlLib.Core.Installers;

namespace YetAnotherMinecraftLauncher.Core
{
    public enum ModLoader
    {
        /// <summary>
        /// No mod loader.
        /// </summary>
        Vanilla,

        /// <summary>
        /// Fabric mod loader.
        /// </summary>
        Fabric,

        /// <summary>
        /// Forge mod loader.
        /// </summary>
        Forge,

        /// <summary>
        /// NeoForge mod loader.
        /// </summary>
        NeoForge,

        /// <summary>
        /// Quilt mod loader.
        /// </summary>
        Quilt,

        /// <summary>
        /// LiteLoader mod loader.
        /// </summary>
        LiteLoader
    }

    public class Instance
    {
        /// <summary>
        /// The name of the instance.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The version that is used to install mod loaders.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// The ACTUAL version of the instance, used for launching.
        /// </summary>
        public string BaseVersion { get; set; }

        /// <summary>
        /// The directory where the instance is stored.
        /// </summary>
        public MinecraftPath MCPath { get; set; }

        /// <summary>
        /// The mod loader.
        /// </summary>
        public ModLoader Loader { get; set; }

        /// <summary>
        /// The main <see cref="MinecraftLauncher"/> object.
        /// </summary>
        public MinecraftLauncher Launcher { get; set; }

        private Process? CurrentProcess;

        private Dictionary<string, object> jsonHelper = new Dictionary<string, object>();

        /// <summary>
        /// Whether the instance is running.
        /// </summary>
        public bool IsRunning { get; private set; }

        public Instance(string name, string version, string baseVersion, MinecraftPath path, ModLoader loader) : this(name, version, baseVersion, path)
        {
            Loader = loader;
        }

        public Instance(string name, string version, string baseVersion, ModLoader loader) : this(name, version, baseVersion)
        {
            Loader = loader;
        }

        public Instance(string name, string version, string baseVersion, MinecraftPath path)
        {
            Name = name;
            Version = version;
            BaseVersion = baseVersion;
            MCPath = path;
            Launcher = new MinecraftLauncher(MCPath);
        }

        public Instance(string name, string version, string baseVersion, string path)
        {
            Name = name;
            Version = version;
            BaseVersion = baseVersion;
            MCPath = new MinecraftPath(path);
            Launcher = new MinecraftLauncher(MCPath);
        }

        public Instance(string name, string version, string baseVersion)
        {
            Name = name;
            Version = version;
            BaseVersion = baseVersion;
            MCPath = new MinecraftPath(Path.Combine(Program.YAMCLInstanceFolder, Name));
            Launcher = new MinecraftLauncher(MCPath);
        }

        /// <summary>
        /// Launches the instance.
        /// </summary>
        /// <param name="options">The options for the instance.</param>
        /// <param name="wait">Whether to wait for the process to exit.</param>
        public async Task Launch(MLaunchOption options, bool wait = false)
        {
            await InstallLoader();
            await Launcher.InstallAsync(BaseVersion);

            CurrentProcess = await Launcher.BuildProcessAsync(Version, options);
            CurrentProcess.Start();
            IsRunning = true;

            if (wait)
            {
                CurrentProcess.WaitForExit();
                IsRunning = false;
            }
        }

        /// <summary>
        /// Kills the instance's process.
        /// </summary>
        public void Exit()
        {
            if (CurrentProcess == null || !IsRunning)
                return;

            CurrentProcess.Close();
            CurrentProcess.Kill();
            CurrentProcess = null;
            IsRunning = false;
        }

        /// <summary>
        /// Initializes the instance.
        /// </summary>
        /// <param name="reinit">Whether to reinitialize the instance or not.</param>
        public void Init(bool reinit)
        {
            string instanceDataFilePath = Path.Combine(MCPath.BasePath, "instance.json");

            MCPath.CreateDirs();

            if (!File.Exists(instanceDataFilePath) && reinit)
                return;

            jsonHelper.Clear();
            jsonHelper.Add("name", Name);
            jsonHelper.Add("version", Version);
            jsonHelper.Add("baseVersion", BaseVersion);
            jsonHelper.Add("loader", Loader.ToString());
            File.WriteAllText(instanceDataFilePath, JsonSerializer.Serialize(jsonHelper, new JsonSerializerOptions()
            {
                WriteIndented = true,
                IndentSize = 4
            }));
        }

        /// <summary>
        /// Removes the instance from the disk.
        /// </summary>
        public void Remove()
        {
            string instanceDataFilePath = Path.Combine(MCPath.BasePath, "instance.json");

            if (File.Exists(instanceDataFilePath))
                File.Delete(instanceDataFilePath);

            if (Directory.Exists(MCPath.BasePath))
                Directory.Delete(MCPath.BasePath, true);
        }

        /// <summary>
        /// Installs the mod loader.
        /// </summary>
        public async Task InstallLoader()
        {
            string loaderVersion = string.Empty;

            if (Loader == ModLoader.Vanilla)
                return;

            using (var http = new HttpClient())
            {
                switch (Loader)
                {
                    case ModLoader.Fabric:
                        var fabric = new FabricInstaller(http);
                        loaderVersion = await fabric.Install(BaseVersion, MCPath);
                        break;

                    case ModLoader.Forge:
                        var forge = new ForgeInstaller(Launcher);
                        loaderVersion = await forge.Install(BaseVersion);
                        break;

                    case ModLoader.NeoForge:
                        var neoforge = new NeoForgeInstaller(Launcher);
                        loaderVersion = await neoforge.Install(BaseVersion);
                        break;

                    case ModLoader.LiteLoader:
                        var liteLoader = new LiteLoaderInstaller(http);
                        var loaders = await liteLoader.GetAllLiteLoaders();
                        var toInstall = loaders.First(loader => loader.BaseVersion == BaseVersion);
                        loaderVersion = await liteLoader.Install(toInstall, await Launcher.GetVersionAsync(BaseVersion), MCPath);
                        break;

                    case ModLoader.Quilt:
                        var quilt = new QuiltInstaller(http);
                        loaderVersion = await quilt.Install(BaseVersion, MCPath);
                        break;

                    default:
                        break;
                }
            }

            Version = loaderVersion;
            Init(true);
        }
    }
}
