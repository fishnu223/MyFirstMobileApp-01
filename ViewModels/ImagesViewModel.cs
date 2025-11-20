using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstMobileApp.Models.Titles;

namespace MyFirstMobileApp.ViewModels
{
    public partial class ImagesViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = TitleImages.Title;

        [ObservableProperty]
        private string titleButtonURIImages = TitleImages.TitleButtonURIImages;

        [ObservableProperty]
        private string titleButtonEmbeddedImages = TitleImages.TitleButtonEmbeddedImages;

        [ObservableProperty]
        private string titleButtonActivityIndicator = TitleImages.TitleButtonActivityIndicator;

        public ImagesViewModel()
        {

        }

        [RelayCommand]
        private async Task URIImagesClicked()
        {
            await Shell.Current.GoToAsync(nameof(Views.URIImagesPage));
        }

        [RelayCommand]
        private async Task EmbeddedImagesClicked()
        {
            await Shell.Current.GoToAsync(nameof(Views.EmbeddedImagesPage));
        }

        [RelayCommand]
        private async Task ActivityIndicatorClicked()
        {
            await Shell.Current.GoToAsync(nameof(Views.ActivityIndicatorPage));
        }
    }
}
