using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sportcars
{
    class Bus : Car
    {
        private static Random rnd = new Random();
        public int speed = rnd.Next(800, 1100 + 1);
        public string Name = "Bus";
        public void Ride()
        {
            Go(Name, My_Speed(speed));
        }
    }
}
