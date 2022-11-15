using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenSpoty
{
    internal class Artist
    {

        public string name;
        protected List<Album> albums;
        protected List<Song> songs;

        public Artist(string name, List<Song> songs)
        {
            this.name = name;
            this.songs = songs;
        }

        public void addSong(Song song)
        {
            songs.Add(song);
        }

        public void addAlbum(Album album)
        {
            albums.Add(album);
        }

        public override string ToString()
        {
            return this.name + this.songs;
        }
    }
}
