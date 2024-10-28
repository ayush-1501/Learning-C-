using System;

public class Operators
{
    public static void MainOperators()
    {
        // Arithmetic Operators
        int a = 10;
        int b = 3;
        Console.WriteLine($"Addition: {a + b}");       // 13
        Console.WriteLine($"Subtraction: {a - b}");    // 7
        Console.WriteLine($"Multiplication: {a * b}"); // 30
        Console.WriteLine($"Division: {a / b}");       // 3
        Console.WriteLine($"Modulus: {a % b}");        // 1

        // Comparison Operators
        Console.WriteLine($"Is Equal: {a == b}");         // false
        Console.WriteLine($"Is Not Equal: {a != b}");     // true
        Console.WriteLine($"Is Greater: {a > b}");        // true
        Console.WriteLine($"Is Less: {a < b}");           // false

        // Logical Operators
        bool condition1 = (a > b);
        bool condition2 = (b > 0);
        Console.WriteLine($"Logical AND: {condition1 && condition2}"); // true
        Console.WriteLine($"Logical OR: {condition1 || (b < 0)}");      // true
        Console.WriteLine($"Logical NOT: {!condition1}");               // false
    }
}
