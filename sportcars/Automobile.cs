using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sportcars
{
    class Automobile : Car
    {
        private static Random rnd = new Random();
        public int speed = rnd.Next(600, 900 + 1);
        public string Name = "Automobile";
        public void Ride()
        {
            Go(Name, My_Speed(speed));
        }
    }
}
