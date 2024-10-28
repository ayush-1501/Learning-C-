using System;

namespace Design.MethodsAndProperties
{
    public class OverloadedMethods
    {
        // Method to add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Overloaded method to add three integers
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Overloaded method to add two double values
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Method to display the result
        public void DisplayResult()
        {
            Console.WriteLine("Addition of two integers: " + Add(5, 10));
            Console.WriteLine("Addition of three integers: " + Add(5, 10, 15));
            Console.WriteLine("Addition of two doubles: " + Add(5.5, 10.5));
        }
    }
}
