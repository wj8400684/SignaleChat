using System.Collections.Generic;
using System.Linq;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SignaleChat.Views;

namespace SignaleChat.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private static readonly Dictionary<string, UserControl> _pages = new();
    [ObservableProperty] private object _content = null!;


    public MainWindowViewModel()
    {
        _pages.Add("TabBarContacts", new ContactsPage());
        _pages.Add("TabBarFavorites", new FavoritesPage());
        Content = new ChatPage();
        _pages.Add("TabBarChat", (ChatPage)Content);
    }

    [RelayCommand]
    private void OnSelected(string name)
    {
        Content = _pages[name];
    }
}