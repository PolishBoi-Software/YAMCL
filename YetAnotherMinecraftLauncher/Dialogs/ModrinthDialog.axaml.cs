using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CustomMessageBox.Avalonia;
using Modrinth;
using System;
using System.IO;
using System.Threading.Tasks;
using YetAnotherMinecraftLauncher.Core;
using YetAnotherMinecraftLauncher.Core.Utils;

namespace YetAnotherMinecraftLauncher;

public partial class ModrinthDialog : Window
{
    private Instance inst;
    public ModrinthDialog(Instance instance)
    {
        InitializeComponent();
        inst = instance;
        _ = RefreshSearches();
    }

    protected override async void OnOpened(EventArgs e)
    {
        base.OnOpened(e);

        if (inst.Loader == ModLoader.Vanilla)
        {
            await MessageBox.Show("You are using Minecraft vanilla!\n\nIf you want, edit the chosen instance to use a mod loader you want.", "YAMCL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            InstallBtn.IsEnabled = false;
        }
    }

    private async Task RefreshSearches(string query = "")
    {
        var searches = await ModrinthUtils.GetMods(query);

        ModList.Items.Clear();

        foreach (var project in searches)
            ModList.Items.Add(project);
    }

    private async void SearchBox_KeyDown(object? sender, Avalonia.Input.KeyEventArgs e)
    {
        if (e.Key == Avalonia.Input.Key.Enter)
            await RefreshSearches(SearchBox.Text);
    }

    private async void InstallBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (ModList.SelectedItem == null)
        {
            StatusText.Text = "No mod selected, please select one!";
            return;
        }

        InstallBtn.IsEnabled = false;
        string path = Path.Combine(inst.MCPath.BasePath, "mods");

        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);

        var proj = (Modrinth.Models.Project)ModList.SelectedItem;
        StatusText.Text = $"Installing {proj.Title} (and its dependencies)...";
        await ModrinthUtils.DownloadMod(proj, inst.Loader, inst.BaseVersion, path, ProgBar);
        StatusText.Text = "Finished!";
        InstallBtn.IsEnabled = true;
        ProgBar.Value = 0;
    }
}