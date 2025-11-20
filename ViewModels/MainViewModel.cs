using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstMobileApp.Models.Titles;
using System.Windows.Input;
using MyFirstMobileApp.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MyFirstMobileApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = TitleMain.Title;

        [ObservableProperty]
        private string titleButtonLayouts = TitleMain.TitleButtonLayouts;

        [ObservableProperty]
        private string titleButtonImages = TitleMain.TitleButtonImages;

        [ObservableProperty]
        private string titleButtonCollections = TitleMain.TitleButtonCollections;

        [ObservableProperty]
        private string titleButtonControls = TitleMain.TitleButtonControls;

        [ObservableProperty]
        private string titleButtonSQLLite = TitleMain.TitleButtonSQLLite;
        public MainViewModel()
        {
            
            
        }

        [RelayCommand]
        private async Task LayoutsClicked()
        {
            await Shell.Current.GoToAsync(nameof(LayoutsPage));
        }

        [RelayCommand]
        public async Task ImagesClicked()
        {
            await Shell.Current.GoToAsync(nameof(ImagesPage));
        }
    }
}
