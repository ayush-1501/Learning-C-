using System;
using System.Collections.Generic;

namespace Design.DataStructures
{
    public class ListDS
    {
        public void DemonstrateList()
        {
            // Creating a list of integers
            List<int> numbers = new List<int>();

            // Adding elements to the list
            numbers.Add(10);
            numbers.Add(20);
            numbers.AddRange(new int[] { 30, 40, 50 });

            Console.WriteLine("List of Numbers:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void DemonstrateStringList()
        {
            // Creating a list of strings
            List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };

            // Modifying an element
            fruits[1] = "Blueberry";

            // Removing an element
            fruits.Remove("Cherry");

            Console.WriteLine("\nList of Fruits:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }

        public void DemonstrateListOperations()
        {
            List<int> numbers = new List<int> { 5, 3, 8, 1, 4 };

            // Sorting the list
            numbers.Sort();
            Console.WriteLine("\nSorted List of Numbers:");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            // Checking the count and if a number exists
            Console.WriteLine($"\nNumber of elements: {numbers.Count}");
            Console.WriteLine($"Contains 3: {numbers.Contains(3)}");
        }

        // Method to call all demonstrations
        public void RunAllDemonstrations()
        {
            DemonstrateList();
            DemonstrateStringList();
            DemonstrateListOperations();
        }
    }
}


/*
 * List of Numbers:
10
20
30
40
50

List of Fruits:
Apple
Blueberry

Sorted List of Numbers:
1
3
4
5
8

Number of elements: 5
Contains 3: True
*/