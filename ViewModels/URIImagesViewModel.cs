using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstMobileApp.Models.Titles;

namespace MyFirstMobileApp.ViewModels
{
    public partial class URIImagesViewModel : ObservableObject
    {

        public string Title => TitleURIImages.URIImagesTitle;

        [ObservableProperty]
        private ImageSource imageSourceUrl;

        public URIImagesViewModel()
        {
            imageSourceUrl = new UriImageSource
            {
                Uri = new Uri(TitleURIImages.ImageURL),
                CachingEnabled = true,
                CacheValidity = TimeSpan.FromDays(1)
            };

        }

    }
}
