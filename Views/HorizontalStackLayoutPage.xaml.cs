using MyFirstMobileApp.ViewModels;

namespace MyFirstMobileApp.Views;

public partial class HorizontalStackLayoutPage : ContentPage
{
	public HorizontalStackLayoutPage()
	{
		InitializeComponent();
		BindingContext = new HorizontalStackLayoutViewModel();
	}
}