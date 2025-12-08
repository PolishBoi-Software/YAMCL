using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetAnotherMinecraftLauncher.Core.Utils
{

    [Serializable]
    public class ModLoaderNotFoundException : Exception
    {
        public ModLoaderNotFoundException(string loaderName) : base($"Mod loader \"{loaderName}\" not found!") { }
    }

    public static class ModLoaderUtils
    {
        public static ModLoader GetModLoaderFromName(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name), "Name cannot be null/empty.");

            try
            {
                ModLoader loader = Enum.Parse<ModLoader>(name, true);
                return loader;
            }
            catch (ArgumentException)
            {
                throw new ModLoaderNotFoundException(name);
            }
        }
    }
}
