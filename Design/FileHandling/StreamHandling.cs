using System;
using System.IO;

namespace Design.FileHandling
{
    public class StreamHandling
    {
        public void WriteToFile(string filePath)
        {
            // Sample data to write
            string[] lines = new[]
            {
                "Line 1: Welcome to C# programming!",
                "Line 2: This is an example of working with streams.",
                "Line 3: Enjoy learning and coding!"
            };

            // Check if the file exists; if not, create it
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            using (StreamWriter writer = new StreamWriter(fs))
            {
                foreach (var line in lines)
                {
                    writer.WriteLine(line);
                }
            }

            Console.WriteLine($"Data written to {filePath}");
        }

        public void ReadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File {filePath} does not exist.");
                return;
            }

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            using (StreamReader reader = new StreamReader(fs))
            {
                string line;
                Console.WriteLine($"Reading from {filePath}:");
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        public void ProcessStream(string filePath)
        {
            WriteToFile(filePath);
            ReadFromFile(filePath);
        }
    }
}
