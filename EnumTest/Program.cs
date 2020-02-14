using System;

namespace EnumTest
{

    class Program
    {
        enum Suits : int
        {
            hearts = 1, clubs, diamonds, spades
        }

        enum Months : int { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, 
                                    Aug, Sept, Oct, Nov, Dec }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello enums!");

            for(int i = (int)Suits.hearts; i <= (int)Suits.spades; i++)
            {
                Console.WriteLine(i);
            }

            string[] monthNames =
            {
                "Jan", "Feb", "Mar", "Apr", "May", "Jun",
                "Jul", "Aug", "Sept", "Oct", "Nov", "Dec",
            };

            int thismonth = 2;
            Console.WriteLine($"{thismonth} is the month number");
            Console.WriteLine($"it is {monthNames[thismonth-1]}");
            int advance = 2;
            Console.WriteLine($"in {advance} months it will be {thismonth + advance}");
            Console.WriteLine($"that is {monthNames[thismonth+advance-1]}");
        }
    }
}
