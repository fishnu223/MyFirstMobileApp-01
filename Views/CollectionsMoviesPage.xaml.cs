using MyFirstMobileApp.ViewModels;

namespace MyFirstMobileApp.Views;

public partial class CollectionsMoviesPage : ContentPage
{
    public CollectionsMoviesPage()
    {
        InitializeComponent();
        BindingContext = new CollectionsMoviesViewModel();
    }
}
