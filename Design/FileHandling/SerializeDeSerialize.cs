using System;
using System.IO;
using System.Text.Json;
using Design.Model; // Reference the Model namespace

namespace Design.FileHandling
{
    public class SerializationHandler
    {
        public void EnsureDirectoryExists(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine($"Directory created: {folderPath}");
            }
        }

        public void SerializePerson(string filePath, PersonModel person)
        {
            // Ensure the file's directory exists
            EnsureDirectoryExists(Path.GetDirectoryName(filePath));

            string jsonString = JsonSerializer.Serialize(person);
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine($"Serialized data written to {filePath}");
        }

        public PersonModel DeserializePerson(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File {filePath} does not exist.");
                return null;
            }

            string jsonString = File.ReadAllText(filePath);
            PersonModel person = JsonSerializer.Deserialize<PersonModel>(jsonString);
            Console.WriteLine("Deserialized Person:");
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, City: {person.Address.City}");
            return person;
        }
    }
}
