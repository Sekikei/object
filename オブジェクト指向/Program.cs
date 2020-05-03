using System;

namespace オブジェクト指向
{
    class Vehicle
    {
        public int Passengers;
        public int FuelCap;
        public int Mpg;

        public Vehicle(int p,int q,int r)   //コンストラクターの作成
        {
         Passengers=p;
         FuelCap=q;
         Mpg=r;
         }
        public int Range()
        {
            return FuelCap * Mpg;
        }
        public double FuelNeeded(int miles)
        {
            return (double)miles / Mpg;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle minivan = new Vehicle(7,16,21);
            int dist = 252;
            int range= minivan.Range();
            double gallons = minivan.FuelNeeded(dist);
            Console.WriteLine(range);
            Console.WriteLine(gallons);
        }
    }
}
