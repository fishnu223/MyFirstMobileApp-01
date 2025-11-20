using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.Models.Entities
{
    public class MarvelMovies
    {

        public string NameOfMovie { get; set; }

        public MarvelMovies()
        {

        }

        public MarvelMovies(string name)
        {
            NameOfMovie = name;
        }

        public static List<MarvelMovies> GetMovies()
        {
            return new List<MarvelMovies>
            {
                new MarvelMovies("Guardians of the Galaxy"),
                new MarvelMovies("Spiderman"),
                new MarvelMovies("Iron Man"),
                new MarvelMovies("Batman"),
                new MarvelMovies("Aquaman"),
                new MarvelMovies("Superman"),
                new MarvelMovies("Wonder Woman")
            };
        }

    }
}
