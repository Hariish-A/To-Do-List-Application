namespace MauiApp1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();    
            
            //Registers the route established between MainPage and DetailPage
            Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
        }
    }
}
