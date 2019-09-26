using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformer
{
    enum landscape
    {
        Air,
        Road,
        Water
    }

    class Vehicle
    {
        public int Wheels;
        public int Speed;


        public Vehicle(int wheels, int speed)
        {
            this.Wheels = wheels;
            this.Speed = speed;
        }

        
    }

    class Program
    {
        public void Run(landscape landscape)
        {
            string[,] vehicle = new string[3, 3]
            {
                {"Jet", "8", "900"},
                {"Car", "4", "350"},
                {"Boat", "0", "200"}
            };

            switch (landscape)
            {
                case landscape.Air:
                    Vehicle v1=new Vehicle(Convert.ToInt32(vehicle[0, 1]), Convert.ToInt32(vehicle[0, 2]));
                    Console.WriteLine("Jet");
                    Console.WriteLine("Wheels = {0}", v1.Wheels);
                    Console.WriteLine("Max Speed = {0}", v1.Speed);
                    break;
                case landscape.Road:
                    Vehicle v2 = new Vehicle(Convert.ToInt32(vehicle[1, 1]), Convert.ToInt32(vehicle[1, 2]));
                    Console.WriteLine("Car");
                    Console.WriteLine("Wheels = {0}", v2.Wheels);
                    Console.WriteLine("Max Speed = {0}", v2.Speed);
                    break;
                case landscape.Water:
                    Vehicle v3 = new Vehicle(Convert.ToInt32(vehicle[2, 1]), Convert.ToInt32(vehicle[2, 2]));
                    Console.WriteLine("Boat");
                    Console.WriteLine("Wheels = {0}", v3.Wheels);
                    Console.WriteLine("Max Speed = {0}", v3.Speed);
                    break;
            }
        }

        static void Main(string[] args)
        {
            landscape la = landscape.Air;
            Program transformer = new Program();
            transformer.Run(la);
            Console.ReadLine();
        }
    }
}
