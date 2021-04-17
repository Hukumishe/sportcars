using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sportcars
{
    class CargoCar : Car
    {
        public string Name = "Cargo car";
        private static Random rnd = new Random();
        public int speed = rnd.Next(700, 1000 + 1);

        public void ShowSpeed()
        {
            int speed = rnd.Next(700, 1000 + 1);
        }

        public void Ride()
        {

            Go(Name, My_Speed(speed));
        }
    }
}
