using System;
using System.Collections.Generic;
using System.Linq;
using Lab1.album;
using Lab1.artist;
using Lab1.track;

namespace Lab1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var eminem = new Artist("Eminem");
            var ed = new Artist("Ed Sheeran");

            var artists = new HashSet<Artist>();
            var artistsNames = new HashSet<string>();
            artists.Add(eminem);
            artistsNames.Add(eminem.GetName());

            var kamikaze = new Album("Kamikaze", artists);
            var venom = new Track("Venom", "rap", artistsNames, kamikaze.GetName());
            var normal = new Track("Normal", "rap", artistsNames, kamikaze.GetName());
            kamikaze.AddTrack(venom); kamikaze.AddTrack(normal);

            artists.Add(ed);
            artistsNames.Add(ed.GetName());
            var al = new Album("Cool Album", artists);
            var tr1 = new Track("Track1", "pop", artistsNames, al.GetName());
            var tr2 = new Track("Track2", "rap", artistsNames, al.GetName());
            al.AddTrack(tr1); al.AddTrack(tr2);

            var colGenres = new HashSet<string>();
            colGenres.Add("rap");
            colGenres.Add("pop");
            var col = new Collection("Best 10's tracks", colGenres);
            col.AddTrack(venom); col.AddTrack(tr2);

            List<Track> tracks = new List<Track>();
            tracks.Add(venom); tracks.Add(normal); tracks.Add(tr1); tracks.Add(tr2);
            List<Album> albums = new List<Album>();
            albums.Add(kamikaze); albums.Add(al);
            List<Collection> collections = new List<Collection>();
            collections.Add(col);
            var catalog = new Catalog(artists.ToList(), tracks, albums, collections);
            
            while (true) {
                Console.WriteLine("Введите тип поиска: ");
                Console.WriteLine("1 - артист по имени");
                Console.WriteLine("2 - альбом по названию");
                Console.WriteLine("3 - трек по названию");
                Console.WriteLine("4 - треки по жанру");
                Console.WriteLine("5 - коллекции по названию");

                var type = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Введите поисковый запрос: ");
                var search = Console.ReadLine();
                switch (type) {
                    case 1:
                        catalog.SearchArtistByName(search);
                        Console.WriteLine();
                        break;
                    case 2:
                        catalog.SearchAlbumByName(search);
                        Console.WriteLine();
                        break;
                    case 3:
                        catalog.SearchTrackByName(search);
                        Console.WriteLine();
                        break;
                    case 4:
                        catalog.SearchTracksByGenre(search);
                        Console.WriteLine();
                        break;
                    case 5:
                        catalog.SearchCollectionByName(search);
                        Console.WriteLine();
                        break;
                }
                Console.WriteLine("Хотите продолжить? 1 - да; любая другая цифра - нет");
                var cont = Convert.ToInt32(Console.ReadLine());
                if (cont != 1) {
                    break;
                }
            }
        }
    }
}