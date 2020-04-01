using System;

namespace MergeSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = { 2, 4, 5, 3, 2, 8, 5, 4, 12, 12, 3, 56, 87, 65, 34, 56, 99, 0, 7 };
            Print(array);

            int[] result = mergeSort(array);
            Print(result);
        }

        public static int[] mergeSort(int[] lst)
        {
            if (lst.Length <= 1)
            {
                return lst;
            }

            int n = lst.Length;
            int[] left;
            int[] right;

            // create space for left and right subarrays
            if (n % 2 == 0)
            {
                left = new int[n / 2];
                right = new int[n / 2];
            }
            else
            {
                left = new int[n / 2];
                right = new int[n / 2 + 1];
            }

            // fill up left and right subarrays
            for (int i = 0; i < n; i++)
            {
                if (i < n / 2)
                {
                    left[i] = lst[i];
                }
                else
                {
                    right[i - n / 2] = lst[i];
                }
            }

            // recursively split and merge
            left = mergeSort(left);
            right = mergeSort(right);

            // merge
            return merge(left, right);
        }
        // the function for merging two sorted arrays
        public static int[] merge(int[] left, int[] right)
        {
            // create space for the merged array
            int[] result = new int[left.Length + right.Length];

            // running indices
            int i = 0;
            int j = 0;
            int index = 0;

            // add until one subarray is deplete
            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                {
                    result[index++] = left[i++];
                }
                else
                {
                    result[index++] = right[j++];
                }
            }

            // add every leftover element from the subarray 
            while (i < left.Length)
            {
                result[index++] = left[i++];
            }

            // only one of these two while loops will be executed
            while (j < right.Length)
            {
                result[index++] = right[j++];
            }

            return result;
        }

        public static void Print(int[] array)
        {
            Console.Write("[ ");
            for(int i =0; i < array.Length-1; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine($"{array[array.Length-1]} ]");
        }
    }
}
