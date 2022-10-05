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
        public bool Shuffle;
        public bool Repeat;
        private SuperUser ActiveUser;
        private List<Album> AllAlbums;
        private List<Song> AllSongs;
        private List<Person> AllUsers;

        // Constructor
        public Client(List<Person> users, List<Album> albums,List<Song> songs)
        {

        }

        public static void SetActiveUser(Person person)
        {

        }

        // Toont alle bestaande albums binnen de client
        public void ShowAllAlbums()
        {

        }

        // Selecteer een bestaand album binnen de client
        public void SelectAlbum(int num)
        {

        }

        // Toont alle bestaand nummers binnen de client
        public void ShowAllSongs()
        {

        }

        // Selecteer een bestaand nummer binnen de client
        public void SelectSong(int num)
        {

        }

        // Toont alle bestaande gebruikers binnen de client
        public void ShowAllUsers()
        {

        }

        // Selecteer een bestaande gebruiker binnen de client
        public void SelectUser(int num)
        {

        }

        // Toon alle bestaande afspeellijsten van een gebruiker binnen de client
        public void ShowUserPlaylists()
        {

        }

        // Selecteer een bestaande afspeellijst van een beschikbare gebruiker binnen de client
        public void SelectUserPlaylist(int num)
        {

        }

        // Speel de huidig geselecteerde iPlayable af
        public void Play()
        {

        }

        // Pauzeer de huidig geselecteerde iPlayable
        public void Pause()
        {

        }

        // Stop de huidige geselecteerde iPlayable
        public void Stop()
        {

        }

        // Doorgaan naar het volgende beschikbare nummer. Eén enkele nummer wordt opnieuw afgespeeld
        public void Next()
        {

        }

        // Zet shuffle aan/uit
        public void SetShuffle()
        {

        }

        // Zet repeat aan/uit
        public void SetRepeat()
        {

        }

        // Actieve gebruiker maakt een nieuwe afspeellijst aan
        public void CreatePlaylist(string name)
        {

        }

        // Toon alle bestaande afspeellijsten van de actieve gebruiker
        public void ShowPlaylists()
        {

        }

        // Selecteer een bestaande afspeellijst van de actieve gebruiker
        public void SelectPlaylist(int num)
        {

        }

        // Verwijder een bestaande afspeellijst van de actieve gebruiker
        public void RemovePlaylist(int num)
        {

        }

        // Toon alle bestaande nummers binnen de huidig geselecteerde afspeellijst
        public void ShowSongsInPlaylist()
        {

        }

        // Voeg een nieuwe iPlayable toe aan de huidig geselecteerde afspeellijst
        public void AddToPlaylist(int num)
        {

        }

        // Verwijder een nummer van de huidig geselecteerde afspeellijst
        public void RemoveFromPlaylist(int num)
        {

        }

        // Toon alle vrienden van de actieve gebruiker
        public void ShowFriends()
        {

        }

        // Selecteer een gebruiker uit de vriendenlijst van de actieve gebruiker
        public void SelectFriend()
        {

        }

        // Voeg een bestaande gebruiker toe aan de vriendenlijst van de actieve gebruiker
        public void AddFriends(int num)
        {

        }

        // Verwijder een gebruiker van de vriendenlijst van de actieve gebruiker
        public void RemoveFriend(int num)
        {

        }


    }
}
