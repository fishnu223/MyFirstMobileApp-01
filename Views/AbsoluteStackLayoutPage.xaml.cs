using MyFirstMobileApp.ViewModels;
namespace MyFirstMobileApp.Views;

public partial class AbsoluteStackLayoutPage : ContentPage
{
	public AbsoluteStackLayoutPage()
	{
		InitializeComponent();
		BindingContext = new AbsoluteLayoutViewModel();
	}
}