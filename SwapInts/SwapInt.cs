using System;

namespace SwapInts
{
    public class SwapInt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int x = 5;
            int y = 9;

            Console.WriteLine($" X = {x} and Y = {y}");

            Swap(ref x,ref  y);
            
            Console.WriteLine($" X = {x} and Y = {y}");
        }

        public static void Swap(ref int x,ref int y)
        {
            y = x + y;
            x = y - x;
            y = y - x;
        }
    }
}
