using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Run();
            Shobel shobel = new Shobel();
            shobel.Run();
            shobel.Hole();
            Console.WriteLine(shobel.state);

        }
    }

    class Car
    {
        public int state { get; protected set; }
        public void Run()
        {
            state = 1;
        }

        public void Stop()
        {
            state = 0;
        }
    }

    class Shobel : Car
    {
        public void Have()
        {
            state = 3;
        }

        public void Hole()
        {
            state = 2;
        }
    }
}
