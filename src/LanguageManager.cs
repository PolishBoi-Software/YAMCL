using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAMCL
{
    public enum Language
    {
        Polish,
        English
    }

    public static class LanguageManager
    {
        public static Language CurrentLanguage { get; set; }
        private static Dictionary<Language, Dictionary<string, string>> _translations = new Dictionary<Language, Dictionary<string, string>>();

        public static void Init()
        {
            if (!_translations.ContainsKey(Language.English))
                _translations[Language.English] = new Dictionary<string, string>()
                {
                    ["message.success.signin"] = "Successfully signed in as [USERNAME]!",
                    ["message.success.signout"] = "Successfully signed out!",
                    ["message.question.signout"] = "Are you sure you want to sign out?",
                    ["message.question.signin_ms"] = "Sign in with a Microsoft account?",
                    ["message.error.selectinstance"] = "Please select an instance!",
                    ["message.error.mc_not_running"] = "Minecraft is not running!",
                    ["message.question.killmc"] = "Are you sure you want to kill Minecraft?\n\nThis may corrupt your instance and should only be used if Minecraft freezes.",
                    ["status.message.config_saved"] = "Saved config!",
                    ["status.installing.fabric"] = "Installing Fabric...",
                    ["status.installing.neoforge"] = "Installing NeoForge...",
                    ["status.installing.forge"] = "Installing Forge...",
                    ["status.installing.liteloader"] = "Installing LiteLoader...",
                    ["status.installing.quilt"] = "Installing Quilt...",
                    ["message.error.signin"] = "Please sign in!",
                    ["btn.launch.launching_text"] = "Launching...",
                    ["btn.launch.text"] = "Launch",
                    ["btn.kill.text"] = "Kill",
                    ["btn.settings.text"] = "Settings",
                    ["btn.signin.text"] = "Sign in",
                    ["btn.signout.text"] = "Sign out",
                    ["message.question.legacy"] = "Use legacy version?",
                    ["message.information.latest_ver"] = "You have the latest version of YAMCL!",
                    ["status.downloading.update"] = "Downloading update...",
                    ["status.success.finish"] = "Finished!",
                    ["dialog.instance.title"] = "Create or edit an instance",
                    ["dialog.instance.name"] = "Instance name:",
                    ["dialog.instance.version"] = "Instance version:",
                    ["dialog.instance.loader"] = "Mod loader:",
                    ["dialog.auth.username"] = "Username:",
                    ["btn.cancel.text"] = "Cancel",
                    ["btn.yes.text"] = "Yes",
                    ["btn.no.text"] = "No",
                    ["setting.autoupdate.text"] = "Auto update",
                    ["setting.autosignin.text"] = "Auto sign in",
                    ["setting.discordrpc.text"] = "Discord RPC",
                    ["setting.language.text"] = "Language",
                    ["setting.autoupdate.tooltip"] = "Checks if you have the latest version of YAMCL on startup.",
                    ["setting.autosignin.tooltip"] = "Asks if you want to sign in with a Microsoft account (or an offline account) on startup.",
                    ["setting.discordrpc.tooltip"] = "Displays YAMCL in your Discord Rich Presence.",
                    ["btn.checkforupdates.text"] = "Check for updates",
                    ["btn.openinstancefolder.text"] = "Open folder",
                    ["btn.addmod.text"] = "Add a mod",
                    ["btn.editinst.text"] = "Edit instance",
                    ["btn.rminst.text"] = "Remove instance",
                    ["btn.createinst.text"] = "Create instance",
                    ["message.question.rminst"] = "Are you sure you want to remove instance \"[INSTANCE]\"?\n\nThis cannot be undone.",
                    ["message.success.rminst"] = "Successfully removed instance \"[INSTANCE]\"!",
                    ["btn.launchopts.text"] = "Launch options",
                    ["dialog.launchopts.title"] = "Launch Options",
                    ["dialog.launchopts.fullscreen"] = "Fullscreen",
                    ["dialog.launchopts.width"] = "Window width:",
                    ["dialog.launchopts.height"] = "Window height:",
                    ["dialog.update.installedver"] = "Current version: [VERSION]",
                    ["dialog.update.latestver"] = "Latest version: [VERSION]",
                    ["dialog.update.newupdate"] = "A new version of YAMCL is available!",
                    ["dialog.update.question"] = "Would you like to update?",
                    ["dialog.settings.title"] = "Settings",
                    ["message.info.langrestart"] = "Please restart YAMCL to fully apply the language setting.",
                    ["btn.close.tooltip"] = "Closes the app.",
                    ["btn.minimize.tooltip"] = "Minimizes the window.",
                    ["btn.maximize.tooltip"] = "Maximizes/restores the window."
                };

            if (!_translations.ContainsKey(Language.Polish))
                _translations[Language.Polish] = new Dictionary<string, string>()
                {
                    ["message.success.signin"] = "Pomyślnie zalogowano się jako [USERNAME]!",
                    ["message.success.signout"] = "Pomyślnie wylogowano się!",
                    ["message.question.signout"] = "Czy na pewno chcesz się wylogować?",
                    ["message.question.signin_ms"] = "Zalogować się przy użyciu konta Microsoft?",
                    ["message.error.selectinstance"] = "Proszę wybrać instancję!",
                    ["message.error.mc_not_running"] = "Minecraft nie jest uruchomiony!",
                    ["message.question.killmc"] = "Czy na pewno chcesz zakończyć działanie Minecrafta?\n\nTo może uszkodzić instancję, i powinno być używane tylko wtedy, gdy Minecraft się zawiesi.",
                    ["status.message.config_saved"] = "Zapisano konfigurację!",
                    ["status.installing.fabric"] = "Instalowanie Fabrica...",
                    ["status.installing.neoforge"] = "Instalowanie NeoForge'a...",
                    ["status.installing.forge"] = "Instalowanie Forge'a...",
                    ["status.installing.liteloader"] = "Instalowanie LiteLoadera...",
                    ["status.installing.quilt"] = "Instalowanie Quilta...",
                    ["message.error.signin"] = "Proszę się zalogować!",
                    ["btn.launch.launching_text"] = "Uruchamianie...",
                    ["btn.launch.text"] = "Uruchom",
                    ["btn.kill.text"] = "Zakończ",
                    ["btn.settings.text"] = "Ustawienia",
                    ["btn.signin.text"] = "Zaloguj się",
                    ["btn.signout.text"] = "Wyloguj się",
                    ["message.question.legacy"] = "Użyć sesji legacy?",
                    ["message.information.latest_ver"] = "Masz najnowszą wersję YAMCL!",
                    ["status.downloading.update"] = "Pobieranie aktualizacji...",
                    ["status.success.finish"] = "Skończone!",
                    ["dialog.instance.title"] = "Stwórz lub edytuj instancje",
                    ["dialog.instance.name"] = "Nazwa instancji:",
                    ["dialog.instance.version"] = "Wersja instancji:",
                    ["dialog.instance.loader"] = "Mod loader:",
                    ["dialog.auth.username"] = "Nazwa użytkownika:",
                    ["btn.cancel.text"] = "Anuluj",
                    ["btn.yes.text"] = "Tak",
                    ["btn.no.text"] = "Nie",
                    ["setting.autoupdate.text"] = "Automatyczne aktualizacje",
                    ["setting.autosignin.text"] = "Automatyczne logowanie",
                    ["setting.discordrpc.text"] = "Discord RPC",
                    ["setting.language.text"] = "Język",
                    ["setting.autoupdate.tooltip"] = "Sprawdza, czy masz najnowszą wesję YAMCL przy starcie.",
                    ["setting.autosignin.tooltip"] = "Pyta, czy chcesz zalogować się przy użyciu konta Microsoft (czy konta offline) przy starcie.",
                    ["setting.discordrpc.tooltip"] = "Wyświetla YAMCL na Discordzie.",
                    ["btn.checkforupdates.text"] = "Sprawdż aktualizacje",
                    ["btn.openinstancefolder.text"] = "Otwórz folder",
                    ["btn.addmod.text"] = "Dodaj moda",
                    ["btn.editinst.text"] = "Edytuj instancję",
                    ["btn.rminst.text"] = "Usuń instancję",
                    ["btn.createinst.text"] = "Stwórz instancję",
                    ["message.question.rminst"] = "Czy na pewno chcesz usunąć instancję \"[INSTANCE]\"?\n\nTo nie może być cofnięte.",
                    ["message.success.rminst"] = "Pomyślnie usunięto instancję \"[INSTANCE]\"!",
                    ["btn.launchopts.text"] = "Opcje uruchamiania",
                    ["dialog.launchopts.title"] = "Opcje Uruchamiania",
                    ["dialog.launchopts.fullscreen"] = "Pełny ekran",
                    ["dialog.launchopts.width"] = "Szerokość okna:",
                    ["dialog.launchopts.height"] = "Wysokość okna:",
                    ["dialog.update.installedver"] = "Obecna wersja: [VERSION]",
                    ["dialog.update.latestver"] = "Najnowsza wersja: [VERSION]",
                    ["dialog.update.newupdate"] = "Nowa wersja YAMCL jest dostępna!",
                    ["dialog.update.question"] = "Czy chcesz zaktualizować?",
                    ["dialog.settings.title"] = "Ustawienia",
                    ["message.info.langrestart"] = "Proszę zrestartować YAMCL, aby w pełni zastosować ustawienia języku.",
                    ["btn.close.tooltip"] = "Zamyka aplikację.",
                    ["btn.minimize.tooltip"] = "Minimalizuje okno.",
                    ["btn.maximize.tooltip"] = "Maksymalizuje/przywróca okno."
                };

            CurrentLanguage = GetLanguage();
        }

        public static Language GetLanguage()
        {
            return (Language)Enum.Parse(typeof(Language), ConfigManager.Config["language"].ToString());
        }

        public static string GetTranslation(string id)
        {
            if (_translations.TryGetValue(CurrentLanguage, out var helper))
            {
                if (!helper.ContainsKey(id))
                    throw new Exception($"Translation for {id} for {CurrentLanguage} not found!");

                return helper[id];
            }
            return id;
        }
    }
}
