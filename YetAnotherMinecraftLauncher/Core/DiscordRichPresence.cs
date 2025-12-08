using System;
using System.Collections.Generic;
using System.Linq;
using DiscordRPC;
using System.Text;
using System.Threading.Tasks;

namespace YetAnotherMinecraftLauncher.Core
{
    public static class DiscordRichPresence
    {
        public const long ClientID = 1440712842964893797;
        private static DiscordRpcClient Client;

        public static void Init()
        {
            Client = new DiscordRpcClient(ClientID.ToString());

            bool success = Client.Initialize();

            if (success)
            {
                Client.SetPresence(new RichPresence
                {
                    Details = "Yet Another Minecraft Launcher",
                    DetailsUrl = "https://github.com/PolishBoi-Software/Yet-Another-Minecraft-Launcher"
                });
            }
        }
    }
}
