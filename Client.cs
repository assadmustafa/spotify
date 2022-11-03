using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Client
    {
        public iPlayable CurrentlyPlaying;
        public int CurrentTime;
        public bool Playing;
        public bool Shuffle = false;
        public bool Repeat = false;
        protected SuperUser ActiveUser;
        protected List<Album> AllAlbums;
        protected List<Song> AllSongs;
        protected List<Person> AllUsers;

        // Constructor
        public Client(List<Person> users, List<Album> albums,List<Song> songs)
        {
            this.AllUsers = users;
            this.AllAlbums = albums;
            this.AllSongs = songs;
        }

        public void SetActiveUser(Person person)
        {
            this.ActiveUser = (SuperUser)person;
        }

        // Toont alle bestaande albums binnen de client
        public void ShowAllAlbums()
        {
            foreach (Album album in this.AllAlbums)
            {
                Console.WriteLine(album.Title);
            }
        }

        // Selecteer een bestaand album binnen de client
        public void SelectAlbum(int num)
        {
            AllAlbums.ElementAt(num);
        }

        // Toont alle bestaand nummers binnen de client
        public void ShowAllSongs()
        {
            foreach (Song song in this.AllSongs)
            {
                Console.WriteLine(song.Title);
            }
        }

        // Selecteer een bestaand nummer binnen de client
        public void SelectSong(int num)
        {
            AllSongs.ElementAt(num);
        }

        // Toont alle bestaande gebruikers binnen de client
        public void ShowAllUsers()
        {
            foreach (Person person in this.AllUsers)
            {
                Console.WriteLine(person.Name);
            }
        }

        // Selecteer een bestaande gebruiker binnen de client
        public void SelectUser(int num)
        {
            AllUsers.ElementAt(num);
        }

        // Toon alle bestaande afspeellijsten van een gebruiker binnen de client
        public void ShowUserPlaylists()
        {
            this.ShowPlaylists();
        }

        // Selecteer een bestaande afspeellijst van een beschikbare gebruiker binnen de client
        public void SelectUserPlaylist(int num)
        {
            Console.WriteLine("Enter user id:");
            int v1 = Console.Read();
            Person selectedUser = AllUsers.ElementAt(v1);
            selectedUser.SelectPlayList(num);
        }

        // Speel de huidig geselecteerde iPlayable af
        public void Play()
        {
            CurrentlyPlaying.Play();
        }

        // Pauzeer de huidig geselecteerde iPlayable
        public void Pause()
        {
            CurrentlyPlaying.Pause();
        }

        // Stop de huidige geselecteerde iPlayable
        public void Stop()
        {
            CurrentlyPlaying.Stop();
        }

        // Doorgaan naar het volgende beschikbare nummer. Eén enkele nummer wordt opnieuw afgespeeld
        public void Next()
        {
            CurrentlyPlaying.Next();
        }

        // Zet shuffle aan/uit
        public void SetShuffle()
        {
            Shuffle = true;
        }

        // Zet repeat aan/uit
        public void SetRepeat()
        {
            Repeat = true;
        }

        // Actieve gebruiker maakt een nieuwe afspeellijst aan
        public void CreatePlaylist(string name)
        {
            Playlist playlist = new Playlist(ActiveUser, name);
        }

        // Toon alle bestaande afspeellijsten van de actieve gebruiker
        public void ShowPlaylists()
        {
            
        }

        // Selecteer een bestaande afspeellijst van de actieve gebruiker
        public void SelectPlaylist(int num)
        {
            ActiveUser.SelectPlayList(num);
        }

        // Verwijder een bestaande afspeellijst van de actieve gebruiker
        public void RemovePlaylist(int num)
        {
            ActiveUser.RemovePlayList(num);
        }

        // Toon alle bestaande nummers binnen de huidig geselecteerde afspeellijst
        public void ShowSongsInPlaylist()
        {
            Console.WriteLine("Enter user id:");
            int v1 = Console.Read();
            Person selectedUser = AllUsers.ElementAt(v1);
            Playlist selectedPlaylist = selectedUser.Playlist;

            selectedPlaylist.ShowPlayables();
        }

        // Voeg een nieuwe iPlayable toe aan de huidig geselecteerde afspeellijst
        public void AddToPlaylist(int num)
        {
            Console.WriteLine("Enter user id:");
            int v1 = Console.Read();
            Person selectedUser = AllUsers.ElementAt(v1);
            Playlist selectedPlaylist = selectedUser.Playlist;

            iPlayable p = AllSongs.ElementAt(num);
            selectedPlaylist.Add(p);
        }

        // Verwijder een nummer van de huidig geselecteerde afspeellijst
        public void RemoveFromPlaylist(int num)
        {
            Console.WriteLine("Enter user id:");
            int v1 = Console.Read();
            Person selectedUser = AllUsers.ElementAt(v1);
            Playlist selectedPlaylist = selectedUser.Playlist;

            iPlayable p = AllSongs.ElementAt(num);
            selectedPlaylist.Remove(p);
        }

        // Toon alle vrienden van de actieve gebruiker
        public void ShowFriends()
        {
            ActiveUser.ShowFriends();
        }

        // Selecteer een gebruiker uit de vriendenlijst van de actieve gebruiker
        public void SelectFriend()
        {
            
        }

        // Voeg een bestaande gebruiker toe aan de vriendenlijst van de actieve gebruiker
        public void AddFriends(int num)
        {
            Person selectedUser = AllUsers.ElementAt(num);
            ActiveUser.AddFriend(selectedUser);
        }

        // Verwijder een gebruiker van de vriendenlijst van de actieve gebruiker
        public void RemoveFriend(int num)
        {
            Person selectedUser = AllUsers.ElementAt(num);
            ActiveUser.RemoveFriend(selectedUser);
        }


    }
}
