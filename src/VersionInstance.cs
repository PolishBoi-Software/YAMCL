using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAMCL
{
    public class VersionInstance
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

        public string Name { get; set; }
        public string Version { get; set; }
        public string BaseVersion { get; set; }
        public string DirectoryPath { get; set; }
        public ModLoader Loader { get; set; }

        public VersionInstance(string name, string version, ModLoader loader, string dirPath)
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

                string dataFile = Path.Combine(instancePath, "instance.dat");

                File.WriteAllText(dataFile, $@"{Name};{BaseVersion};{Version};{Loader}");
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
