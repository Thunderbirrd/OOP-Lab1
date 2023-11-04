using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Lab1.album;
using Lab1.artist;
using Lab1.track;

namespace Lab1
{
    public class Catalog
    {
        public readonly List<Artist> Artists;
        public List<Track> Tracks;
        public readonly List<Album> Albums;
        public readonly List<Collection> Collections;

        public Catalog(List<Artist> artists, List<Track> tracks, List<Album> albums, List<Collection> collections)
        {
            Artists = artists;
            Tracks = tracks;
            Albums = albums;
            Collections = collections;
        }

        public void SearchArtistByName(string name)
        {
            foreach (var artist in Artists)
            {
                if (artist.GetName().Equals(name))
                {
                    Console.WriteLine($"Artist name:  {name}");
                    Console.WriteLine("Albums list: ");
                    _searchArtistAlbums(name);
                    return;
                }
                Console.WriteLine("No such artist");
            }
        }

        private void _searchArtistAlbums(string artistName)
        {
            foreach (var album in from album in Albums from artist in album.GetArtists().Where(artist => artist.GetName().Equals(artistName)) select album)
            {
                Console.WriteLine($"Album: {album.GetName()}");
            }
        }

        public void SearchAlbumByName(string name)
        {
            foreach (var album in Albums.Where(album => album.GetName().Equals(name)))
            {
                Console.WriteLine($"Album: {name}");
                Console.Write("Artists: "); album.PrintArtistsString();
                album.GetTrackList();
                return;
            }
            Console.WriteLine("Album not found");
        }
        
        public void SearchCollectionByName(string name)
        {
            foreach (var col in Collections.Where(col => col.GetName().Equals(name)))
            {
                Console.WriteLine($"Collection: {name}");
                Console.WriteLine($"Genres: {col.GetGenres()}");
                Console.WriteLine();
                col.GetTrackList();
                return;
            }
            Console.WriteLine("Collection not found");
        }
        
        public void SearchTrackByName(string name)
        {
            foreach (var tr in Tracks.Where(tr => tr.GetName().Equals(name)))
            {
                Console.WriteLine($"Name: {name}");
                Console.Write("Artists: ");
                tr.PrintArtists();
                Console.WriteLine($"Album: {tr.GetAlbum()}");
                Console.WriteLine($"Genre: {tr.GetGenre()}");
                return;
            }
            Console.WriteLine("Track not found");
        }
        
        public void SearchTracksByGenre(string name)
        {
            foreach (var tr in Tracks.Where(tr => tr.GetGenre().Equals(name)))
            {
                Console.WriteLine($"Name: {name}");
                Console.Write("Artists: ");
                tr.PrintArtists();
                Console.WriteLine($"Album: {tr.GetAlbum()}");
                Console.WriteLine($"Genre: {tr.GetGenre()}");
                return;
            }
        }
    }
}