using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenSpoty
{
    internal class Album : SongCollaction
    {

        protected List<Artist> Artists;


        public Album(List<Artist> artiest, string songName, List<Song> song) : base(songName)
        {
            this.Artists = artiest;
            this.Title = songName;

        }

        public List<Artist> ShowArtists()
        { 
            foreach(Artist artist in Artists)
            {
                Console.WriteLine(artist.name);
            }
            return Artists;
        }

        public override string ToString() 
        {
            return this.Title;
        }



    }
}
