using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.Views;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel; 
using CommunityToolkit.Mvvm.Input;

namespace MyFirstMobileApp.ViewModels
{
    public partial class StackLayoutViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = TitleStackLayout.Title;

        public StackLayoutViewModel()
        {

        }
    }
}
