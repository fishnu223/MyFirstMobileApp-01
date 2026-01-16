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
            // Layouts
            Routing.RegisterRoute(nameof(LayoutsPage), typeof(LayoutsPage));
            Routing.RegisterRoute(nameof(StackLayoutPage), typeof(StackLayoutPage));
            Routing.RegisterRoute(nameof(VerticalStackLayoutPage), typeof(VerticalStackLayoutPage));
            Routing.RegisterRoute(nameof(HorizontalStackLayoutPage), typeof(HorizontalStackLayoutPage));
            Routing.RegisterRoute(nameof(FlexLayoutPage), typeof(FlexLayoutPage));
            Routing.RegisterRoute(nameof(AbsoluteStackLayoutPage), typeof(AbsoluteStackLayoutPage));

            // Images
            Routing.RegisterRoute(nameof(ImagesPage), typeof(ImagesPage));
            Routing.RegisterRoute(nameof(EmbeddedImagesPage), typeof(EmbeddedImagesPage));
            Routing.RegisterRoute(nameof(URIImagesPage), typeof(URIImagesPage));
            Routing.RegisterRoute(nameof(ActivityIndicatorPage), typeof(ActivityIndicatorPage));

            //Controls
            Routing.RegisterRoute(nameof(ControlsPage), typeof(ControlsPage));
            Routing.RegisterRoute(nameof(ControlsSwitchPage), typeof(ControlsSwitchPage)); 
            Routing.RegisterRoute(nameof(ControlsSwitchVMPage), typeof(ControlsSwitchVMPage));
            Routing.RegisterRoute(nameof(ControlsSwitchXAMLPage), typeof(ControlsSwitchXAMLPage));
            Routing.RegisterRoute(nameof(ControlsSliderPage), typeof(ControlsSliderPage));
            Routing.RegisterRoute(nameof(ControlsSliderVMPage), typeof(ControlsSliderVMPage));
            Routing.RegisterRoute(nameof(ControlsSliderXAMLPage), typeof(ControlsSliderXAMLPage));
            Routing.RegisterRoute(nameof(ControlsStepperPage), typeof(ControlsStepperPage));
            Routing.RegisterRoute(nameof(ControlsStepperXAMLPage), typeof(ControlsStepperXAMLPage));
            Routing.RegisterRoute(nameof(ControlsStepperVMPage), typeof(ControlsStepperVMPage));
            Routing.RegisterRoute(nameof(ControlsEntryPage), typeof(ControlsEntryPage));
            Routing.RegisterRoute(nameof(ControlsEntryVMPage), typeof(ControlsEntryVMPage));
            Routing.RegisterRoute(nameof(ControlsEntryXAMLPage), typeof(ControlsEntryXAMLPage));
            Routing.RegisterRoute(nameof(ControlsPickerPage), typeof(ControlsPickerPage));
            Routing.RegisterRoute(nameof(ControlsDateandTimePage), typeof(ControlsDateandTimePage));

        }
    }
}
