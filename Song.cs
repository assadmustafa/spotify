using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Song
    {
        public string Title;
        public List<Artist> Artists;
        public Genre SongGenre;
        private int Length;

        public Song(string title, List<Artist> artists, int length, Genre genre)
        {
            
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
