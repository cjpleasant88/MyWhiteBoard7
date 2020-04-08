using System;

namespace ReverseInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(ReverseInt(-123));
        }

        public static int ReverseInt(int input)
        {
            /*
            bool isNeg = false;
            if(input < 0 )
            {isNeg = true;}
            input = Math.Abs(input);
            */

            //int temp; //< --Don't need a temp value
int ReturnReverse = 0;

            while (input != 0)
            {
                ReturnReverse *= 10;//< --shifts everything to the left
            ReturnReverse += input % 10;

                input = input / 10;
            }
            return ReturnReverse;
        }
    }
}
