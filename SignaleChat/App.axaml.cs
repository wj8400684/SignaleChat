using System.Runtime.InteropServices;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using SignaleChat.ViewModels;
using SignaleChat.Views;

namespace SignaleChat;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            // Line below is needed to remove Avalonia data validation.
            // Without this line you will get duplicate validations from both Avalonia and CT
            BindingPlugins.DataValidators.RemoveAt(0);
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel(),
            };
            
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                desktop.MainWindow.Classes.Clear();
                desktop.MainWindow.Classes.Add("Windows");
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                desktop.MainWindow.Classes.Clear();
                desktop.MainWindow.Classes.Add("Mac");
            }
        }

        base.OnFrameworkInitializationCompleted();
    }
}
