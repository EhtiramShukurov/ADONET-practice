using SpotifyProject.Models;
using SpotifyProject.Services;
using System.Data.SqlClient;

namespace SpotifyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //MUSICS
            //MusicService musicService = new MusicService();
            //Music music = new Music { Name = "Karma", Duration = new TimeSpan(00,03,29), CategoryId = 2 };
            //musicService.Add(music);
            //foreach (Music m in musicService.GetAll()) 
            //{
            //    Console.WriteLine(m);
            //}
            //Console.WriteLine(musicService.GetById(2));
            //Music music2 = musicService.GetById(2);
            //music2.Name = "asdfghj";
            //musicService.Update(music2);
            //musicService.DeleteById(5);


            //ARTISTS
            ArtistService artistService = new ArtistService();

            //Artist artist = new Artist { Name = "Selena", Surname = "Gomez", Birthday = new DateTime(1992, 7, 22),Gender = "fm" };
            //artistService.Add(artist);
            //foreach (Artist a in artistService.GetAll())
            //{
            //    Console.WriteLine(a);
            //}
            //Console.WriteLine(artistService.GetById(2));
            //Artist artist2 = artistService.GetById(2);
            //artist2.Surname = "Asdffgh";
            //artistService.Update(artist2);
            //artistService.DeleteById(9);
        }
    }
}