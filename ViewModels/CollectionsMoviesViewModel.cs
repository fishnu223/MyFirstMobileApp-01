using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Titles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewModels
{
    public partial class CollectionsMoviesViewModel : ObservableObject
    {
        private List<MarvelMovies> _marvelmovies;

        public string Title => TitleMarvelMoviesCollection.MarvelMoviesTitle;

        public ObservableCollection<MarvelMovies> MarvelMoviesCollection { get; } = new();

        public CollectionsMoviesViewModel()
        {
            _marvelmovies = MarvelMovies.GetMovies();
            LoadMovies();
        }

        private void LoadMovies()
        {
            try
            {
                MarvelMoviesCollection.Clear();
                foreach (var p in _marvelmovies)
                {
                    MarvelMoviesCollection.Add(new MarvelMovies
                    {
                        NameOfMovie = p.NameOfMovie,
                    });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}

