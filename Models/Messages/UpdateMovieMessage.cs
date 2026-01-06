using CommunityToolkit.Mvvm.Messaging.Messages;
using MyFirstMobileApp.Models.Entities;

namespace MyFirstMobileApp.Models.Messages { 

    public class UpdateMovieMessage : ValueChangedMessage<(MarvelMovies OldValue, MarvelMovies NewValue)>
    {
        public UpdateMovieMessage(MarvelMovies oldValue, MarvelMovies newValue)
            : base((oldValue, newValue)) { }

        public MarvelMovies OldValue => Value.OldValue;

        public MarvelMovies NewValue => Value.NewValue;

    }

}
