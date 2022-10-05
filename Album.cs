using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Album : SongCollection
    {
        private List<Artist> Artists;

        public Album(List<Artist> artists, string name, List<Song> songs)
        {

        }

        public List<Artist> ShowArtists() 
        { 
            return Artists;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
