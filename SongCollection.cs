using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class SongCollection
    {
        public string Title;
        protected List<iPlayable> playables;

        // Constructor method
        public SongCollection(string name)
        {
            this.Title = name;
            this.playables = new List<iPlayable>();
        }


        public List<iPlayable> ShowPlayables()
        {
            foreach (iPlayable playable in this.playables)
            {
                Console.WriteLine(playable);
            }
            return this.playables;
        }

        public void Play()
        {
            foreach (iPlayable playable in this.playables)
            {
                playable.Play();
            }
        }

        public override string ToString()
        {
            return this.Title + ":";
        }
    }
}
