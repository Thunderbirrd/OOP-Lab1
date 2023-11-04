using System;
using System.Collections.Generic;
using Lab1.album;
using Lab1.artist;

namespace Lab1.track
{
    public class Track
    {
        private readonly string _name;
        private readonly string _genre;
        private readonly HashSet<string> _artists;
        private readonly string _album;

        public Track(string name, string genre, HashSet<string> artists, string album)
        {
            _name = name;
            _genre = genre;
            _artists = artists;
            _album = album;
        }

        public string GetName()
        {
            return _name;
        }
        
        public string GetAlbum()
        {
            return _album;
        }
        
        public string GetGenre()
        {
            return _genre;
        }

        public void PrintArtists()
        {
            foreach (var artist in _artists)
            {
                Console.Write(artist);
                Console.Write("; ");
            }
            Console.WriteLine();
        }
    }
}