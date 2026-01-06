namespace MyFirstMobileApp.Views;
using MyFirstMobileApp.ViewModels;

public partial class CollectionsEditPage : ContentPage
{
	public CollectionsEditPage()
	{
		InitializeComponent();
		BindingContext = new CollectionEditViewModel();
    }


    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.TryGetValue("movieName", out var raw) && BindingContext is CollectionEditViewModel vm)
        {
            vm.MovieName = Uri.UnescapeDataString(raw as string ?? string.Empty);
        }
    }
}