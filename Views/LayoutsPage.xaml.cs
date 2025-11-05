using MyFirstMobileApp.ViewModels;

namespace MyFirstMobileApp.Views;

public partial class LayoutsPage : ContentPage
{
	public LayoutsPage()
	{
		InitializeComponent();
		BindingContext = new LayoutsViewModel();
		 
	}
}