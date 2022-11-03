using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Album : SongCollection
    {
        protected List<Artist> Artists;

        public bool Correct { get; internal set; }


        public Album(List<Artist> artists, string name, List<Song> songs): base(name)
        {
            this.Artists = artists;


            foreach(iPlayable iPlayable in playables)
            {
                songs.Add((Song)iPlayable);
            }
        }

        public List<Artist> ShowArtists() 
        {
            foreach (Artist artist in this.Artists)
            {
                Console.WriteLine(artist.Naam);
            }

            return this.Artists;
        }

        public override string ToString()
        {
            return this.Title;
        }

    }
}
