using System;

class Loops
{
    public static void MainLoops()
    {
        // If Statement
        int score = 75;
        if (score >= 90)
            Console.WriteLine("Grade: A");
        else if (score >= 80)
            Console.WriteLine("Grade: B");
        else if (score >= 70)
            Console.WriteLine("Grade: C");
        else
            Console.WriteLine("Grade: D");

        // Switch Statement
        int day = 5;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            default:
                Console.WriteLine("Not a valid day");
                break;
        }

        // For Loop
        Console.WriteLine("For Loop:");
        for (int i = 0; i < 3; i++)
            Console.WriteLine($"Iteration: {i}");

        // While Loop
        Console.WriteLine("While Loop:");
        int count = 0;
        while (count < 3)
        {
            Console.WriteLine($"Count: {count}");
            count++;
        }

        // Do-While Loop
        Console.WriteLine("Do-While Loop:");
        int number = 0;
        do
        {
            Console.WriteLine($"Number: {number}");
            number++;
        } while (number < 3);
    }
}
