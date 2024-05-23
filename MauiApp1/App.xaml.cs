namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Creating a new Object of the AppShell class to create an instance of the AppShell.
            MainPage = new AppShell();
        }
    }
}
