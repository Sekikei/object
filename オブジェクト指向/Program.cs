using System;

namespace オブジェクト指向
{
    class Vehicle
    {
        public int Passengers;
        public int FuelCap;
        public int Mpg;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle minivan = new Vehicle();
            int range;
            minivan.Passengers = 7;
            minivan.FuelCap = 16;
            minivan.Mpg = 21;

            range = minivan.FuelCap * minivan.Mpg;
            Console.WriteLine(range);
        }
    }
}
