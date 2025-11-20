using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstMobileApp.Models.Titles;

namespace MyFirstMobileApp.ViewModels
{
    public partial class EmbeddedImagesViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = TitleEmbeddedImages.Title;

        public ImageSource ImageSource => "jon.jpg";

    }
}
