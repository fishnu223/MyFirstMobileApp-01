using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.Views;
using MyFirstMobileApp.Models.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewModels
{
    public partial class ControlsSliderViewModel : ObservableObject
    {
        public string Title => TitleControls.SliderMenuTitle;
        public string SliderXAML => TitleControls.SliderXAML;
        public string SliderVM => TitleControls.SliderVM;

        [RelayCommand]
        private async Task SliderXAMLClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsSliderXAMLPage));
        }

        [RelayCommand]
        private async Task SliderVMClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsSliderVMPage));
        }

    }
}