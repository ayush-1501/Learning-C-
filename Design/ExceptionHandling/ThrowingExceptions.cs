using System;

namespace Design.ExceptionHandling
{
    // Custom exception class
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }
    }

    public class ThrowingExceptions
    {
        public void DemonstrateThrowingException()
        {
            try
            {
                Console.WriteLine("Enter your age:");
                int age = Convert.ToInt32(Console.ReadLine());
                ValidateAge(age);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine($"Caught an exception: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input format. Please enter a valid integer.");
            }
        }

        public void DemonstrateRethrowingException()
        {
            try
            {
                Console.WriteLine("Enter a number to divide 100:");
                int number = Convert.ToInt32(Console.ReadLine());
                int result = 100 / number; // This may throw DivideByZeroException
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero. Rethrowing the exception.");
                throw; // Rethrow the caught exception
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input format. Please enter a valid integer.");
            }
        }

        private void ValidateAge(int age)
        {
            if (age < 0)
            {
                // Throwing custom exception
                throw new InvalidAgeException("Age cannot be negative.");
            }
            else if (age < 18)
            {
                throw new InvalidAgeException("You must be at least 18 years old.");
            }

            Console.WriteLine("Age is valid.");
        }

        // Method to call all demonstrations
        public void RunAllDemonstrations()
        {
            Console.WriteLine("Demonstrating Throwing Exception:");
            DemonstrateThrowingException();

            Console.WriteLine("\nDemonstrating Rethrowing Exception:");
            try
            {
                DemonstrateRethrowingException();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Caught the rethrown exception in Main.");
            }
        }
    }
}
/*
 *Custom Exception Class:

InvalidAgeException inherits from the Exception class and provides a constructor for setting the exception message.
DemonstrateThrowingException:

Prompts the user to enter their age and calls the ValidateAge method to check for validity.
Catches and handles InvalidAgeException and FormatException.
DemonstrateRethrowingException:

Prompts the user to enter a number to divide 100.
Catches DivideByZeroException and rethrows it using throw; for handling elsewhere.
Catches FormatException for invalid input.
ValidateAge:

Validates the age input and throws an InvalidAgeException if the age is invalid.
*/