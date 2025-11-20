using MyFirstMobileApp.Views;   

namespace MyFirstMobileApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute(nameof(LayoutsPage), typeof(LayoutsPage));
            Routing.RegisterRoute(nameof(StackLayoutPage), typeof(StackLayoutPage));
            Routing.RegisterRoute(nameof(VerticalStackLayoutPage), typeof(VerticalStackLayoutPage));
            Routing.RegisterRoute(nameof(HorizontalStackLayoutPage), typeof(HorizontalStackLayoutPage));
            Routing.RegisterRoute(nameof(FlexLayoutPage), typeof(FlexLayoutPage));
            Routing.RegisterRoute(nameof(AbsoluteStackLayoutPage), typeof(AbsoluteStackLayoutPage));
            Routing.RegisterRoute(nameof(ImagesPage), typeof(ImagesPage));
            Routing.RegisterRoute(nameof(EmbeddedImagesPage), typeof(EmbeddedImagesPage));
            Routing.RegisterRoute(nameof(URIImagesPage), typeof(URIImagesPage));
            Routing.RegisterRoute(nameof(ActivityIndicatorPage), typeof(ActivityIndicatorPage));
        }
    }
}
