using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{

    internal class Song : iPlayable
    {
        public string Title;
        public Album Album;
        public List<Artist> Artists;
        public Genre SongGenre;
        protected int Length;

        public Song(string title, List<Artist> artists, Album album ,int length, int genre)
        {
            this.Title = title;
            this.Artists = artists;
            this.Length = length;
            this.SongGenre = (Genre)genre;
            this.Album = album;
        }

        

        int iPlayable.Length => throw new NotImplementedException();

        public void Play(iPlayable playable)
        {
            Console.WriteLine(playable);
        }

        public override string ToString()
        {
            List<string> artistsStringList = new List<string>();
            foreach (Artist artist in this.Artists)
            {
                artistsStringList.Add(artist.Naam);
            }

            string splitArtistNames = string.Join(" - ", artistsStringList);

            return "Title: " + this.Title + "\n" + 
                "Artist: " + splitArtistNames + "\n" + 
                "Album: " + this.Album.Title + "\n" +
                "Genre: " + this.SongGenre + "\n" +
                "Length: " + this.Length + "\n\n";
        }
    }
}