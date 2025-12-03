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
    public partial class CollectionsMoviesImagesViewModel : ObservableObject
    {
        private List<MarvelMoviesImages> _marvelmovies;

        public string title => TitleCollectionMoviesImages.TitleMarvelMoviesCollection;

        public ObservableCollection<MarvelMoviesImages> MarvelMoviesCollection { get; } = new();

        public CollectionsMoviesImagesViewModel()
        {
            _marvelmovies = MarvelMoviesImages.GetMoviesCast();
            LoadMovies();
        }

        private void LoadMovies()
        {
            try
            {
                MarvelMoviesCollection.Clear();
                foreach (var p in _marvelmovies)
                {
                    MarvelMoviesCollection.Add(new MarvelMoviesImages
                    {
                        NameOfActor = p.NameOfActor,
                        NameOfCharacter = p.NameOfCharacter,
                        ImageSource = p.ImageSource
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

