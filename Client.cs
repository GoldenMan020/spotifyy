using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenSpoty
{
    internal class Client
    {
        public iPlayable CrurentlyPlaying;
        public int CurrentTime;
        public bool Playing;
        public bool shuffle;
        public bool Repeat;
        public SuperUser ActiveUser;
        public List<Album> AllAlbums;
        public List<Song> AllSongs;
        public List<Person> AllUsers;

        
        public Client(List<Person> person, List<Album> album, List<Song> song)
        {

        }



        public static void SetActiveUser(Person person)
        {
            SetActiveUser(person);
        }



        // Toont alle bestaande albums binnen de client
        public void ShowAllAlbums()
        {
            foreach (Album album in AllAlbums)
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

            foreach (Song song in AllSongs)
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

            foreach (Person person in AllUsers)
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
        public void ShowUserPlaylists(Person per)
        {
            per.ShowPlayLists();
        }



        // Selecteer een bestaande afspeellijst van een beschikbare gebruiker binnen de client
        public void SelectUserPlaylist(int num)
        {

            ActiveUser.selectPlayList(num); 

        }



        // Speel de huidig geselecteerde iPlayable af
        public void Play()
        {


            CrurentlyPlaying.Play();

        }



        // Pauzeer de huidig geselecteerde iPlayable
        public void Pause()
        {
            CrurentlyPlaying.Pause();
        }



        // Stop de huidige geselecteerde iPlayable
        public void Stop()
        {
            CrurentlyPlaying.Stop();
        }



        // Doorgaan naar het volgende beschikbare nummer. Eén enkele nummer wordt opnieuw afgespeeld
        public void Next()
        {

            CrurentlyPlaying.Next();

        }



        // Zet shuffle aan/uit
        public void SetShuffle()
        {
            shuffle = true;
        }



        // Zet repeat aan/uit
        public void SetRepeat()
        {
            Repeat = true;
        }



        // Actieve gebruiker maakt een nieuwe afspeellijst aan
        public void CreatePlaylist(string name)
        {
            ActiveUser.CreatePlayList(name);

        }



        // Toon alle bestaande afspeellijsten van de actieve gebruiker
        public void ShowPlaylists()
        {
            ActiveUser.ShowPlayLists();
        }



        // Selecteer een bestaande afspeellijst van de actieve gebruiker
        public void SelectPlaylist(int num)
        {
            //PlayList[num];
            //Console.WriteLine(PlayList[num]);

            ActiveUser.selectPlayList(num);

        }



        // Verwijder een bestaande afspeellijst van de actieve gebruiker
        public void RemovePlaylist(int num)
        {
            ActiveUser.RemovePlayList(num);
        }



        // Toon alle bestaande nummers binnen de huidig geselecteerde afspeellijst
        public void ShowSongsInPlaylist()
        {
            //AllSongs.
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
            ActiveUser.ShowFriends();
        }



        // Selecteer een gebruiker uit de vriendenlijst van de actieve gebruiker
        public void SelectFriend()
        {
            ActiveUser.SelectFriend();

            //AllUsers.ElementAt(AllUsers - 1);

            //return frie;

        }



        // Voeg een bestaande gebruiker toe aan de vriendenlijst van de actieve gebruiker
        public void AddFriends(int num)
        {
            //int ajs = this.SelectFriend();
            //ActiveUser.AddFriend(num);
            //num = Convert.ToInt32(SelectFriend(num));
            //ActiveUser.AddFriend(num);



        }



        // Verwijder een gebruiker van de vriendenlijst van de actieve gebruiker
        public void RemoveFriend(int num)
        {

            Person selectedUser = AllUsers.ElementAt(num);
            ActiveUser.RemoveFriend(selectedUser);

        }


    }
}
