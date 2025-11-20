using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstMobileApp.Models.Titles;

namespace MyFirstMobileApp.ViewModels
{
    public partial class ActivityIndicatorViewModel : ObservableObject
    {
        public string title = TitleActivityIndicator.Title;

        [ObservableProperty]
        private bool isLoading = true;

        [ObservableProperty]
        private bool isImageVisible = true;

        [ObservableProperty]
        private ImageSource loadedImage;

        public ActivityIndicatorViewModel()
        {
            _ = LoadImageAsync();
        }

        private async Task LoadImageAsync()
        {
            try
            {
                using var client = new HttpClient();
                var response = await client.GetAsync(TitleURIImages.ImageURL);

                if (response.IsSuccessStatusCode)
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    LoadedImage = ImageSource.FromStream(() => stream);
                    IsImageVisible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading imageL {ex.Message}");
            }
            finally
            {
                IsLoading = false;
            }

        }
    }
}
