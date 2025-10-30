using MyFirstMobileApp.ViewModels;

namespace MyFirstMobileApp.Views;

public partial class VerticalStackLayoutPage : ContentPage
{
	public VerticalStackLayoutPage()
	{
		InitializeComponent();
		BindingContext = new VerticalStackLayoutViewModel();
	}
}