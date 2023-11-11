using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SignaleChat.Controls;

public partial class UserProfile : UserControl
{
    public UserProfile()
    {
        InitializeComponent();
    }

    public string Name { get; set; } = null!;
}