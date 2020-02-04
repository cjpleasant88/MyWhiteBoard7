using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                {
                    Console.WriteLine("\tWeek3Programs.EX_3A_Exceptiopns.Main\n");
                    Part1();
                    Part2();
                }
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("***************************************************************");
                Console.WriteLine("\t\tThis is the end of the Program");
                Console.WriteLine("***************************************************************");
                Console.ResetColor();
            }
        }

        public static double GetPosNumber()
        {
            string userInput = Console.ReadLine();
            double doubleInput;
            try
            {
                doubleInput = double.Parse(userInput);
                if (doubleInput < 0) throw new ArgumentOutOfRangeException();
                return doubleInput;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("**ERROR** Your value needs to be a positive value!");
                Console.ResetColor();
                Console.Write("\nPlease Enter a positive value: ");
                doubleInput = GetPosNumber();
                return doubleInput;
            }

            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("**ERROR** Invalid Format, please enter a positive number");
                Console.ResetColor();
                Console.Write("\nPlease Enter a positive value: ");
                doubleInput = GetPosNumber();
                return doubleInput;
            }
        }

        // Part 1-------------------------------------------------------------
        static void Part1()
        {
            Console.WriteLine("***************************************************************");
            Console.WriteLine("\n\tPart 1, circumference and area of a circle.");
            Console.Write("\nEnter a positive value for the radius: ");
            double doubradius = GetPosNumber();
            double circumference = checked(2 * Math.PI * doubradius);
            Console.WriteLine($"\nThe circumference is {circumference}");

            //Perform math equation
            double area = Math.PI * Math.Pow(doubradius, 2);

            //Give user answer
            Console.WriteLine($"The area is {area}\n");
        }

        // Part 2----------------------------------------------------------- 
        static void Part2()
        {
            Console.WriteLine("***************************************************************");
            Console.WriteLine("\n\tPart 2, volume of a hemisphere.");

            //prompt user and ask for input
            double doubnewradius = 0;
            do
            {
                Console.Write("\nEnter a positive value for the radius: ");
                doubnewradius = GetPosNumber();
            } while (doubnewradius == 0);

            //math equation using integer input
            double volume = (((4.0 / 3.0) * Math.PI * Math.Pow(doubnewradius, 3)) / 2);

            //Give user the answer
            Console.WriteLine($"\nThe volume is {volume}\n");
        }
    }
}
