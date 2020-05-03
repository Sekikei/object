using System;

namespace オブジェクト指向
{
    class Vehicle
    {
        public int Passengers;
        public int FuelCap;
        public int Mpg;

        public void Range()
        {
            Console.WriteLine(FuelCap * Mpg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle minivan = new Vehicle();
            minivan.Passengers = 7; //ドット演算子を使ってメンバーにアクセスする
            minivan.FuelCap = 16;
            minivan.Mpg = 21;
            minivan.Range();
        }
    }
}
