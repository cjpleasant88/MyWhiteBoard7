using System;

namespace WhiteBoard7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WhiteBoard7.Program.Main()");

            int[,] matrix = new int[3, 3];
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            Console.WriteLine($"You have a {columns} by {rows} matrix!");
            Console.WriteLine($"And a total of {matrix.Length} elements");

            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[1, 0] = 4;
            matrix[1, 1] = 5;
            matrix[1, 2] = 6;
            matrix[2, 0] = 7;
            matrix[2, 1] = 8;
            matrix[2, 2] = 9;
        
            int[] flatmatrix = new int[matrix.Length];
            int flatindex = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    flatmatrix[flatindex] = matrix[i, j];
                    flatindex++;
                }
            }

            for (int h = 0; h < 10;)
            {
                Console.WriteLine($"{h}{++h}");
            }
            for (int i = 0; i < flatmatrix.Length; i++)
            {
                Console.WriteLine(flatmatrix[i]);
            }

            Person caleb = new Person("Caleb", 31);
            (string myName, int myAge) = caleb;
            Console.WriteLine($"My name is {myName} and my age is {myAge}!");
            FlattenArray();

            Console.ReadKey();
        }

        static void FlattenArray()
        {
            int[,] x =
            {
                {1,2,3,11,56 },
                {4,5,6,11,56 },
                {7,8,9,11,56 }
            };
            int[] y = new int[x.Length];

            int k = 0;
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    y[k++] = x[i, j];
                }
            }

            for(int i = 0; i < y.Length; i++)
            {
                Console.WriteLine(y[i]);
            }

        }
    }
    class Person
    {
        public string name;
        private int age;

        public Person()
        {
            this.name = "No - Name";
            this.age = 0;
        }
        public Person(string name, int age)
	{
		this.name = name;
		this.age = age;
	}

    public void Deconstruct(out string name, out int age)
    {
        name = this.name;
        age = this.age;
    }

  
        public static bool IsNumberGreaterThanZero(int input)
        {
            if (input > 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsNumberGreaterThanZero()
        {
            Console.Write("Please enter your number: ");
            int input = int.Parse(Console.ReadLine());
            if (input > 0)
            {
                return true;
            }
            return false;
        }
    }

}
