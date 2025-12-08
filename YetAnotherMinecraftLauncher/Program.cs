using Avalonia;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Updatum;
using YetAnotherMinecraftLauncher.Core;
using YetAnotherMinecraftLauncher.Core.Utils;

namespace YetAnotherMinecraftLauncher
{
    internal class Program
    {
        public static string YAMCLProgramFolder { get; private set; }
        public static string YAMCLInstanceFolder { get; private set; }
        public static UpdatumManager AppManager => new UpdatumManager("https://github.com/PolishBoi-Software/YAMCL");

        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        [STAThread]
        public static void Main(string[] args)
        {
            YAMCLProgramFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "YAMCL");
            YAMCLInstanceFolder = Path.Combine(YAMCLProgramFolder, "instances");

            if (!Directory.Exists(YAMCLProgramFolder))
                Directory.CreateDirectory(YAMCLProgramFolder);

            Debug.WriteLine("Creating default config...");
            ConfigManager.InitConfig();

            if (!Directory.Exists(YAMCLInstanceFolder))
                Directory.CreateDirectory(YAMCLInstanceFolder);

            Debug.WriteLine("Loading instances...");
            InstanceManager.LoadInstances();

            Debug.WriteLine("Loading config just in case...");
            ConfigManager.ReadConfig();

            Debug.WriteLine("Initializing Modrinth client...");
            ModrinthUtils.Init();

            BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
        }

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .WithInterFont()
                .LogToTrace();
    }
}
