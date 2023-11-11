using Avalonia;
using Avalonia.Controls;

namespace SignaleChat.Controls;

public sealed class NavButton : RadioButton
{
    /// <summary>
    /// 未选中时候的sbg图标
    /// </summary>
    public static readonly StyledProperty<object> UnCheckedSvgProperty =
        AvaloniaProperty.Register<NavButton, object>(nameof(UnCheckedSvg));
    
    /// <summary>
    /// 未选中时候的sbg图标
    /// </summary>
    public object UnCheckedSvg
    {
        get => GetValue(UnCheckedSvgProperty);
        set => SetValue(UnCheckedSvgProperty, value);
    }
}