using System;
using System.Collections;
using System.Collections.Generic;
using Lab1.track;

namespace Lab1.album
{
    public class TrackCompilation
    {
        private string _name;
        private readonly HashSet<Track> _tracks;

        public TrackCompilation(string name)
        {
            _name = name;
            _tracks = new HashSet<Track>();
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void AddTrack(Track track)
        {
            _tracks.Add(track);
        }

        public void GetTrackList()
        {
            foreach (var track in _tracks)
            {
                Console.WriteLine($"Name: {track.GetName()}");
                track.PrintArtists();
                Console.WriteLine($"Genre: {track.GetGenre()}");
                Console.WriteLine();
            }
        }
    }
}