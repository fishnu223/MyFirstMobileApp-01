namespace MyFirstMobileApp.Views;
using MyFirstMobileApp.ViewModels;
public partial class EmbeddedImagesPage : ContentPage
{
	public EmbeddedImagesPage()
	{
		InitializeComponent();
		BindingContext = new EmbeddedImagesViewModel();
	}
}