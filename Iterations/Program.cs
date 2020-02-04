using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Console.WriteLine("\n\tWhiteBoard7.Iterations.Programm.cs");
               int n = 3;
               Console.WriteLine($"\n\tSum of first {n} odds is: {GetSumOfOdds(n)}");
               */
            int z;
            int x;
            int y = 7;
            string a = "A";
            a += a;
            //a += (char)25;
            Console.WriteLine(a);
            Console.WriteLine($"\n\nx:    y: {y}  z: ");
            x = y++; ;
            Console.WriteLine($"\n\nx: {x}  y: {y}  z:  ");
            z = --y;
            Console.WriteLine($"\n\nx: {x}  y: {y}  z:  {z}");

            //x -= y -= y += 5;
            x -= (y+=5); ;
            Console.WriteLine($"\n\nx: {x}  y: {y}  z:  {z}");
            z += (y-=3);
            Console.WriteLine($"\n\nx: {x}  y: {y}  z:  {z}");
            z %= x;
            Console.WriteLine($"\n\nx: {x}  y: {y}  z:  {z}");

            for (int numOfApples = 1; numOfApples < 5; numOfApples++)
            {
                Console.WriteLine($"{ numOfApples} Apple{Convert.ToString((numOfApples > 1) ? "s" : "")}");
            }
        }
        public static int GetSumOfOdds(int nCount)
        {
            int sum = 0;
            int nextOddNumber = 1;
            int i;

            for (i = 0; i > 0; i++)
            {
                Console.WriteLine(i);
            }
            return sum;
           
        }
    }
}