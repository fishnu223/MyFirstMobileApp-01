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
    public partial class ControlsEntryViewModel : ObservableObject
    {
        public string Title => TitleControls.EntryMenuTitle;
        public string EntryXAML => TitleControls.EntryXAMLTitle;
        public string EntryVM => TitleControls.EntryVMTitle;

        [RelayCommand]
        private async Task EntryXAMLClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsEntryXAMLPage));
        }

        [RelayCommand]
        private async Task EntryVMClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsEntryVMPage));
        }

    }
}
