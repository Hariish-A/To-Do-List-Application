using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

//CommunityToolkit is enabled by right-clicking on the Highlighted red color ObservableObject
//and click Quick Actions and refactoring

namespace MauiApp1.ViewModel;

[QueryProperty("Text", "Text")]
public partial class DetailViewModel : ObservableObject
{
    //text instance is created
    [ObservableProperty]
    string text;

    //Used for Back-button
    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }
}
