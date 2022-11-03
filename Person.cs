using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spotify;

namespace Spotify
{
    internal class Person
    {
        public string Name;
        protected List<Person> Friends;
        protected List<Playlist> Playlists;

        public Person(string user)
        {
            this.Name = user;
            this.Friends = new List<Person>();
            this.Playlists = new List<Playlist>();
        }

        internal Playlist Playlist
        {
            get => default;
            set
            {
            }
        }

        public List<Person> ShowFriends()
        {
            Console.WriteLine(Name + " Friends:");
            foreach (Person person in Friends)
            {
                Console.WriteLine("- " + person.Name + "\n");
            }
            return Friends;
        }

        public void ShowPlayLists(List<Playlist> playlists)
        {
            this.Playlists = playlists;
            Console.WriteLine(playlists);
        }

        public void SelectPlayList(int num)
        {
            string selectedPlaylist = this.Playlists[num].Title;
            Console.WriteLine(selectedPlaylist);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
