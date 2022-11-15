using GoldenSpoty;
internal class Program
{
    static void Main(string[] args)
    {
        //Song liedje = new Song();
        //Artist artist = new Artist();   
        List<Artist> artists = new List<Artist>();
        List<Song> songs = new List<Song>();
        List<Album> albums = new List<Album>();
        List<PlayList> playLists = new List<PlayList>();


        SongCollaction coll = new SongCollaction("first");
        
        Album album = new Album(artists, "beaking ", songs);
        Album album3 = new Album(artists, "Boef", songs);


        Artist artist = new Artist("GoldenMe", songs);
        Artist artist4 = new Artist("WessBoy", songs);
        
        SuperUser admin = new SuperUser("GoldenMan");
        
        Person me = new Person("Wess");
        Person robert = new Person("Robert");
        Person assad = new Person("Assad");
        Person gibran = new Person("Gibran");

        Song nummer = new Song("nothing breaks like a heart", new List<Artist>() { artist }, 325, 1);
        Song nummer2 = new Song("Fuck C#", artists, 325, 2);

        PlayList playListRobert = new PlayList(robert, "Jeroen's PlayList");
        PlayList playlistGibran = new PlayList(gibran, "Gibran's PlayList");
        PlayList playlist1 = new PlayList(admin, "admin's PlayList");
        PlayList playlist2 = new PlayList(admin, "admin's PlayList");

        playLists.Add(playlist1);
        playLists.Add(playlist2);
        //admin.AddFriend(me);
        //admin.SelectFriend();

        playLists.Add(playListRobert);
        playLists.Add(playlistGibran);
        //admin.RemoveFromPlaylist(playlist1);
        //playLists.ShowAllSongs();

        Console.WriteLine(admin.ShowPlayLists());
        

        //Console.WriteLine(nummer.ToString());
        songs.Add(nummer);
        artists.Add(artist);
        artists.Add(artist4);
        albums.Add(album);


        Console.WriteLine("\n---------------------\n");
        Console.WriteLine("choose 1 for artist");
        Console.WriteLine("choose 2 for album");
        Console.WriteLine("choose 3 for songs");
        Console.WriteLine("choose 4 for superUser");
        int chs = Convert.ToInt32(Console.ReadLine());
        if (chs == 1)
        {
            Console.WriteLine("choose 1 for add artist");
            Console.WriteLine("choose 2 for show artist");
            int chs2 = Convert.ToInt32(Console.ReadLine());
            if (chs2 == 1)
            {
                Console.WriteLine("enter artist name");
                string name = Console.ReadLine();
                Artist artist2 = new Artist(name, songs);
                artists.Add(artist2);
                Console.WriteLine("-----------");
                foreach (Artist artist3 in artists)
                {
                    Console.WriteLine(artist3.name);
                }
                //artists.ShowArtists();
            }
            else if (chs2 == 2)
            {
                foreach (Artist artist1 in artists)
                {
                    Console.WriteLine(artist1.name);
                }
            }
        }
        else if (chs == 2)
        {
            Console.WriteLine("choose 1 for add album");
            Console.WriteLine("choose 2 for show album");
            int chs2 = Convert.ToInt32(Console.ReadLine());
            if (chs2 == 1)
            {
                Console.WriteLine("enter album name");
                string name = Console.ReadLine();
                Album album2 = new Album(artists, name, songs);
                albums.Add(album2);
            }
            else if (chs2 == 2)
            {
                foreach (Album album1 in albums)
                {
                    Console.WriteLine(album1.Title);
                }
            }
        }
        else if (chs == 3)
        {
            Console.WriteLine("choose 1 for add song");
            Console.WriteLine("choose 2 for show song");
            int chs2 = Convert.ToInt32(Console.ReadLine());
            if (chs2 == 1)
            {
                //Console.WriteLine("enter song name");
                //string name = Console.ReadLine();
                //if(name != "")
                //{
                //    name = "no name";
                //}
                Console.WriteLine("enter Artist name");
                string artistIn = Console.ReadLine();
                artists.Add(new Artist(artistIn, songs));
                //Artist artist3 = new Artist(artistIn, songs);
                Console.WriteLine("enter the lenght of the song ");
                int leng = Convert.ToInt32(Console.ReadLine());
                Song song2 = new Song("noName", artists, leng, 1);
                songs.Add(song2);
            }
            else if (chs2 == 2)
            {
                foreach (Song song1 in songs)
                {
                    Console.WriteLine(song1.Title);
                }
            }

        }else if (chs == 4)
        {
            Console.WriteLine("Hello From admin");
            foreach(PlayList pl in playLists)
            {
                Console.WriteLine(pl);
            }
        }else if (chs == 3)
        {
            Console.WriteLine(nummer.ToString());
            nummer.ToString();
        }





    }
}





//Person per = new Person("wessam");
//Person per1 = new Person("naj");
//Person per2 = new Person("sads");
//Person per3 = new Person("fvgklk");


//per.ShowFriends(per);

//SuperUser su = new SuperUser("wessam");
//su.AddFriend(per);
//su.AddFriend(per1);
//su.AddFriend(per2);
//su.AddFriend(per3);

//su.ShowFriends();
//su.RemoveFriend(per);
//su.ShowFriends();
//per.ShowFriends();