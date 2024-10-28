using System;

namespace Design.DataStructures
{
    public class ArraysDS
    {
        public void DemonstrateSingleDimensionalArray()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Single-dimensional array:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void DemonstrateTwoDimensionalArray()
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("\nTwo-dimensional array:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void DemonstrateJaggedArray()
        {
            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            Console.WriteLine("\nJagged array:");
            foreach (var row in jaggedArray)
            {
                foreach (int item in row)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }

        // Method to call all demonstrations
        public void RunAllDemonstrations()
        {
            DemonstrateSingleDimensionalArray();
            DemonstrateTwoDimensionalArray();
            DemonstrateJaggedArray();
        }
    }
}
