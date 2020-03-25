using System;

namespace StarTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 stop watches used to time the two different ways of printing Star-Triangles
            var watch = new System.Diagnostics.Stopwatch();
            var watch2 = new System.Diagnostics.Stopwatch();

            Console.WriteLine("\tSTAR-TRIANGLE PROGRAM:\n");
            Console.Write("How many many rows would you like [0-50]: ");
            int lines = Convert.ToInt32(Console.ReadLine());

            //prints w/out Arrays and tracks processing time
            watch.Start();
            StarTriangle(lines);
            watch.Stop();
            Console.WriteLine($"Execution time for **PRINT** version: {watch.ElapsedMilliseconds} ms");

            //stores the stars in an array, prints it, and tracks processing time
            watch2.Start();
            ArrayStar(lines);
            watch2.Stop();
            Console.WriteLine($"Execution time for **ARRAY** version: {watch2.ElapsedMilliseconds} ms");
        }

        public static void StarTriangle(int lines)
        {
            if (lines < 0 || lines > 50)
            {
                Console.WriteLine("Error: Out of limits [0-50]");
                return;
            }
            if (lines == 0)
            {
                Console.WriteLine("There are not lines to print");
                return;
            }
            for (int i=1; i <= lines; i++)
            {
                for (int k = lines - i; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (int j = i; j > 0; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void ArrayStar(int input)
        {
            //creates an empty character array 
            char[,] starArray = new char[(2 * input) - 1, input];

            //determines the midpoint index of a row
            int midPoint = starArray.GetLength(0) / 2;

            //stores the stars at inteneded locations in the array
            for (int i = 0; i < starArray.GetLength(1); i++)
            {
                    //even index rows have a star at the midpoint
                    if (i % 2 == 0)
                    {
                        starArray[midPoint, i] = '*';
                    }

                    //all rows have stars at every other paired index from the midpoint determined by the row they are on
                    for (int j = i; j > 0; j -= 2)
                    {
                        starArray[midPoint + j, i] = '*';
                        starArray[midPoint - j, i] = '*';
                    }
            }

            //prints each index of the array
            for (int y = 0; y < starArray.GetLength(1); y++)
            {
                for (int x = 0; x < starArray.GetLength(0); x++)
                {
                    Console.Write(starArray[x, y]);
                }
                Console.WriteLine();
            }
        }
    }
}
