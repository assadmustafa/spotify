using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Playlist : SongCollection
    {
        public Person Owner;

        public Playlist(Person person,string name)
        {
            
        }

        public void Add(iPlayable iPlayable)
        {

        }

        public void Remove(iPlayable iPlayable)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
