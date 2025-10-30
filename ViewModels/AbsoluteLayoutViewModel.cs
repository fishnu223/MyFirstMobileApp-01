using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMobileApp.Models.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewModels
{
    public partial class AbsoluteLayoutViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = TitleAbsoluteLayout.Title;

        public AbsoluteLayoutViewModel()
        {

        }
    }
}
