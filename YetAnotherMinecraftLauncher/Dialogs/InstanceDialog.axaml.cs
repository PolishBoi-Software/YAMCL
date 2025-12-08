using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CmlLib.Core;
using CmlLib.Core.VersionMetadata;
using CustomMessageBox.Avalonia;
using System;
using System.Linq;
using System.Threading.Tasks;
using YetAnotherMinecraftLauncher.Core;
using YetAnotherMinecraftLauncher.Core.Utils;

namespace YetAnotherMinecraftLauncher;

public partial class InstanceDialog : Window
{
    private MinecraftLauncher launcher;
    public bool Submitted { get; private set; }
    public Instance InstanceResult { get; private set; }
    private bool EditMode = false;
    private Instance previousInst;

    public InstanceDialog(Instance prevInst = null)
    {
        InitializeComponent();

        launcher = new MinecraftLauncher();
        previousInst = prevInst;
        EditMode = prevInst != null;

        if (EditMode)
        {
            CreateButton.Content = "Edit";
            Title = $"Editing \"{previousInst.Name}\"";
        }
    }

    protected override async void OnOpened(EventArgs e)
    {
        base.OnOpened(e);
        var versions = await launcher.GetAllVersionsAsync();

        foreach (var version in versions)
            InstanceVersionBox.Items.Add(version);

        foreach (var loader in Enum.GetValues<ModLoader>())
            InstanceLoaderBox.Items.Add(loader);
    }

    private async void CreateButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var versions = await launcher.GetAllVersionsAsync();
        Submitted = true;
        string version;

        if (EditMode)
        {
            if (InstanceVersionBox.SelectedItem == null)
                version = previousInst.Version;
            else
                version = (InstanceVersionBox.SelectedItem as IVersionMetadata).Name;
        }
        else
        {
            var selectedVer = InstanceVersionBox.SelectedItem as IVersionMetadata;
            version = selectedVer?.Name ?? versions.Where(v => v.Type == "release").FirstOrDefault().Name;
        }

        ModLoader loader;
        if (EditMode)
        {
            if (InstanceLoaderBox.SelectedItem != null)
            {
                var selectedLoader = InstanceLoaderBox.SelectedItem.ToString();
                loader = ModLoaderUtils.GetModLoaderFromName(selectedLoader);
            }
            else
            {
                loader = previousInst.Loader;
            }
        }
        else
        {
            loader = InstanceLoaderBox.SelectedItem != null ? ModLoaderUtils.GetModLoaderFromName(InstanceLoaderBox.SelectedItem.ToString()) : ModLoader.Vanilla;
        }

        string name;
        if (EditMode)
        {
            if (string.IsNullOrEmpty(InstanceNameBox.Text))
                name = previousInst.Name;
            else
                name = InstanceNameBox.Text;
        }
        else
        {
            if (string.IsNullOrEmpty(InstanceNameBox.Text))
                name = $"Instance{InstanceManager.Instances.Where(i => i.Name.StartsWith("Instance")).Count() + 1}";
            else
                name = InstanceNameBox.Text;
        }

        InstanceResult = new Instance(name, version, version, loader);
        Close();
    }
}