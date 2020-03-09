using System;

namespace ConsoleApp1
{
    public class Plant
    {
        public int numberOfLeaves;
        public string flowerColor;
        public int HeightFeet;
        public string name;

        public void Grow()
        {
            HeightFeet++;
        }
    }

    public class PineTree : Plant
    {
        public PineTree()
        {
            this.HeightFeet = 4;
        }
        public void Grow(double growthRate)
        {
            HeightFeet = (int)(HeightFeet * (1 + growthRate));
        }
    }

    public class Pineapple : Plant
    {
        public Pineapple()
        {
            this.HeightFeet = 1;
        }
    }
    //List of Tree Names
    public enum TreeNames { A, B, C, D, E, F };

    class Inheritance
    {
        public static void BuildNursery()
        {
            PineTree[] trees = new PineTree[6];
            Pineapple[] shrubs = new Pineapple[5];
            Plant Orchid = new Plant();

            Orchid.HeightFeet = 1;
            Orchid.Grow();

            Console.WriteLine($"My Orchid is {Orchid.HeightFeet} feet tall.\n");

            //Assigns name to the first name in enumeration
            TreeNames name = TreeNames.A;
            for (int i = 0; i < trees.Length; i++)
            {
                

                trees[i] = new PineTree();
                //Assigns the tree name from enumeration list at 
                trees[i].name = name.ToString();
                double rate = 1;
                if ((i % 3) == 1)
                {
                    rate = 2;
                }
               
                trees[i].Grow(rate);
                Console.WriteLine($"tree: {i} called {trees[i].name} is {trees[i].HeightFeet} feet tall");

                //Increases the enumeration value to grab next name in the enumeration
                name++;
            }

            Console.WriteLine("");

            for (int i = 0; i < shrubs.Length; i++)
            {
                shrubs[i] = new Pineapple();
                shrubs[i].Grow();
                if (i == 2)
                {
                    shrubs[i].Grow();
                }
                Console.WriteLine($" Shrub #{i}: is {shrubs[i].HeightFeet} feet tall");
            }
        }

        static void Main()
        {
            BuildNursery();
        }

        
    }
}
