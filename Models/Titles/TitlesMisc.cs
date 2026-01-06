namespace MyFirstMobileApp.Models.Titles;

public class TitlesMisc : ContentPage
{
	public TitlesMisc()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}