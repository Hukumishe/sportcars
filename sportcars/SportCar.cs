using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sportcars
{
    class SportCar : Car
    {
        private static Random rnd = new Random();
        public int speed = rnd.Next(500, 800 + 1);
        public string Name = "Sport car";
        public void Ride()
        {
            Go(Name, My_Speed(speed));
        }
    }
}
