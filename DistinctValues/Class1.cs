using System;

namespace DistinctValues
{
    public class Class1
    {

        public static int DistinctValues(int[] array)
        {
            bool duplicates;
            int distinctValues = 0;
            if (array == null || array.Length < 1)
            {
                return 0;
            }

            for (int i = 0; i < array.Length; i++)
            {
                duplicates = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i])
                    {
                        duplicates = true;
                        break;
                    }
                }
                if (!duplicates)
                {
                    distinctValues++;
                }
            }
            return distinctValues;
        }

        public static int DistinctArray(int[] array)
        {
            int[] distinctarray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
          
            }

            return 0;
        }
    }
}