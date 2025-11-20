namespace MyFirstMobileApp.Views;
using MyFirstMobileApp.ViewModels;
public partial class CollectionsMoviesPage : ContentPage
{
    public CollectionsMoviesPage()
    {
        InitializeComponent();
        BindingContext = new CollectionsMoviesViewModel();
    }
}