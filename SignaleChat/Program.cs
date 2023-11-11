using Avalonia;
using Avalonia.Fonts;
using Avalonia.Fonts.Inter;
using System;

namespace SignaleChat;

class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
    {
        return AppBuilder.Configure<App>()
                         .WithInterFont()
                         .UsePlatformDetect()
                         .LogToTrace();
    }
}