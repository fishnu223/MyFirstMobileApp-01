namespace MyFirstMobileApp.Views;
using MyFirstMobileApp.ViewModels;

public partial class CollectionsIconsPage : ContentPage
{
	public CollectionsIconsPage(UpdateableCollectionViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }
}