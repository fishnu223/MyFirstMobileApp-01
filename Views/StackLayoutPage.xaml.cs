using MyFirstMobileApp.ViewModels;

namespace MyFirstMobileApp.Views;

public partial class StackLayoutPage : ContentPage
{
	public StackLayoutPage()
	{
		InitializeComponent();
		BindingContext = new StackLayoutViewModel();
    }
}