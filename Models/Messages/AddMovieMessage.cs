using CommunityToolkit.Mvvm.Messaging.Messages;
using MyFirstMobileApp.Models.Entities;

namespace MyFirstMobileApp.Models.Messages {

    public class AddMovieMessage : ValueChangedMessage<MarvelMovies>
    {
        public AddMovieMessage(MarvelMovies value) : base(value) { }
    }

}
