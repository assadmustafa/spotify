using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Artist
    {
        /// Properties ///
        public string Naam;
        public List<Album> Albums;
        protected List<Song> Songs;

        /// Methods ///
        public Artist(string name, List<Album> albums)
        {
            this.Naam = name;
            this.Albums = albums;
        }

        public void AddSong(Song song)
        {
            this.Songs.Add(song);
        }

        public void AddAlbum(Album album)
        {
            this.Albums.Add(album);
        }
        public override string ToString()
        {
            return this.Naam;
        }

    }
}
