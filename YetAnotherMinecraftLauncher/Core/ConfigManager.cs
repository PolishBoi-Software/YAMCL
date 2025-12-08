using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace YetAnotherMinecraftLauncher.Core
{
    public class AppConfig
    {
        public bool AutoSignIn { get; set; } = true;
        public bool AutoUpdate { get; set; } = true;
        public bool RichPresence { get; set; } = true;
    }

    public static class ConfigManager
    {
        public static AppConfig Config { get; private set; }

        public static void InitConfig()
        {
            string configFilePath = Path.Combine(Program.YAMCLProgramFolder, "config.json");

            if (File.Exists(configFilePath))
            {
                var json = File.ReadAllText(configFilePath);
                Config = JsonSerializer.Deserialize<AppConfig>(json) ?? new AppConfig();
            }

            WriteConfig();
        }

        public static void WriteConfig()
        {
            string configFilePath = Path.Combine(Program.YAMCLProgramFolder, "config.json");

            File.WriteAllText(configFilePath, JsonSerializer.Serialize(Config, new JsonSerializerOptions()
            {
                WriteIndented = true,
                IndentSize = 4
            }));
        }

        public static void ReadConfig()
        {
            string configFilePath = Path.Combine(Program.YAMCLProgramFolder, "config.json");

            if (!File.Exists(configFilePath)) return;

            Config = JsonSerializer.Deserialize<AppConfig>(File.ReadAllText(configFilePath));
        }
    }
}
