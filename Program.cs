using System;
using Spotify;


List<Album> albums = new List<Album>();// goed
List<Artist> artists = new List<Artist>();// goed
List<Song> songs = new List<Song>();// goed
List<Person> persons = new List<Person>();

SuperUser admin = new SuperUser("Admin");// goed
Person person = new Person("Assad");// goed
persons.Add(person);

Artist artist = new Artist("Evanescence", albums);// goed
artists.Add(artist);// goed
Album album = new Album(artists, "Fallen", songs);// goed
albums.Add(album);// goed
Song song = new Song("Bring Me To Life", new List<Artist> { artist }, album, 254, 1);// goed
songs.Add(song);
SongCollection songCollection = new SongCollection("My Collection");// ?
Console.WriteLine(songCollection);
songCollection.Play();// ?


admin.AddFriend(person);// goed
admin.ShowFriends();// goed


Playlist playlist = new Playlist(person, "My Playlist");//goed
playlist.Add(song);//goed
playlist.ShowPlayables();// goed
playlist.Play();// ?

Client Client = new Client(persons, albums, songs);//?
Client.ShowAllUsers();//?
Client.ShowAllSongs();// goed
Client.ShowAllAlbums();// goed




