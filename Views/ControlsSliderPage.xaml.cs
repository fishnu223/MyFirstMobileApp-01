namespace MyFirstMobileApp.Views;
using MyFirstMobileApp.ViewModels;

public partial class ControlsSliderPage : ContentPage
{
	public ControlsSliderPage()
	{
		InitializeComponent();
		BindingContext = new ControlsSliderViewModel();
    }
}