using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenSpoty
{
    public enum Genre
    {
        Pop,
        Rock,
        Hip_Hop,
        Rap,
        Country,
        Folk,
        Jazz,
        Heavy_Metal,
        Disco,
        Classical,
        Techno,
        Indie_Rock,
        Psychedelic_Rock
    }
    internal class Song
    {
        public String Title { get; set; }
        public List<Artist> Artists;
        public Genre Genre;
        
        private int Lenght { get; set; }

        public Song(string title, List<Artist> artists, int lenght, int genre) // class Genre
        {
            this.Title = title;
            this.Artists = artists;
            this.Lenght = lenght / 60;
            this.Genre = (Genre)genre;
        }

        public override string ToString()
        {
            List<string> artistsStringList = new List<string>();
            foreach (Artist artist in Artists)
            {
                artistsStringList.Add(artist.name);
            }


            string splitArtistNames = string.Join(" - ", artistsStringList);

            return this.Title + "\n" +
                 "Artist: " + splitArtistNames + "\n" +
                 "Genre: " + this.Genre + "\n" +
                 "Length: " + this.Lenght + "\n";
        }

    }
}
