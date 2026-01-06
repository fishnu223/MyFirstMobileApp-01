using MyFirstMobileApp.ViewModels;

namespace MyFirstMobileApp.Views;

public partial class UpdateableCollectionWButtonsPage : ContentPage
{
    public UpdateableCollectionWButtonsPage(UpdateableCollectionViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}