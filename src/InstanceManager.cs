using CmlLib.Core.ProcessBuilder;
using CuoreUI.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace YAMCL
{
    public static class InstanceManager
    {
        public static List<MinecraftInstance> Instances { get; set; } = new List<MinecraftInstance>();
        private static Dictionary<string, string> jsonHelper = new Dictionary<string, string>();

        private static MinecraftInstance.ModLoader GetModLoader(string name)
        {
            return (MinecraftInstance.ModLoader)Enum.Parse(typeof(MinecraftInstance.ModLoader), name);
        }

        private static void LoadOldInstances()
        {
            string instancesDirPath = Path.Combine(Program.YAMCLFolder, "instances");

            foreach (var dir in Directory.GetDirectories(instancesDirPath))
            {
                string instanceDataFile = Path.Combine(dir, "instance.dat");

                string[] instanceData = File.ReadAllText(instanceDataFile).Split(';');

                // Name;BaseVersion;Version;ModLoader is the old format
                var instance = new MinecraftInstance(instanceData[0], instanceData[2], GetModLoader(instanceData[3]), dir);
                instance.BaseVersion = instanceData[1];
                Instances.Add(instance);
            }
        }

        public static void AddInstance(string name, string baseVersion, string version, MinecraftInstance.ModLoader loader, MLaunchOption options)
        {
            string instancesDirPath = Path.Combine(Program.YAMCLFolder, "instances", name);
            var inst = new MinecraftInstance(name, version, loader, instancesDirPath);
            inst.BaseVersion = baseVersion;
            inst.LaunchOptions = options;
            if (!Instances.Contains(inst)) Instances.Add(inst);
        }

        public static void LoadInstances()
        {
            string instancesDirPath = Path.Combine(Program.YAMCLFolder, "instances");
            int i = 0;
            bool oldDataExists = false;

            foreach (var dir in Directory.GetDirectories(instancesDirPath))
            {
                string oldInstanceDataFile = Path.Combine(dir, "instance.dat");
                string instanceDataFile = Path.Combine(dir, "instance.json");
                string oldInstanceDataFileBackup = Path.Combine(dir, "instance.dat.bak");
                oldDataExists = File.Exists(oldInstanceDataFile);

                if (oldDataExists)
                {
                    LoadOldInstances();
                    File.Move(oldInstanceDataFile, oldInstanceDataFileBackup);
                    Instances[i].CreateDataFiles();
                }
                else
                {
                    jsonHelper = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(instanceDataFile));

                    MLaunchOption options = new MLaunchOption()
                    {
                        FullScreen = bool.Parse(jsonHelper["fullscreen"]),
                        ScreenWidth = int.Parse(jsonHelper["width"]),
                        ScreenHeight = int.Parse(jsonHelper["height"])
                    };

                    AddInstance(jsonHelper["name"], jsonHelper["baseVersion"], jsonHelper["version"], GetModLoader(jsonHelper["loader"]), options);
                }

                i++;
            }
        }
    }
}
