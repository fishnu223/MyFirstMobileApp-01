//using Android.Database;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Messages;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;

namespace MyFirstMobileApp.ViewModels;

public partial class CollectionAddViewModel : ObservableObject
{
    [ObservableProperty]
    private string title = TitleMisc.AddTitle;

    [ObservableProperty]
    private string movieName = string.Empty;


    [RelayCommand]
    private async Task SaveBtnClicked()
    {
        if (string.IsNullOrWhiteSpace(movieName))
        {
            await Shell.Current.DisplayAlert(
                title,
                Msgs.NotEmpty,
                "Ok");
            return;
        }

        var movie = new MarvelMovies { NameofMovie = movieName };

        WeakReferenceMessenger.Default.Send(new AddMovieMessage(movie));

        await Shell.Current.GoToAsync("..");
    }
}