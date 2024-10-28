namespace Design.CollectionAndGenerics
{
    public class LamdaExp
    {
        public LamdaExp()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // 1. Filter even numbers
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            Console.WriteLine("Even Numbers:");
            evenNumbers.ForEach(n => Console.WriteLine(n));

            // 2. Filter odd numbers
            var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();
            Console.WriteLine("\nOdd Numbers:");
            oddNumbers.ForEach(n => Console.WriteLine(n));

            // 3. Calculate the sum of all numbers
            var sum = numbers.Sum();
            Console.WriteLine($"\nSum of all numbers: {sum}");

            // 4. Find the maximum number
            var max = numbers.Max();
            Console.WriteLine($"Maximum number: {max}");

            // 5. Transform the list by multiplying each number by 2
            var doubledNumbers = numbers.Select(n => n * 2).ToList();
            Console.WriteLine("\nDoubled Numbers:");
            doubledNumbers.ForEach(n => Console.WriteLine(n));

            // 6. Check if any number is greater than 5
            bool anyGreaterThanFive = numbers.Any(n => n > 5);
            Console.WriteLine($"\nIs there any number greater than 5? {anyGreaterThanFive}");

            // 7. Get the count of numbers greater than 5
            int countGreaterThanFive = numbers.Count(n => n > 5);
            Console.WriteLine($"Count of numbers greater than 5: {countGreaterThanFive}");

            // 8. Group numbers by even and odd
            var groupedNumbers = numbers.GroupBy(n => n % 2 == 0 ? "Even" : "Odd");
            Console.WriteLine("\nGrouped Numbers:");
            foreach (var group in groupedNumbers)
            {
                Console.WriteLine($"{group.Key}: {string.Join(", ", group)}");
            }
        }
    }
}
