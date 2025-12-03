using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Windows.Media.AppBroadcasting;
//using Windows.Media.Streaming.Adaptive;

namespace MyFirstMobileApp.Models.Entities
{
    public class MarvelMoviesImages
    {

        public string NameOfActor { get; set; }

        public string NameOfCharacter { get; set; }

        public ImageSource ImageSource { get; set; }

        public MarvelMoviesImages()
        {

        }

        public MarvelMoviesImages(string actorName, string charName, ImageSource imgSrc)
        {
            NameOfActor = actorName;
            NameOfCharacter = charName;
            ImageSource = imgSrc;
        }

        public static List<MarvelMoviesImages> GetMoviesCast()
        {
            return new List<MarvelMoviesImages>
            {
                new MarvelMoviesImages("Chris Pratt", "Starlord", "starlord.jpg"),
                new MarvelMoviesImages("Zoe Saldana", "Gamora", "gamora.jpg"),
                new MarvelMoviesImages("Vin Diesel", "groot", "groot.jpg"),
                new MarvelMoviesImages("Bradey Cooper", "Rocket", "rocket.jpg"),
                new MarvelMoviesImages("Karen Gillan", "Nebula", "nebula.jpg")
            };
        }

    }
}