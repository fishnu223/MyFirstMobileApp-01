namespace MyFirstMobileApp.Views;
using MyFirstMobileApp.ViewModels;

public partial class ControlsSwitchPage : ContentPage
{
	public ControlsSwitchPage()
	{
		InitializeComponent();
		BindingContext = new ControlsSwitchViewModel();
	}
}