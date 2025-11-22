using CmlLib.Core.Auth;
using CmlLib.Core.Auth.Microsoft;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YAMCL
{
    public static class AuthManager
    {
        public static JELoginHandler LoginHandler { get; private set; }
        public static MSession Session { get; set; }
        public static EventHandler<MSession> OnSignIn { get; set; }
        public static EventHandler OnSignOut { get; set; }
        public static EventHandler<Exception> OnAuthError { get; set; }
        public static bool IsMicrosoft { get; private set; }

        public static async Task LogInWithMicrosoft()
        {
            try
            {
                if (Session != null) return;

                IsMicrosoft = true;

                LoginHandler = JELoginHandlerBuilder.BuildDefault();
                Session = await LoginHandler.Authenticate();

                OnSignIn?.Invoke(null, Session);
            }
            catch (Exception ex)
            {
                OnAuthError?.Invoke(null, ex);
            }
        }

        public static async Task SignOut()
        {
            try
            {
                if (Session == null) return;

                if (IsMicrosoft)
                    await LoginHandler.Signout();

                Session = null;
                OnSignOut?.Invoke(null, new EventArgs());
            }
            catch (Exception ex)
            {
                OnAuthError?.Invoke(null, ex);
            }
        }

        public static void LogInOffline(string username, bool legacy = false)
        {
            try
            {
                if (string.IsNullOrEmpty(username))
                    throw new ArgumentNullException(nameof(username), "cannot be empty");

                if (Session != null) return;

                IsMicrosoft = false;

                if (legacy)
                    Session = MSession.CreateLegacyOfflineSession(username);
                else
                    Session = MSession.CreateOfflineSession(username);

                OnSignIn?.Invoke(null, Session);
            }
            catch (Exception ex)
            {
                OnAuthError?.Invoke("AuthManager", ex);
            }
        }
    }
}
