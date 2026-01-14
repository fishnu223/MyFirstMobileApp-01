namespace MyFirstMobileApp.Views;
using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;

public partial class ControlsStepperPage : ContentPage
{
    public ControlsStepperPage()
    {
        InitializeComponent();
        BindingContext = new ControlsStepperViewModel();
    }
}