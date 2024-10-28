using System;

namespace Design.MethodsAndProperties
{
    public class OptionalParameters
    {
        // Method with optional parameters
        public void DisplayInfo(string name, int age = 18, string city = "Unknown")
        {
            Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");
        }

        // Method to demonstrate optional parameters
        public void RunDemo()
        {
            Console.WriteLine("Calling with all parameters:");
            DisplayInfo("Alice", 25, "New York");

            Console.WriteLine("\nCalling with age and city as default:");
            DisplayInfo("Bob", 30); // City will default to "Unknown"

            Console.WriteLine("\nCalling with only name (other parameters will use default values):");
            DisplayInfo("Charlie"); // Age will default to 18 and City to "Unknown"
        }
    }
}
