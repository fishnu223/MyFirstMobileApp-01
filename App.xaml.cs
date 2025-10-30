using MyFirstMobileApp.Views;

namespace MyFirstMobileApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Mainpage = new AppShell();
            //MainPage = new MainPage();
            //Old
            //MainPage = new NavigationPage(new MainPage());

            MainPage = new AppShell();
            
            
        }
    }
}
