using MyFirstMobileApp.ViewModels;

namespace MyFirstMobileApp.Views;

public partial class CollectionsPage : ContentPage
{
    public CollectionsPage()
    {
        InitializeComponent();
        BindingContext = new CollectionsViewModel();
    }
}
