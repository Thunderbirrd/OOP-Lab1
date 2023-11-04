using System.Collections.Generic;

namespace Lab1.album
{
    public class Collection : TrackCompilation
    {
        private readonly HashSet<string> _genres;
        public Collection(string name, HashSet<string> genres) : base(name)
        {
            _genres = genres;
        }

        public HashSet<string> GetGenres()
        {
            return _genres;
        }
    }
}