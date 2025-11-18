using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace YAMCL
{
    public static class ConfigManager
    {
        public static Dictionary<string, object> Config { get; set; } = new Dictionary<string, object>();

        private static void LoadOldConfig()
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

                Config[key] = bVal;
            }
        }

        private static string ConvertConfigToJson()
        {
            return JsonConvert.SerializeObject(Config, Formatting.Indented);
        }

        public static void LoadConfig()
        {
            string configFilePath = Path.Combine(Program.YAMCLFolder, "config.json");
            string oldConfigFilePath = Path.Combine(Program.YAMCLFolder, "config.cfg");
            string oldConfigFilePathBackup = Path.Combine(Program.YAMCLFolder, "config.cfg.bak");

            if (File.Exists(oldConfigFilePath))
            {
                MessageBox.Show("YAMCL has detected the older-style '.cfg' configuration.\n\nVersions 1.2.0 and onwards will use JSON.", "YAMCL", MessageBoxButton.OK, MessageBoxImage.Warning);
                LoadOldConfig();
                File.WriteAllText(configFilePath, ConvertConfigToJson());
                File.Move(oldConfigFilePath, oldConfigFilePathBackup);
            }

            Config = JsonConvert.DeserializeObject<Dictionary<string, object>>(File.ReadAllText(configFilePath));
        }

        public static void SaveConfig()
        {
            string configFilePath = Path.Combine(Program.YAMCLFolder, "config.json");
            File.WriteAllText(configFilePath, ConvertConfigToJson());
        }
    }
}
