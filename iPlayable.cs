using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal interface iPlayable
    {
        public void Play() { }
        public void Pause() { }
        public void Next() { }
        public void Stop() { }
        public int Length() { return 0; }

    }
}
