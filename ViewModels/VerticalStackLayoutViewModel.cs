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
   public partial class VerticalStackLayoutViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = TitleVerticalStackLayout.Title;

        public VerticalStackLayoutViewModel()
        {

        }
    }
}
