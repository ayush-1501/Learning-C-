using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Design.FileHandling
{
    public class FileIO
    {
        public void ProcessScores(string inputFilePath, string outputFilePath)
        {
            // Check if the input file exists
            if (!File.Exists(inputFilePath))
            {
                Console.WriteLine($"Input file not found. Creating a new file: {inputFilePath}");
                CreateDefaultScoresFile(inputFilePath);
            }

            try
            {
                // Read from the input file
                var studentScores = ReadScoresFromFile(inputFilePath);

                // Calculate average score
                double averageScore = studentScores.Values.Average();
                Console.WriteLine($"Average Score: {averageScore:F2}");

                // Write results to the output file
                WriteResultsToFile(outputFilePath, studentScores, averageScore);
                Console.WriteLine($"Results written to {outputFilePath}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Error: Input file not found. {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"I/O Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        private void CreateDefaultScoresFile(string filePath)
        {
            var defaultScores = new List<string>
            {
                "Alice, 75",
                "Bob, 45",
                "Charlie, 85",
                "David, 55",
                "Eva, 95",
                "Frank, 50"
            };

            File.WriteAllLines(filePath, defaultScores);
        }

        private Dictionary<string, int> ReadScoresFromFile(string filePath)
        {
            var scores = new Dictionary<string, int>();

            foreach (var line in File.ReadLines(filePath))
            {
                var parts = line.Split(',');
                if (parts.Length == 2 && int.TryParse(parts[1].Trim(), out int score))
                {
                    scores[parts[0].Trim()] = score;
                }
            }

            return scores;
        }

        private void WriteResultsToFile(string filePath, Dictionary<string, int> studentScores, double averageScore)
        {
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Name, Score, Result");
                foreach (var student in studentScores)
                {
                    string result = student.Value >= 60 ? "Pass" : "Fail"; // Assuming 60 is the passing score
                    writer.WriteLine($"{student.Key}, {student.Value}, {result}");
                }

                writer.WriteLine($"\nAverage Score: {averageScore:F2}");
            }
        }
    }
}
