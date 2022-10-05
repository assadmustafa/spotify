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
        private List<Album> Albums;
        private List<Song> Songs;

        /// Methods ///
        public Artist(string name, List<Album> Albums)
        {

        }

        public void AddSong(Song song)
        {

        }

        public void AddAlbum(Album album)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
