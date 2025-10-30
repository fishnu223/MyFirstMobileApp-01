using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.Views;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyFirstMobileApp.ViewModels
{
    public partial class LayoutsViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = TitleLayouts.Title;

        [ObservableProperty]
        private string titleButtonStackLayout = TitleLayouts.TitleButtonStackLayout;

        [ObservableProperty]
        private string titleButtonVerticalStack = TitleLayouts.TitleButtonVerticalStack;

        [ObservableProperty]
        private string titleButtonHorizontalStack = TitleLayouts.TitleButtonHorizontalStack;

        [ObservableProperty]
        private string titleButtonAbsoluteLayout = TitleLayouts.TitleButtonAbsoluteLayout;

        [ObservableProperty]
        private string titleButtonFlexLayout = TitleLayouts.TitleButtonFlexLayout;
        public LayoutsViewModel()
        {
          
        }

        [RelayCommand]
        private async Task StackLayoutClicked()
        {
            await Shell.Current.GoToAsync(nameof(StackLayoutPage));
        }

        [RelayCommand]
        private async Task VerticalStackClicked()
        {
            await Shell.Current.GoToAsync(nameof(VerticalStackLayoutPage));
        }
        [RelayCommand]
        private async Task HorizontalStackClicked()
        {
            await Shell.Current.GoToAsync(nameof(HorizontalStackLayoutPage));
        }
        [RelayCommand]
        private async Task AbsoluteLayoutClicked()
        {
            await Shell.Current.GoToAsync(nameof(AbsoluteStackLayoutPage));
        }
        [RelayCommand]
        private async Task FlexLayoutClicked()
        {
            await Shell.Current.GoToAsync(nameof(FlexLayoutPage));
        }
        
    }
}
