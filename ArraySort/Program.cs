using System;

namespace ArraySort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int x = (Console.ReadKey().KeyChar-48);
            Console.WriteLine(x);

            int[] testArray = { 0, 4, 7, 4, -2, 4, 10, 12, 14, 4, 8 };
            Console.WriteLine("Original Array");
            DisplayArray(testArray);

            Console.WriteLine("Sort Array Method");
            SortArray(testArray);
            DisplayArray(testArray);


            Console.WriteLine(string.Join("|",testArray));
            //foreach (var score in testArray)
            //{
            //    Console.WriteLine(score);
            //}
                //Console.WriteLine("Chris array Sort");
                //ChrisSort(testArray);

            }

        public static void SortArray(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            DisplayArray(array);
        }

        public static void ChrisSort(int[] arr)
        {
            int p; // placeholder
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr[i+1])
                {
                    for (int x = i; x < arr.Length; x++)
                    {
                        if ( arr[x] > arr[x+1])
                        {
                            p = arr[x + 1];
                            arr.SetValue(arr[x], x + 1);
                            arr.SetValue(p, x);
                        }
                    }
                }
            }


            DisplayArray(arr);
        }

        public static void DisplayArray(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine($"{array[array.Length - 1]}]");
        }
    }


}
