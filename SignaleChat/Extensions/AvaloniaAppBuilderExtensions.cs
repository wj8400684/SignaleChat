using System;
using System.Diagnostics.CodeAnalysis;
using Avalonia;
using Avalonia.Media;
using Avalonia.Media.Fonts;

namespace SignaleChat;

public static class AvaloniaAppBuilderExtensions
{
    public static AppBuilder UseFontAlibaba([DisallowNull] this AppBuilder builder, Action<FontSettings>? configDelegate = default)
    {
        var setting = new FontSettings();
        configDelegate?.Invoke(setting);
 
        return builder.With(new FontManagerOptions
        {
            DefaultFamilyName = setting.DefaultFontFamily,
            FontFallbacks = new[]
            {
                new FontFallback
                {
                    FontFamily = new FontFamily(setting.DefaultFontFamily)
                }
            }
        }).ConfigureFonts(manager => manager.AddFontCollection(new EmbeddedFontCollection(setting.Key, setting.Source)));
    }
}