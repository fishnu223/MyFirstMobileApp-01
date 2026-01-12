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
    public partial class ControlsStepperViewModel : ObservableObject
    {
        public string Title => TitleControlsStepper.Title;
        public string StepperXAML => TitleControlsStepper.StepperXAML;
        public string StepperVM => TitleControlsStepper.StepperVM;

        [RelayCommand]
        private async Task StepperXAMLClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsStepperXAMLPage));
        }

        [RelayCommand]
        private async Task StepperVMClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsStepperVMPage));
        }
    }
}
