using System;

namespace SumOfDoubleArrayLib
{
    public class Class1
    {
        public static double Sum(double[] array)
        {
            double sum = 0;

            if (array == null || array.Length < 1)
            {
                return 0;
            }

            foreach(var element in array)
            {
                sum += element;
            }
            return sum;
        }
    }
}
