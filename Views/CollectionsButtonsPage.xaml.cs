using MyFirstMobileApp.ViewModels;
namespace MyFirstMobileApp.Views;

public partial class CollectionsButtonsPage : ContentPage
{
	public CollectionsButtonsPage(UpdateableCollectionViewModel vm)
	{
        InitializeComponent();
        BindingContext = vm;

    }
}