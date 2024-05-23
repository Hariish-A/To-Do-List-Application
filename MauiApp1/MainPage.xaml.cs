using MauiApp1.ViewModel;

//Comes From .NETCommunityToolkit
//Enabled by right clicking on highlighted red region and click on Quick Actions and Refactoring

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewModel vm)
        {
            //Bind this MainViewModel to the DetailPage
            InitializeComponent();
            BindingContext = vm;
        }



    }
}
