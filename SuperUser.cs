using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoldenSpoty;


namespace GoldenSpoty
{
    internal class SuperUser : Person
    {
        protected List<Person> persons = new List<Person>();

        public SuperUser(string user) : base(user)
        {
            this.Name = user;
        }



        public void AddFriend(Person person)
        {
            //Person per = new Person(person.Name);
            //Friends.Add(person);
            if (Friends.Contains(this))
            {
                Console.WriteLine("This person is already your friend");
            }
            else
            {
                Friends.Add(this);
                //Console.WriteLine("This person is your friend now");
            }
        }

        public void SelectFriend()
        {
            //Friends.Select(x => x.Name).ToList();
            foreach (Person per in Friends)
            {
                Console.WriteLine(per.Name);
                Console.WriteLine("select a Friend");
                string friend = Console.ReadLine();
                if (per.Name == friend)
                {
                    Console.WriteLine("You selected " + per.Name);
                    //Console.WriteLine("Do want to this delete this friend? (y/n)");
                    //string answer1 = Console.ReadLine();
                    //if (answer1 == "y" || answer1 == "Y" || answer1 == "yes")
                    //{
                    //    //Friends.Add(per);
                    //    RemoveFriend(per);
                    //}else if (answer1 == "n" || answer1 == "n" || answer1 == "no")
                    //{
                    //    Console.WriteLine("Okay");
                    //}
                }
            }
        }


        public void RemoveFriend(Person person)
        {
            for (int i = 0; i < Friends.Count; i++)
            {
                if (Friends[i] == person)
                {
                    Friends.Remove(Friends[i]);
                    Console.WriteLine("user is verwijderd");
                }
            }
        }



        public PlayList CreatePlayList(string name)
        {
            PlayList playlist = new PlayList(this, name);
            PlayList.Add(playlist);
            return playlist;
            //return new PlayList(this, name);
        }



        public void RemovePlayList(int num)
        {
            for (int i = 0; i < PlayList.Count; i++)
            {
                if (PlayList[i].Equals(num))
                {
                    PlayList.Remove(PlayList[i]);
                    Console.WriteLine("Playlist has been moved to the trash");
                }
            }
        }



        public void AddToPlayList(iPlayable iPlayable)
        {


            
        }



        public void RemoveFromPlaylist(iPlayable iPlayable)
        {



        }
    }
}
