using Avalonia;
using CmlLib.Core.Auth;
using CmlLib.Core.Auth.Microsoft;
using CustomMessageBox.Avalonia;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using XboxAuthNet.Game.Authenticators;
using XboxAuthNet.Game.Msal;
using XboxAuthNet.Game.OAuth;
using XboxAuthNet.OAuth;
using XboxAuthNet.OAuth.CodeFlow;
using XboxAuthNet.XboxLive;
using YetAnotherMinecraftLauncher.Core.Utils;

namespace YetAnotherMinecraftLauncher.Core
{
    public static class AuthManager
    {
        /// <summary>
        /// The Minecraft session.
        /// </summary>
        public static MSession? Session { get; private set; }

        private static JELoginHandler handler;

        /// <summary>
        /// Whether or not the user is signed in with a Microsoft account.
        /// </summary>
        public static bool IsMicrosoft { get; private set; }

        private const string ClientID = "52a5c23c-8cba-4eb6-91bb-20d62c9e1224";

        /// <summary>
        /// Signs in with a Microsoft account.
        /// </summary>
        public static async Task SignIn()
        {
            if (Session != null)
                return;

            try
            {
                IPublicClientApplication app = await MsalClientHelper.BuildApplicationWithCache(ClientID);

                handler = JELoginHandlerBuilder.BuildDefault();
                NestedAuthenticator authenticator;

                if (handler.AccountManager.GetDefaultAccount() != null)
                {
                    var result = await MessageBox.Show("Use default account?", "YAMCL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == MessageBoxResult.Yes)
                        authenticator = handler.CreateAuthenticatorWithDefaultAccount();
                    else
                        authenticator = handler.CreateAuthenticatorWithNewAccount();
                }
                else
                {
                    authenticator = handler.CreateAuthenticatorWithNewAccount();
                }

                authenticator.AddMsalOAuth(app, msal => msal.InteractiveWithSingleAccount());

                authenticator.AddXboxAuthForJE(xbox => xbox.Basic());
                authenticator.AddJEAuthenticator();
                Session = await authenticator.ExecuteForLauncherAsync();

                IsMicrosoft = true;
            }
            catch (Exception ex)
            {
                await MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// Signs in with a "cracked" account.
        /// </summary>
        public static void SignIn(string username, bool legacy = false)
        {
            if (Session != null)
                return;

            if (!legacy)
                Session = MSession.CreateOfflineSession(username);
            else
                Session = MSession.CreateLegacyOfflineSession(username);

            IsMicrosoft = false;
        }

        public static async Task SignOut()
        {
            if (Session == null) return;

            Session = null;

            if (handler != null)
                await handler.Signout();
        }
    }
}
