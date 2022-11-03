using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spotify;

namespace Spotify
{
    internal class SuperUser : Person
    {

        public SuperUser(string user) : base(user)
        {
            
        }

        public void AddFriend(Person person)
        {
            Friends.Add(person);
        }

        public void RemoveFriend(Person person)
        {
            for (int i = 0; i < Friends.Count; i++)
            {
                if (Friends[i] == person)
                {
                    Friends.Remove(Friends[i]);
                    Console.WriteLine("Person has been moved to the trash");
                }
            }
        }

        Playlist CreatePlayList(string name)
        {
            return new Playlist(new Person(Name),name);
        }

        public void RemovePlayList(int num)
        {
            for (int i = 0; i < Playlists.Count; i++)
            {
                if (Playlists[i].Equals(num))
                {
                    Playlists.Remove(Playlists[i]);
                    Console.WriteLine("Playlist has been moved to the trash");
                }
            }
        }

        public void AddToPlayList(iPlayable iPlayable)
        {
            Console.WriteLine("Enter playlist number:");
            for (int i = 0; i < Playlists.Count; i++)
            {
                Console.WriteLine(Playlists[i].Title + "\n");
            }
            int num = Console.Read();
            Playlists[num].Add(iPlayable);
        }

        public void RemoveFromPlaylist(iPlayable iPlayable)
        {
            Console.WriteLine("Enter playlist number:");
            for (int i = 0; i < Playlists.Count; i++)
            {
                Console.WriteLine(Playlists[i].Title + "\n");
            }
            int num = Console.Read();
            Playlists[num].Remove(iPlayable);
        }
    }
}
