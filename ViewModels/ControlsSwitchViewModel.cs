using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewModels
{
    public partial class ControlsSwitchViewModel : ObservableObject
    {
        public string Title => TitleControls.SwitchMenuTitle;
        public string SwitchXAML => TitleControls.SwitchXAML;
        public string SwitchVM => TitleControls.SwitchVM;

        [RelayCommand]
        private async Task SwitchXAMLClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsSwitchXAMLPage));
        }

        [RelayCommand]
        private async Task SwitchVMClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsSwitchVMPage));
        }
    }
}
