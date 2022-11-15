using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenSpoty
{
    internal class SongCollaction 
    {
        public string Title { get; set; }
        protected List<iPlayable> playables;


        // consturct method
        public SongCollaction(string name)
        {
            this.Title = name;
        }


        public List<iPlayable> ShowPlayables()
        {
            foreach (iPlayable playable in playables)
            {
                Console.WriteLine(playable);
            }   
            return this.playables;
        }

        public void Play()
        {
            foreach (iPlayable playable in playables)
            {
                Console.WriteLine(playable);
            }
        }


        // ShowPlayables : List<iPlayable>

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
