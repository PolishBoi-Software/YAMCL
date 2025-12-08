using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;

namespace YetAnotherMinecraftLauncher;

public partial class OfflineSignInDialog : Window
{
    public bool Submitted { get; private set; }
    public string Username { get; private set; }

    public OfflineSignInDialog()
    {
        InitializeComponent();
    }

    private void SubmitBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Submitted = true;
        Username = UsernameBox.Text ?? $"Player{new Random().Next(1, 1000)}";
        Close();
    }
}