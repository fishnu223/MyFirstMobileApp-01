using MyFirstMobileApp.ViewModels;
namespace MyFirstMobileApp.Views;

public partial class ImagesPage : ContentPage
{
	public ImagesPage()
	{
		InitializeComponent();
		BindingContext = new ImagesViewModel();
	}
}