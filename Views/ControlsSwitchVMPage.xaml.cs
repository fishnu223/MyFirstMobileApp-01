namespace MyFirstMobileApp.Views;
using MyFirstMobileApp.ViewModels;

public partial class ControlsSwitchVMPage : ContentPage
{
	public ControlsSwitchVMPage()
	{
		InitializeComponent();
		BindingContext = new ControlsSwitchVMViewModel();
	}
}