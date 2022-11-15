using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenSpoty
{
    internal class PlayList : SongCollaction
    {
        public Person Owner;

        public PlayList(Person person, string name) : base(name)
        {
            this.Owner = person;
            this.Owner.Name = name;
        }



        public void Add(iPlayable iplayable)
        {
            playables.Add(iplayable);
            
        }



        public void Remove(iPlayable iPlayable)
        {
            playables.Remove(iPlayable);
        }



        public override string ToString()
        {
            return this.Owner.Name + " Owen this Playlist!";
        }
    }
}
