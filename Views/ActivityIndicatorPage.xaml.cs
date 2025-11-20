namespace MyFirstMobileApp.Views;
using MyFirstMobileApp.ViewModels;
public partial class ActivityIndicatorPage : ContentPage
{
	public ActivityIndicatorPage()
	{
		InitializeComponent();
        BindingContext = new ActivityIndicatorViewModel();
    }
}