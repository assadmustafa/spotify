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
        private List<iPlayable> playables;
        // Constructor method
        public SongCollection(string name)
        {

        }

        // CAUTION: Not sure about that
        public SongCollection()
        {

        }

        public List<iPlayable> ShowPlayables()
        {
            return playables;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
