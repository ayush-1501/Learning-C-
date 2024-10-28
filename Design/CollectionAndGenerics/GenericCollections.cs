using System;
using System.Collections.Generic;

namespace Design.CollectionAndGenerics
{
    public class Student
    {
        public int Id { get; }
        public string Name { get; }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}";
        }
    }

    public class StudentManagement
    {
        private List<Student> students = new List<Student>();
        private Dictionary<int, Student> studentDictionary = new Dictionary<int, Student>();
        private HashSet<int> studentIds = new HashSet<int>();

        public void AddStudent(Student student)
        {
            students.Add(student);
            studentDictionary[student.Id] = student;
            studentIds.Add(student.Id);
        }

        public void DisplayStudents()
        {
            Console.WriteLine("Students in the list:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        public void DisplayStudentById(int id)
        {
            if (studentDictionary.TryGetValue(id, out var student))
            {
                Console.WriteLine($"Found: {student}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public void DisplayUniqueIds()
        {
            Console.WriteLine("Unique Student IDs:");
            foreach (var id in studentIds)
            {
                Console.WriteLine(id);
            }
        }
    }
}


