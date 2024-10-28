using System;

namespace Design.ExceptionHandling
{
    // Custom exception class for invalid age
    public class InvalidAgeException1 : Exception
    {
        public InvalidAgeException1() { }

        public InvalidAgeException1(string message)
            : base(message) { }

        public InvalidAgeException1(string message, Exception innerException)
            : base(message, innerException) { }
    }
}

namespace Design.ExceptionHandling
{
    public class CustomExceptionDemo
    {
        public void ValidateAge(int age)
        {
            if (age < 0)
            {
                throw new InvalidAgeException1("Age cannot be negative.");
            }
            else if (age < 18)
            {
                throw new InvalidAgeException1("You must be at least 18 years old.");
            }

            Console.WriteLine("Age is valid.");
        }

        public void RunDemo()
        {
            try
            {
                Console.WriteLine("Enter your age:");
                int age = Convert.ToInt32(Console.ReadLine());
                ValidateAge(age);
            }
            catch (InvalidAgeException1 ex)
            {
                Console.WriteLine($"Caught an exception: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input format. Please enter a valid integer.");
            }
        }
    }
}