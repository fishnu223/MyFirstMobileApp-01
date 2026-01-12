namespace MyFirstMobileApp.Views;
using MyFirstMobileApp.ViewModels;

public partial class ControlsSliderVMPage : ContentPage
{
	public ControlsSliderVMPage()
	{
		InitializeComponent();
		BindingContext = new ControlsSliderVMViewModel();
    }
}