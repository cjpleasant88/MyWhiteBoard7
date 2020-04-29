/*
 * Write a program that prints the numbers from 1 to 100.
But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”.
For numbers which are multiples of both three and five print “FizzBuzz”.
*/

using System;

namespace Fizz_Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fizz Buzz Problem");

            for(int i = 1; i < 101; i++)
            {
                bool fizzOrBuzz = false;
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                    fizzOrBuzz = true;
                }
                if(i % 5 == 0)
                {
                    Console.Write("Buzz");
                    fizzOrBuzz = true;
                }
                if(!fizzOrBuzz)
                {
                    Console.Write(i);
                }
                Console.WriteLine();

            }
        }
    }
}
