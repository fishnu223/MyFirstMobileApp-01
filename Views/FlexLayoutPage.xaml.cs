using MyFirstMobileApp.ViewModels;
namespace MyFirstMobileApp.Views;

public partial class FlexLayoutPage : ContentPage
{
	public FlexLayoutPage()
	{
		InitializeComponent();
		BindingContext = new FlexLayoutViewModel();
	}
}