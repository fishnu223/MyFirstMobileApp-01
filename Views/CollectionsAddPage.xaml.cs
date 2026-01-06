namespace MyFirstMobileApp.Views;
using MyFirstMobileApp.ViewModels;
public partial class CollectionsAddPage : ContentPage
{
	public CollectionsAddPage()
	{
		InitializeComponent();
		BindingContext = new CollectionAddViewModel();
    }
}