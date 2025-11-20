namespace MyFirstMobileApp.Views;
using MyFirstMobileApp.ViewModels;
public partial class URIImagesPage : ContentPage
{
	public URIImagesPage()
	{
		InitializeComponent();
		BindingContext = new URIImagesViewModel();
	}
}