namespace MyFirstMobileApp.Views;
using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;

public partial class ControlsPage : ContentPage
{
	public ControlsPage()
	{
		InitializeComponent();
		BindingContext = new ControlsViewModel();
	}
}