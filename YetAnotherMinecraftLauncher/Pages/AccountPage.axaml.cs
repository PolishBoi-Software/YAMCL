using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Controls.Notifications;
using Avalonia.Markup.Xaml;
using Avalonia.Platform.Storage;
using CustomMessageBox.Avalonia;
using MojangAPI;
using MojangAPI.Model;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using YetAnotherMinecraftLauncher.Core;
using YetAnotherMinecraftLauncher.Core.Utils;

namespace YetAnotherMinecraftLauncher;

public partial class AccountPage : UserControl
{
    public AccountPage()
    {
        InitializeComponent();
    }

    public async Task SignInOrOut(bool canCancel = true)
    {
        if (AuthManager.Session == null)
        {
            var result = await MessageBox.Show("Sign in with a Microsoft account?", "YAMCL", canCancel ? MessageBoxButtons.YesNoCancel : MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == MessageBoxResult.Yes)
            {
                await AuthManager.SignIn();
            }
            else if (result == MessageBoxResult.No)
            {
                var dial = new OfflineSignInDialog();

                Window? window = MainWindow.GetMainWindow();

                if (window != null)
                    await dial.ShowDialog(window);

                if (dial.Submitted)
                    AuthManager.SignIn(dial.Username);
                else
                    return;
            }
            else
                return;

            SignInOutBtn.Content = "Sign out";
            string urlFace = $"https://nmsr.nickac.dev/face/{AuthManager.Session?.UUID}";
            string urlFront = $"https://nmsr.nickac.dev/frontfull/{AuthManager.Session?.UUID}";
            AvatarImage.Source = await ImageUtils.FromWeb(new Uri(urlFace));
            SkinImage.Source = await ImageUtils.FromWeb(new Uri(urlFront));
            UUIDText.Text = AuthManager.Session?.UUID;
            UsernameText.Text = AuthManager.Session?.Username;
            MainWindow.ShowToast("YAMCL", $"Successfully signed in as {AuthManager.Session?.Username}!", ToastType.Success);
        }
        else
        {
            var result = await MessageBox.Show("Are you sure you want to sign out?", "YAMCL", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == MessageBoxResult.Yes)
            {
                await AuthManager.SignOut();
                SignInOutBtn.Content = "Sign in";
                UUIDText.Text = "UUID";
                UsernameText.Text = "USERNAME";
                AvatarImage.Source = null;
                SkinImage.Source = null;
                MainWindow.ShowToast("YAMCL", "Successfully signed out!", ToastType.Success);
            }
        }
    }

    private async void SignInOutBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        await SignInOrOut();
    }

    private async void ChangeSkinBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (AuthManager.Session == null)
        {
            MainWindow.ShowToast("YAMCL", "Please sign in!", ToastType.Error);
            return;
        }

        try
        {
            MainWindow.ShowToast("YAMCL", "Checking if you own Java Edition...", duration: 1);
            Mojang mojang = new Mojang();
            var ownsMinecraft = await mojang.CheckGameOwnership(AuthManager.Session?.AccessToken);

            if (!ownsMinecraft)
            {
                MainWindow.ShowToast("YAMCL", "You don't own Java Edition!\n\nPlease note that this doesn't check Xbox Game Pass.", ToastType.Error);
                return;
            }

            var window = MainWindow.GetMainWindow();

            if (window != null)
            {
                var files = await window.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions
                {
                    Title = "Select a skin",
                    AllowMultiple = false,
                    FileTypeFilter = new[]
                    {
                        new FilePickerFileType("Minecraft Skins")
                        {
                            Patterns = new[] { "*.png" }
                        }
                    }
                });

                if (files.Count >= 1)
                {
                    await using var stream = await files[0].OpenReadAsync();
                    var skinTypeResult = await MessageBox.Show("Use Alex skin type?", "YAMCL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    await mojang.UploadSkin(AuthManager.Session?.AccessToken, skinTypeResult == MessageBoxResult.Yes ? SkinType.Alex : SkinType.Steve, stream, $"skin{Guid.NewGuid().ToString().Replace("-", "")}");
                    MainWindow.ShowToast("YAMCL", "Successfully uploaded skin!", ToastType.Success);
                }
            }
        }
        catch (Exception ex)
        {
            await MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}