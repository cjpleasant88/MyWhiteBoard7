using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t Wanna play Roulette?");
            Console.WriteLine("\t Press enter to spin the wheel!");
            Console.WriteLine("\t -------------------------------");
            Console.ReadLine();

            Random rnd = new Random();
            int bin = rnd.Next(36); //TODO:need to include 00 somehow.

            Console.WriteLine("\t You rolled a: {0}", bin);
            Console.WriteLine("\t -------------------------------");
            Console.WriteLine("\t Your bet is: ");

            //1. Numbers of the bin
            int[] right = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
            int[] middle = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] left = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };

            //2. Evens/Odds
            if ((bin % 2 == 0) || bin == 0)
            {
                Console.WriteLine("\t Even");
            }
            else if (bin % 2 == 1)
            {
                Console.WriteLine("\t Odds");
            }

            //3. Reds/Blacks
            int[] red = new int[] { 1, 3, 5, 7, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] black = new int[] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };

            if (red.Contains(bin))
            {
                Console.WriteLine("\t Red");
            }
            else if (black.Contains(bin))
            {
                Console.WriteLine("\t Black");
            }

            //4.Lows/Highs
            if (bin <= 18)
            {
                Console.WriteLine("\t Lows");
            }
            else if (bin >= 19)
            {
                Console.WriteLine("\t Highs");
            }

            //5. Dozens: row thirds
            if (0 < bin && bin <= 12)
            {
                Console.WriteLine("\t Lower Thirds");
            }
            else if (bin >= 13 && bin <= 24)
            {
                Console.WriteLine("\t Middle Thirds");
            }
            else if (bin >= 25 && bin <= 36)
            {
                Console.WriteLine("\t Upper Thirds");
            }

            Console.ReadLine();

            //TODO: 6.Columns
            //TODO: 7.Street = Rows
            //TODO: 8.6Numbers= 3*2 sets 1-6; 7-12
            //TODO: 9.Split= if you bet 5, a 4 is called, you win split 
            //TODO: 10.Corner= 4 block 

        }
    }
}