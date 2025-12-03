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
        private string titleButtonCollection = TitleCollection.TitleButtonCollection;

        [ObservableProperty]
        private string titleButtonCollectionImage = TitleCollection.TitleButtonCollectionImage;

        [ObservableProperty]
        private string titleButtonCollectionButton = TitleCollection.TitleButtonCollectionButton;

        [ObservableProperty]
        private string titleButtonCollectionIcon = TitleCollection.TitleButtonCollectionIcon;

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
         
    }
}