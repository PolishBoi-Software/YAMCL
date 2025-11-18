using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAMCL
{
    public class MinecraftInstance
    {
        public enum ModLoader
        {
            Fabric,
            Forge,
            NeoForge,
            Quilt,
            LiteLoader,
            None
        }

        private Dictionary<string, string> jsonHelper = new Dictionary<string, string>();
        public string Name { get; set; }
        public string Version { get; set; }
        public string BaseVersion { get; set; }
        public string DirectoryPath { get; set; }
        public ModLoader Loader { get; set; }

        public MinecraftInstance(string name, string version, ModLoader loader, string dirPath)
        {
            Loader = loader;
            Name = name;
            Version = version;
            DirectoryPath = dirPath;
        }

        public void CreateDataFiles()
        {
            try
            {
                string instancesDirPath = Path.Combine(Program.YAMCLFolder, "instances");
                string instancePath = Path.Combine(instancesDirPath, Name);

                if (!Directory.Exists(instancePath))
                    Directory.CreateDirectory(instancePath);

                string dataFile = Path.Combine(instancePath, "instance.json");

                jsonHelper.Add("name", Name);
                jsonHelper.Add("baseVersion", BaseVersion);
                jsonHelper.Add("version", Version);
                jsonHelper.Add("loader", Loader.ToString());

                File.WriteAllText(dataFile, JsonConvert.SerializeObject(jsonHelper, Formatting.Indented));
            }
            catch { }
        }

        public void Remove()
        {
            string instancesDirPath = Path.Combine(Program.YAMCLFolder, "instances");
            string instancePath = Path.Combine(instancesDirPath, Name);

            if (Directory.Exists(instancePath))
                Directory.Delete(instancePath, true);
        }
    }
}
