using System;
using System.Collections.Generic;

namespace Design.DataStructures
{
    public class DictionariesDS
    {
        public void DemonstrateDictionary()
        {
            // Creating a dictionary
            Dictionary<int, string> numberWords = new Dictionary<int, string>();

            // Adding key-value pairs
            numberWords.Add(1, "One");
            numberWords.Add(2, "Two");
            numberWords.Add(3, "Three");

            Console.WriteLine("Dictionary of Numbers and Words:");
            foreach (var pair in numberWords)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }

        public void DemonstrateAccessingValues()
        {
            // Creating a dictionary with initial values
            Dictionary<string, string> capitals = new Dictionary<string, string>
            {
                { "USA", "Washington, D.C." },
                { "France", "Paris" },
                { "Japan", "Tokyo" }
            };

            // Accessing values
            Console.WriteLine("\nCapitals:");
            Console.WriteLine($"USA: {capitals["USA"]}");
            Console.WriteLine($"France: {capitals["France"]}");
        }

        public void DemonstrateModifyingAndRemoving()
        {
            // Creating a dictionary
            Dictionary<string, int> inventory = new Dictionary<string, int>
            {
                { "Apples", 50 },
                { "Bananas", 30 },
                { "Oranges", 20 }
            };

            // Modifying a value
            inventory["Bananas"] = 25; // Update the count of Bananas

            // Removing a key-value pair
            inventory.Remove("Oranges");

            Console.WriteLine("\nUpdated Inventory:");
            foreach (var item in inventory)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        public void DemonstrateDictionaryOperations()
        {
            // Creating a dictionary
            Dictionary<int, string> students = new Dictionary<int, string>
            {
                { 1, "Alice" },
                { 2, "Bob" },
                { 3, "Charlie" }
            };

            // Checking if a key exists
            Console.WriteLine($"\nDoes the dictionary contain key 2? {students.ContainsKey(2)}");

            // Getting the count of key-value pairs
            Console.WriteLine($"Total number of students: {students.Count}");
        }

        // Method to call all demonstrations
        public void RunAllDemonstrations()
        {
            DemonstrateDictionary();
            DemonstrateAccessingValues();
            DemonstrateModifyingAndRemoving();
            DemonstrateDictionaryOperations();
        }
    }
}

/*
 * DemonstrateDictionary: This method creates a dictionary of integers and their corresponding word representations. It adds key-value pairs and prints them.

DemonstrateAccessingValues: This method creates a dictionary of country-capital pairs and accesses specific values using their keys.

DemonstrateModifyingAndRemoving: This method creates an inventory dictionary, modifies an existing value, removes a key-value pair, and prints the updated inventory.

DemonstrateDictionaryOperations: This method checks if a specific key exists in the dictionary and gets the count of entries.

Sorted List of Numbers:
1
3
4
5
8

Number of elements: 5
Contains 3: True
Dictionary of Numbers and Words:
1: One
2: Two
3: Three

Capitals:
USA: Washington, D.C.
France: Paris

Updated Inventory:
Apples: 50
Bananas: 25

Does the dictionary contain key 2? True
Total number of students: 3
*/