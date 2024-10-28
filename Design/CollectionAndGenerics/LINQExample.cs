using System;
using System.Collections.Generic;
using System.Linq;

namespace Design.CollectionAndGenerics
{
   
        public class StudentLINQ
        {
            public int Id { get; }
            public string Name { get; }
            public string Major { get; }
            public double GPA { get; }

            public StudentLINQ(int id, string name, string major, double gpa)
            {
                Id = id;
                Name = name;
                Major = major;
                GPA = gpa;
            }

            public override string ToString()
            {
                return $"ID: {Id}, Name: {Name}, Major: {Major}, GPA: {GPA:F2}";
            }
        }
    

    public class StudentManagement1
    {
        private List<StudentLINQ> students = new List<StudentLINQ>();

        public void AddStudent(StudentLINQ student)
        {
            students.Add(student);
        }

        public void DisplayStudents()
        {
            Console.WriteLine("All Students:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        public void DisplayStudentsWithHighGPA(double threshold)
        {
            var highGPAStudents = students.Where(s => s.GPA > threshold);

            Console.WriteLine($"\nStudents with GPA greater than {threshold}:");
            foreach (var student in highGPAStudents)
            {
                Console.WriteLine(student);
            }
        }

        public void GroupStudentsByMajor()
        {
            var groupedStudents = students.GroupBy(s => s.Major);

            Console.WriteLine("\nStudents Grouped by Major:");
            foreach (var group in groupedStudents)
            {
                Console.WriteLine($"Major: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($"  {student}");
                }
            }
        }

        public void OrderStudentsByName()
        {
            var orderedStudents = students.OrderBy(s => s.Name);

            Console.WriteLine("\nStudents Ordered by Name:");
            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}

/*
All Students:
ID: 1, Name: Alice, Major: Computer Science, GPA: 3.90
ID: 2, Name: Bob, Major: Mathematics, GPA: 3.40
ID: 3, Name: Charlie, Major: Computer Science, GPA: 3.70
ID: 4, Name: David, Major: Mathematics, GPA: 2.90
ID: 5, Name: Eva, Major: Physics, GPA: 3.80

Students with GPA greater than 3.5:
ID: 1, Name: Alice, Major: Computer Science, GPA: 3.90
ID: 3, Name: Charlie, Major: Computer Science, GPA: 3.70
ID: 5, Name: Eva, Major: Physics, GPA: 3.80

Students Grouped by Major:
Major: Computer Science
  ID: 1, Name: Alice, Major: Computer Science, GPA: 3.90
  ID: 3, Name: Charlie, Major: Computer Science, GPA: 3.70
Major: Mathematics
  ID: 2, Name: Bob, Major: Mathematics, GPA: 3.40
  ID: 4, Name: David, Major: Mathematics, GPA: 2.90
Major: Physics
  ID: 5, Name: Eva, Major: Physics, GPA: 3.80

Students Ordered by Name:
ID: 1, Name: Alice, Major: Computer Science, GPA: 3.90
ID: 2, Name: Bob, Major: Mathematics, GPA: 3.40
ID: 3, Name: Charlie, Major: Computer Science, GPA: 3.70
ID: 4, Name: David, Major: Mathematics, GPA: 2.90
ID: 5, Name: Eva, Major: Physics, GPA: 3.80*/