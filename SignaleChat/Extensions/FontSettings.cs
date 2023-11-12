using System;

namespace SignaleChat;

public class FontSettings
{
    public string DefaultFontFamily = "fonts:Alibaba#Alibaba PuHuiTi 3.0";
    public Uri Key { get; set; } = new Uri("fonts:Alibaba", UriKind.Absolute);
    public Uri Source { get; set; } = new Uri("avares://SignaleChat/Assets/Fonts/Alibab", UriKind.Absolute);
}