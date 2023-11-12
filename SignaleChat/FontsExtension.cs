using System;
using System.Diagnostics.CodeAnalysis;
using Avalonia;
using Avalonia.Media;
using Avalonia.Media.Fonts;

namespace SignaleChat;

public static class FontsExtension
{
    public static class FontSettings
    {
        public static Uri Key { get; } = new Uri("fonts:MicrosoftYaHei", UriKind.Absolute);
        public static Uri Source { get; } = new Uri("avares://SignaleChat/Assets/Fonts", UriKind.Absolute);
    }

    public static class AlibabaFontSettings
    {
        public static Uri Key { get; } = new Uri("fonts:AlibabaPuHuiTi", UriKind.Absolute);
        public static Uri Source { get; } = new Uri("avares://WHOrigin.FrontDesk/Assets/Fonts/AliBaba", UriKind.Absolute);
    }

    public static class LcdFontSettings
    {
        public static Uri Key { get; } = new Uri("fonts:LCD", UriKind.Absolute);
        public static Uri Source { get; } = new Uri("avares://WHOrigin.FrontDesk/Assets/Fonts/LCD", UriKind.Absolute);
    }
    
    public static AppBuilder UseFontFamily([DisallowNull] this AppBuilder builder)
    {
        builder.With(new FontManagerOptions
        {
            DefaultFamilyName = "avares://SignaleChat/Assets/Fonts/my.ttf#Microsoft YaHei",
            FontFallbacks = new[]
            {
                new  FontFallback
                {
                    FontFamily = new FontFamily("avares://SignaleChat/Assets/Fonts/my.ttf#Microsoft YaHei")
                }
            }
        });
        return builder.ConfigureFonts(manager => manager.AddFontCollection(new EmbeddedFontCollection(FontSettings.Key, FontSettings.Source)))
            //.ConfigureFonts(manager => manager.AddFontCollection(new EmbeddedFontCollection(AlibabaFontSettings.Key, AlibabaFontSettings.Source)))
            //.ConfigureFonts(manager => manager.AddFontCollection(new EmbeddedFontCollection(LcdFontSettings.Key, LcdFontSettings.Source)));
            ;
    }
}