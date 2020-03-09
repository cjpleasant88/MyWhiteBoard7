using System;

namespace TestArea
{
    class Program
    {
        static void Main()
        {
            int[] myArray = new int[64];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i;
            }
            foreach (var element in myArray)
            {
                Console.WriteLine(element);
            }

        }
    }

}
