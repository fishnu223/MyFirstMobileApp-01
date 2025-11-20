namespace MyFirstMobileApp.Views;
using MyFirstMobileApp.ViewModels;
public partial class CollectionsMoviesImagesPage : ContentPage
{
	public CollectionsMoviesImagesPage()
	{
		InitializeComponent();
		BindingContext = new CollectionsMoviesImagesViewModel();
	}
}