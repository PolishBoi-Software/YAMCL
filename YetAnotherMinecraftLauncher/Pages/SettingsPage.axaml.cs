using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System.Threading.Tasks;
using YetAnotherMinecraftLauncher.Core;

namespace YetAnotherMinecraftLauncher;

public partial class SettingsPage : UserControl
{
    public SettingsPage()
    {
        InitializeComponent();
        AutoSignInCheck.IsChecked = ConfigManager.Config.AutoSignIn;
        AutoUpdateCheck.IsChecked = ConfigManager.Config.AutoUpdate;
        DiscordRPCCheck.IsChecked = ConfigManager.Config.RichPresence;

        AutoSignInCheck.IsCheckedChanged += AutoSignInCheck_IsCheckedChanged;
        AutoUpdateCheck.IsCheckedChanged += AutoUpdateCheck_IsCheckedChanged;
        DiscordRPCCheck.IsCheckedChanged += DiscordRPCCheck_IsCheckedChanged;
    }

    private void DiscordRPCCheck_IsCheckedChanged(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        ConfigManager.Config.RichPresence = (bool)DiscordRPCCheck.IsChecked;
    }

    private void AutoUpdateCheck_IsCheckedChanged(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        ConfigManager.Config.AutoUpdate = (bool)AutoUpdateCheck.IsChecked;
    }

    private void AutoSignInCheck_IsCheckedChanged(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        ConfigManager.Config.AutoSignIn = (bool)AutoSignInCheck.IsChecked;
    }
}