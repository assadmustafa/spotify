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

        public Playlist(Person person,string name) : base(name)
        {
            this.Owner = person;
            this.Owner.Name = name;
        }

        public void Add(iPlayable iPlayable)
        {
            playables.Add(iPlayable);
        }

        public void Remove(iPlayable iPlayable)
        {
            playables.Remove(iPlayable);
        }

        public override string ToString()
        {
            return this.Owner.Name;
        }
    }
}
