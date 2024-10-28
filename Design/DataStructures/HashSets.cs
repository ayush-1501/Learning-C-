using System;
using System.Collections.Generic;

namespace Design.DataStructures
{
    public class SetsDS
    {
        public void DemonstrateSet()
        {
            // Creating a set of integers
            HashSet<int> numbers = new HashSet<int>();

            // Adding elements to the set
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(2); // Duplicate entry (will not be added)

            Console.WriteLine("Set of Numbers:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void DemonstrateSetOperations()
        {
            // Creating two sets
            HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

            // Union
            setA.UnionWith(setB);
            Console.WriteLine("\nUnion of Set A and Set B:");
            foreach (var number in setA)
            {
                Console.WriteLine(number);
            }

            // Intersection
            HashSet<int> setC = new HashSet<int> { 1, 2, 3 };
            setC.IntersectWith(setB);
            Console.WriteLine("\nIntersection of Set C and Set B:");
            foreach (var number in setC)
            {
                Console.WriteLine(number);
            }

            // Difference
            HashSet<int> setD = new HashSet<int> { 1, 2, 3, 4 };
            setD.ExceptWith(setB);
            Console.WriteLine("\nDifference of Set D and Set B:");
            foreach (var number in setD)
            {
                Console.WriteLine(number);
            }
        }

        public void DemonstrateSetProperties()
        {
            HashSet<string> fruits = new HashSet<string> { "Apple", "Banana", "Cherry" };

            // Checking if a specific element exists
            Console.WriteLine($"\nDoes the set contain 'Banana'? {fruits.Contains("Banana")}");

            // Removing an element
            fruits.Remove("Banana");
            Console.WriteLine("Set after removing 'Banana':");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }

        // Method to call all demonstrations
        public void RunAllDemonstrations()
        {
            DemonstrateSet();
            DemonstrateSetOperations();
            DemonstrateSetProperties();
        }
    }
}


/*
 * 1
2
3

Union of Set A and Set B:
1
2
3
4
5
6
7
8

Intersection of Set C and Set B:

Difference of Set D and Set B:
1
2
3

Does the set contain 'Banana'? True
Set after removing 'Banana':
Apple
Cherry*/