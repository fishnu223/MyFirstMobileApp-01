namespace MyFirstMobileApp.Views;

using FirstMauiMobileApp.ViewModels;
using MyFirstMobileApp.ViewModels;

public partial class ControlsStepperVMPage : ContentPage
{
    public ControlsStepperVMPage()
    {
        InitializeComponent();
        BindingContext = new ControlsStepperVMViewModel();
    }
}