using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sportcars
{
    abstract class Car
    {
        public delegate void Start();
        public delegate void Message();
        public event Message Display;

        public int My_Speed(int speed)
        {
            return speed;
        }

        public void Win(string name)
        {
            Console.WriteLine($"{name} arrived");
        }

        public void Go(string name, int speed)
        {
            int distance = 0;
            Display += () => Win(name);
            for (int i = 0; i < 110; i += 10, distance += 10)
            {
                Thread.Sleep(speed);
                if (distance == 100)
                    Display();
            }
        }
    }
}
