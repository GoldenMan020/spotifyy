using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenSpoty
{
    internal interface iPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing");
        }
        public void Pause()
        {

        }
        public void Next()
        {

        }
        public void Stop()
        {

        }
        public int Lenght()
        {
            return 1;
        }
    }
}
