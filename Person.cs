using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenSpoty
{
    internal class Person
    {
        public string Name { get; set; }
        protected List<Person> Friends = new List<Person>();
        protected List<PlayList> PlayList = new List<PlayList>();
        protected List<PlayList> PlayLists = new List<PlayList>();



        public Person(string name)
        {
            this.Name = name;
        }


        
        public List<Person> ShowFriends()
        {
            if (Friends.Count != 0)
            {
                foreach (Person friend in Friends)
                {
                    Console.WriteLine(friend.Name);
                    //return Friends;
                }
            }
            else
            {
                Console.WriteLine(Friends + "This user doesnt have friends");
            }
           
            return Friends;

        }

        public List<PlayList> ShowPlayLists()
        {
            //foreach (PlayList playList in PlayList)
            //{
            //    Console.WriteLine(playList);
            //}

            //return PlayList;
            foreach (PlayList playl in PlayLists)
            {
                Console.WriteLine(playl);
            }
            return PlayLists;
        }
        //{
        //    if (playlist.Count != 0)
        //    {
        //        foreach (PlayList perPlay in playlist)
        //        {
        //            Console.WriteLine(perPlay);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(Friends + "This user doesnt have friends");
        //    }

        //    //return playlist;
        //}

        public void selectPlayList(int songNum)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
