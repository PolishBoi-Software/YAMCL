using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Controls.Notifications;
using Message.Avalonia;
using CustomMessageBox.Avalonia;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YetAnotherMinecraftLauncher.Core;
using Message.Avalonia.Models;
using Avalonia.Threading;
using YetAnotherMinecraftLauncher.Core.Utils;

namespace YetAnotherMinecraftLauncher
{
    public enum ToastType
    {
        Success,
        Error,
        Info,
        Warning
    }

    public partial class MainWindow : Window
    {
        private List<UserControl> pages;

        public MainWindow()
        {
            InitializeComponent();
            pages = new List<UserControl>()
            {
                new AccountPage(),
                new InstancePage(),
                new SettingsPage()
            };
        }

        protected override void OnClosing(WindowClosingEventArgs e)
        {
            ConfigManager.WriteConfig();
            ModrinthUtils.Free();
        }

        protected override async void OnOpened(EventArgs e)
        {
            base.OnOpened(e);

            if (ConfigManager.Config.RichPresence)
            {
                ShowToast("YAMCL", "Starting Discord RPC...");
                DiscordRichPresence.Init();
            }

            if (ConfigManager.Config.AutoSignIn)
            {
                var page = pages[0] as AccountPage;

                if (page != null)
                    await Dispatcher.UIThread.InvokeAsync(async () => await page.SignInOrOut(false));
            }

            if (ConfigManager.Config.AutoUpdate)
            {
                bool updatesFound = await Program.AppManager.CheckForUpdatesAsync();

                if (!updatesFound)
                {
                    ShowToast("YAMCL", "No updates found.");
                    return;
                }

                ShowToast("YAMCL", $"An update was found!\n\nLatest: {Program.AppManager.LatestReleaseTagVersionStr}\nCurrent: {Program.AppManager.CurrentVersion}", ToastType.Warning);
            }
        }

        public static void ShowToast(string title, string content, ToastType type = ToastType.Info, int duration = 2)
        {
            var builder = MessageManager.Default.CreateMessage().WithDuration((uint)duration).WithTitle(title).WithContent(content);

            switch (type)
            {
                case ToastType.Success:
                    builder.ShowSuccess();
                    break;

                case ToastType.Error:
                    builder.ShowError();
                    break;

                case ToastType.Info:
                    builder.ShowInfo();
                    break;

                case ToastType.Warning:
                    builder.ShowWarning();
                    break;
            }
        }

        public static Window? GetMainWindow()
        {
            if (Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
                return desktop.MainWindow;
            else
                return null;
        }

        private void AccountBtnClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainContent.Content = pages[0];
        }

        private void InstancesBtnClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainContent.Content = pages[1];
        }

        private void SettingsBtnClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainContent.Content = pages[2];
        }
    }
}