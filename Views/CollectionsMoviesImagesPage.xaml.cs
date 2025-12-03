using MyFirstMobileApp.ViewModels;

namespace MyFirstMobileApp.Views;

public partial class CollectionsMoviesImagesPage : ContentPage
{
    public CollectionsMoviesImagesPage()
    {
        InitializeComponent();
        BindingContext = new CollectionsMoviesImagesViewModel();
    }
}
