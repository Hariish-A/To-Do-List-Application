

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;

//CommunityToolkit is enabled by right-clicking on the Highlighted red color ObservableObject
//and click Quick Actions and refactoring

namespace MauiApp1.ViewModel;

public partial class MainViewModel : ObservableObject
{
    IConnectivity connectivity;

    //Added for enabling the option of application running only if there is internet 
    public MainViewModel(IConnectivity connectivity)
    {
        Items = new ObservableCollection<string>();
        this.connectivity = connectivity;
    }
    
    //Creating an Instance of text
    [ObservableProperty]
    ObservableCollection<string> items;

    [ObservableProperty]
    string text;

    //Used for the add button functionality
    [RelayCommand]
    async Task Add()
    {
        if (string.IsNullOrWhiteSpace(Text))
            return;

        if(connectivity.NetworkAccess != NetworkAccess.Internet)
        {
            await Shell.Current.DisplayAlert("Uh Oh!", "No Internet", "OK");
            return;
        }
        
        Items.Add(Text);
        Text = string.Empty;
    }

    //Used for the delete button functionality
    [RelayCommand]
    void Delete(string s)
    {
        if(Items.Contains(s))
        {
            Items.Remove(s);
        }
    }

    //Used to display details of a created object using Add
    [RelayCommand]
    async Task Tap(string s)
    {
        await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}");
    }
    
}
