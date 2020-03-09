using System;

namespace DistinctElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My name is Caleb, and I look like an officer but am not, the exact opposite of Danny!");
            int[] x = { 1, 2, 3, 4, 5, 6};

            Console.WriteLine($"{DistinctElements(x)}");
        }

        public static int DistinctElements(int[] array)
        {
            int distinct = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int duplicates = 0;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        duplicates++;
                    }
                }
                if (duplicates == 0)
                {
                    distinct++;
                }

            }
            return distinct;

            //int distinct = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    bool isNew = true;
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            isNew = false;
            //        }
            //    }
            //    if (isNew)
            //    {
            //        distinct++;
            //    }

            //}
            //return distinct;
        }
    }
}
