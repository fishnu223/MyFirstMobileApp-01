namespace MyFirstMobileApp.Views;
using MyFirstMobileApp.ViewModels;

public partial class ControlsEntryPage : ContentPage
{
	public ControlsEntryPage()
	{
		InitializeComponent();
		BindingContext = new ControlsEntryViewModel();
    }
}