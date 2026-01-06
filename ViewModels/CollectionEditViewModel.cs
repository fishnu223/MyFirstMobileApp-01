using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Messages;

namespace MyFirstMobileApp.ViewModels;

[QueryProperty(nameof(MovieName), "movieName")]
public partial class CollectionEditViewModel : ObservableObject
{
	private string _originalMovieName;

	public string Title => "Edit Movie";

	[ObservableProperty]
	private string movieName;

	partial void OnMovieNameChanged(string value)
	{
		if (_originalMovieName is null)
		{
			_originalMovieName = value;
		}
	}

	[RelayCommand]
	private async Task UpdateClicked()
	{
		if (string.IsNullOrWhiteSpace(movieName))
		{
			await Shell.Current.DisplayAlert(Title, Msgs.NotEmptyMovie, "OK");
			return;
		}

		var oldMovie = new MarvelMovies(_originalMovieName);
		var newMovie = new MarvelMovies(movieName);

		WeakReferenceMessenger.Default.Send(new UpdateMovieMessage(oldMovie, newMovie));
		await Shell.Current.GoToAsync("..");
	}
}