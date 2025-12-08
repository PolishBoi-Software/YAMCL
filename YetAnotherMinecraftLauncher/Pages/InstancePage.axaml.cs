using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Platform.Storage;
using ByteSizeLib;
using CmlLib.Core.ProcessBuilder;
using CustomMessageBox.Avalonia;
using System;
using System.IO;
using System.Threading.Tasks;
using YetAnotherMinecraftLauncher.Core;

namespace YetAnotherMinecraftLauncher;

public partial class InstancePage : UserControl
{
    public InstancePage()
    {
        InitializeComponent();
        RefreshInstances();
    }

    private void RefreshInstances()
    {
        InstanceBox.Items.Clear();

        foreach (var instance in InstanceManager.Instances)
            InstanceBox.Items.Add(instance);
    }

    private async void LaunchButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (AuthManager.Session == null)
        {
            MainWindow.ShowToast("YAMCL", "Please sign in!", ToastType.Error);
            return;
        }

        if (InstanceBox.SelectedItem == null)
        {
            MainWindow.ShowToast("YAMCL", "Please select an instance!", ToastType.Error);
            return;
        }

        Instance instance = InstanceManager.Instances[InstanceBox.SelectedIndex];

        try
        {
            LaunchButton.IsEnabled = false;
            LaunchButton.Content = "Launching...";
            instance.Init(false);

            instance.Launcher.ByteProgressChanged += (s, ev) =>
            {
                Avalonia.Threading.Dispatcher.UIThread.Invoke(() =>
                {
                    ProgBar.Value = ev.ToRatio() * 100;
                    ByteProgressLabel.Text = $"{ByteSize.FromBytes(ev.ProgressedBytes)} / {ByteSize.FromBytes(ev.TotalBytes)}";
                });
            };

            instance.Launcher.FileProgressChanged += (s, ev) =>
            {
                Avalonia.Threading.Dispatcher.UIThread.Invoke(() =>
                {
                    StatusLabel.Text = ev.Name;
                    TaskCountLabel.Text = $"[{ev.ProgressedTasks}/{ev.TotalTasks}]";
                });
            };

            await instance.Launch(new MLaunchOption()
            {
                Session = AuthManager.Session,
                MinimumRamMb = 1024
            });

            ByteProgressLabel.Text = "0 B / 0 B";
            ProgBar.Value = 0;
            StatusLabel.Text = "Ready";
        }
        catch (Exception ex)
        {
            await MessageBox.Show(ex.Message, ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        LaunchButton.IsEnabled = true;
        LaunchButton.Content = "Launch";
    }

    private async void RemoveInstanceButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (InstanceBox.SelectedItem == null)
        {
            MainWindow.ShowToast("YAMCL", "Please select an instance!", ToastType.Error);
            return;
        }

        Instance instance = InstanceManager.Instances[InstanceBox.SelectedIndex];

        var result = await MessageBox.Show("Are you sure you want to delete this instance?\n\nTHIS CANNOT BE UNDONE!", "YAMCL", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (result == MessageBoxResult.Yes)
        {
            try
            {
                instance.Remove();
                InstanceManager.Instances.Remove(instance);
                RefreshInstances();
            }
            catch (Exception ex)
            {
                await MessageBox.Show(ex.Message, ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private async void CreateInstanceButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var dial = new InstanceDialog();

        Window? window = MainWindow.GetMainWindow();

        if (window != null)
            await dial.ShowDialog(window);

        if (dial.Submitted)
        {
            InstanceManager.Instances.Add(dial.InstanceResult);
            RefreshInstances();
            dial.InstanceResult.Init(false);
        }
    }

    private async void EditInstanceButton_Click(object? sender, RoutedEventArgs e)
    {
        if (InstanceBox.SelectedItem == null)
        {
            MainWindow.ShowToast("YAMCL", "Please select an instance!", ToastType.Error);
            return;
        }

        Instance instance = InstanceManager.Instances[InstanceBox.SelectedIndex];

        var dial = new InstanceDialog(instance);

        Window? window = MainWindow.GetMainWindow();

        if (window != null)
            await dial.ShowDialog(window);

        if (dial.Submitted)
        {
            var oldInstance = instance;
            try
            {
                InstanceManager.Instances[InstanceBox.SelectedIndex] = dial.InstanceResult;

                if (dial.InstanceResult.Name != oldInstance.Name)
                    Directory.Move(oldInstance.MCPath.BasePath, dial.InstanceResult.MCPath.BasePath);

                RefreshInstances();
                dial.InstanceResult.Init(false);
            }
            catch (Exception ex)
            {
                await MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                InstanceManager.Instances[InstanceBox.SelectedIndex] = instance;
            }
        }
    }

    private async void KillButton_Click(object? sender, RoutedEventArgs e)
    {
        if (InstanceBox.SelectedItem == null)
        {
            MainWindow.ShowToast("YAMCL", "Please select an instance!", ToastType.Error);
            return;
        }

        Instance instance = InstanceManager.Instances[InstanceBox.SelectedIndex];

        if (!instance.IsRunning)
        {
            MainWindow.ShowToast("YAMCL", "This instance is not running!", ToastType.Error);
            return;
        }

        try
        {
            var result = await MessageBox.Show("Are you sure you want to kill this instance?\n\nThis may cause corruption.\nUse it ONLY when Minecraft crashes.", "YAMCL", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == MessageBoxResult.Yes)
            {
                instance.Exit();
                MainWindow.ShowToast("YAMCL", $"Successfully killed \"{instance.Name}\"");
            }
        }
        catch (Exception ex)
        {
            {
                await MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private async void AddModButton_Click(object? sender, RoutedEventArgs e)
    {
        if (InstanceBox.SelectedItem == null)
        {
            MainWindow.ShowToast("YAMCL", "Please select an instance!", ToastType.Error);
            return;
        }

        Instance instance = InstanceManager.Instances[InstanceBox.SelectedIndex];

        var dial = new ModrinthDialog(instance);

        Window? window = MainWindow.GetMainWindow();

        if (window != null)
            await dial.ShowDialog(window);
    }
}