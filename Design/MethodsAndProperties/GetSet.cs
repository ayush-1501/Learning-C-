using System;

namespace Design.MethodsAndProperties
{
    public class Person
    {
        private string name; // Private field
        private int age;     // Private field

        // Property for Name
        public string Name
        {
            get { return name; } // Getter
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value; // Setter
                }
                else
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
            }
        }

        // Property for Age
        public int Age
        {
            get { return age; } // Getter
            set
            {
                if (value >= 0)
                {
                    age = value; // Setter
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative.");
                }
            }
        }

        // Method to display person's information
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
