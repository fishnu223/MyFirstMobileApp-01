using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMobileApp.Models.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewModels
{
    public partial class CollectionsViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = TitleCollection.Title;

        [ObservableProperty]
        private string titleButtonCollection = TitleCollection.TitleButtonCollection;

        [ObservableProperty]
        private string titleButtonCollectionImage = TitleCollection.TitleButtonCollectionImage;

        [ObservableProperty]
        private string titleButtonIconCollection = TitleCollection.TitleButtonIconCollection;

        [ObservableProperty]
        private string titleButtonCollectionButton = TitleCollection.TitleButtonCollectionButton;


        


        public CollectionsViewModel()
        {

        }

        [RelayCommand]
        private async Task CollectionsMoviesClicked()
        {
            await Shell.Current.GoToAsync(nameof(Views.CollectionsMoviesPage));
        }

        [RelayCommand]
        private async Task CollectionsMoviesImagesClicked()
        {
            await Shell.Current.GoToAsync(nameof(Views.CollectionsMoviesImagesPage));
        }
        [RelayCommand]
        private async Task IconsClicked()
        {
            await Shell.Current.GoToAsync(nameof(Views.CollectionsIconsPage));
        }


    }
}