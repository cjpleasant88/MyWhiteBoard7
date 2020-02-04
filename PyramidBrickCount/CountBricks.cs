using System;

namespace PyramidBrickCount
{
    class CountBricks
    {
        public static int CountOfBricks(int pyramidBase, int pyramidHeight, double brickSize)
        {
            int count = 0;

            int area = pyramidBase * pyramidHeight / 2;
            count = Convert.ToInt32(Convert.ToDouble(area) / brickSize);
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tPyramidBrickCount.CountBricks.Main()");

            Console.WriteLine($"Returned Count is: {CountOfBricks(100, 30, .17)} bricks!");
        }
    }
}
