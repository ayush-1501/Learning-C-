using System;

namespace Design.ExceptionHandling
{
    public class TryCatch
    {
        public void DemonstrateBasicTryCatch()
        {
            try
            {
                Console.WriteLine("Enter a number to divide 100:");
                int number = Convert.ToInt32(Console.ReadLine());
                int result = 100 / number;
                Console.WriteLine($"Result: 100 / {number} = {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input format. Please enter a valid integer.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        public void DemonstrateMultipleCatch()
        {
            try
            {
                Console.WriteLine("Enter an index to access an array:");
                int index = Convert.ToInt32(Console.ReadLine());
                int[] numbers = { 1, 2, 3 };

                // This may throw an IndexOutOfRangeException
                Console.WriteLine($"Number at index {index}: {numbers[index]}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: Index out of range.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input format. Please enter a valid integer.");
            }
        }

        public void DemonstrateFinallyBlock()
        {
            try
            {
                Console.WriteLine("Enter a number to divide 100:");
                int number = Convert.ToInt32(Console.ReadLine());
                int result = 100 / number;
                Console.WriteLine($"Result: 100 / {number} = {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("This block executes regardless of an exception.");
            }
        }

        // Method to call all demonstrations
        public void RunAllDemonstrations()
        {
            Console.WriteLine("Demonstrating Basic Try-Catch:");
            DemonstrateBasicTryCatch();

            Console.WriteLine("\nDemonstrating Multiple Catch:");
            DemonstrateMultipleCatch();

            Console.WriteLine("\nDemonstrating Finally Block:");
            DemonstrateFinallyBlock();
        }
    }
}


/*
Explanation of the Methods
DemonstrateBasicTryCatch:

Prompts the user to enter a number to divide 100.
Handles DivideByZeroException, FormatException, and a generic Exception.
Displays appropriate error messages based on the type of exception.
DemonstrateMultipleCatch:

Prompts the user for an index to access an array.
Catches IndexOutOfRangeException and FormatException to handle errors related to invalid indexes and input formats.
DemonstrateFinallyBlock:

Similar to the first demonstration, but includes a finally block that executes regardless of whether an exception was thrown.
Displays a message indicating the block’s execution.

 
 Demonstrating Basic Try-Catch:
Enter a number to divide 100:
0
Error: Cannot divide by zero.

Demonstrating Multiple Catch:
Enter an index to access an array:
100
Error: Index out of range.

Demonstrating Finally Block:
Enter a number to divide 100:
0
Error: Attempted to divide by zero.
This block executes regardless of an exception.
*/