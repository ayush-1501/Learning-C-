using System;
using System.Collections.Generic;

public class Datatypes
{
    public static void MainDatatypes()
    {
        // Primitive types
        int age = 25;
        float height = 5.8f;
        double distance = 1000.50;
        char grade = 'A';
        string name = "John";
        bool isStudent = true;

        int[] scores = { 90, 85, 88, 92 };
        List<string> colors = new List<string> { "Red", "Green", "Blue" };
        Dictionary<string, int> population = new Dictionary<string, int>
        {
            { "CityA", 500000 },
            { "CityB", 300000 }
        };

        Console.WriteLine($"Name: {name}, Age: {age}, Height: {height}");
        Console.WriteLine($"Scores: {string.Join(", ", scores)}");
        Console.WriteLine($"Colors: {string.Join(", ", colors)}");
        Console.WriteLine($"CityA Population: {population["CityA"]}");
    }
}
