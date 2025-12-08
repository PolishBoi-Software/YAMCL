using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using YetAnotherMinecraftLauncher.Core.Utils;

namespace YetAnotherMinecraftLauncher.Core
{
    public static class InstanceManager
    {
        /// <summary>
        /// List of instances.
        /// </summary>
        public static List<Instance> Instances { get; private set; } = new List<Instance>();

        /// <summary>
        /// Loads all instances.
        /// </summary>
        public static void LoadInstances()
        {
            Instances.Clear();
            
            foreach (var dir in Directory.GetDirectories(Program.YAMCLInstanceFolder))
            {
                Debug.WriteLine($"Looking for data file in directory {dir}");
                string dataFilePath = Path.Combine(dir, "instance.json");

                if (!File.Exists(dataFilePath))
                {
                    Debug.WriteLine("Data file not found.");
                    continue;
                }

                Debug.WriteLine("Data file found!");

                var instanceData = JsonSerializer.Deserialize<Dictionary<string, object>>(File.ReadAllText(dataFilePath));

                if (instanceData != null && (instanceData.ContainsKey("name") && instanceData.ContainsKey("version") && instanceData.ContainsKey("baseVersion") && instanceData.ContainsKey("loader")))
                {
                    Instance instance = new Instance(instanceData["name"]?.ToString(), instanceData["version"]?.ToString(), instanceData["baseVersion"]?.ToString(), new CmlLib.Core.MinecraftPath(dir), ModLoaderUtils.GetModLoaderFromName(instanceData["loader"]?.ToString()));
                    Instances.Add(instance);
                }
            }
        }
    }
}
