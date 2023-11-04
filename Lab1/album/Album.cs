using System;
using System.Collections.Generic;
using Lab1.artist;

namespace Lab1.album
{
    public class Album : TrackCompilation
    {
        private readonly HashSet<Artist> _artists;

        public Album(string name, HashSet<Artist> artists) : base(name)
        {
            _artists = artists;
        }
        
        public HashSet<Artist> GetArtists()
        {
            return _artists;
        }

        public void PrintArtistsString()
        {
            foreach (var artist in _artists)
            {
                Console.Write(artist.GetName());
                Console.Write("; ");
            }
            Console.WriteLine();
        }
    }
}