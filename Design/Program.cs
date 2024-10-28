using Design.DataStructures;
using System;
using Design.ExceptionHandling;
using Design.MethodsAndProperties;
using Design.CollectionAndGenerics;
using Design.FileHandling;
using Design.Model;
class Program
{
    static void DemonstrateDataStructures()
    {
        //Arrays
        ArraysDS arrays = new ArraysDS();
        arrays.RunAllDemonstrations();

        //Lists
        ListDS arraysDS = new ListDS();
        arraysDS.RunAllDemonstrations();

       // Dictionaries
        DictionariesDS dictionariesDS = new DictionariesDS();
        dictionariesDS.RunAllDemonstrations();

      //  Stacks and Queues
        StacksAndQueuesDS stacksAndQueuesDS = new StacksAndQueuesDS();
        stacksAndQueuesDS.RunAllDemonstrations();

       // Sets
        SetsDS setsDS = new SetsDS();
        setsDS.RunAllDemonstrations();
    }

    static void DemonstrateExceptionHandling()
    {
       // Try - Catch demonstration
        TryCatch tryCatchInstance = new TryCatch();
        tryCatchInstance.RunAllDemonstrations();

       // Throwing exceptions
         ThrowingExceptions throwingExceptions = new ThrowingExceptions();
        throwingExceptions.RunAllDemonstrations();

        //Custom exceptions
         CustomExceptionDemo demo = new CustomExceptionDemo();
        demo.RunDemo();
    }

    static void DemonstratePerson()
    {
        try
        {
            Person person = new Person
            {
                Name = "Alice",
                Age = 30
            };

            person.DisplayInfo();

            // Attempting to set an invalid name
            person.Name = ""; // This will throw an exception
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void Basics()
    {
        // variables are used to store data, and each variable is associated with a specific data type that determines the kind of data it can hold.
        Datatypes.MainDatatypes();

        //operators are special symbols that perform operations on variables and values.
        Operators.MainOperators();


        //Control flow statements in C# allow you to dictate the order in which statements are executed based on certain conditions. 
        Loops.MainLoops();

        //classes and objects are fundamental concepts of object-oriented programming (OOP). They allow you to model real-world entities and manage data more effectively. 
        CallClass.FunctionToCallClass();

        /* Inheritance allows you to create new classes based on existing ones, facilitating code reuse.
       Polymorphism enables you to use methods in multiple forms, improving flexibility and maintainability.
       Encapsulation protects the internal state of an object by restricting access, promoting better data integrity.*/
        ClassProperty.ClassFunctions();
    }
   
    static void MethodsAndProperties()
    {
        /* OverloadedMethods overloadedMethods = new OverloadedMethods();
         overloadedMethods.DisplayResult();

         OptionalParameters optionalParameters = new OptionalParameters();
         optionalParameters.RunDemo();

         //Get set class call
         DemonstratePerson();*/


        //Application of Indexers
        StringCollection collection = new StringCollection();

        // Adding items to the collection
        collection.Add("Apple");
        collection.Add("Banana");
        collection.Add("Cherry");

        // Accessing items using the indexer
        Console.WriteLine("Items in the collection:");
        for (int i = 0; i < collection.Count; i++)
        {
            Console.WriteLine(collection[i]);
        }

        // Modifying an item using the indexer
        collection[1] = "Blueberry"; // Change "Banana" to "Blueberry"

        Console.WriteLine("\nAfter modification:");
        for (int i = 0; i < collection.Count; i++)
        {
            Console.WriteLine(collection[i]);
        }

        // Accessing out of bounds index
        try
        {
            Console.WriteLine(collection[5]); // This will throw an exception
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void CollectionAndGenerics()
    {
        var studentManagement = new StudentManagement();

        // Adding students
        studentManagement.AddStudent(new Student(1, "Alice"));
        studentManagement.AddStudent(new Student(2, "Bob"));
        studentManagement.AddStudent(new Student(3, "Charlie"));

        // Displaying all students
        studentManagement.DisplayStudents();

        // Displaying a student by ID
        studentManagement.DisplayStudentById(2);

        // Displaying unique student IDs
        studentManagement.DisplayUniqueIds();
    }


    public void LinqExample()
    {
        var studentManagement1 = new StudentManagement1();

        // Adding students
        studentManagement1.AddStudent(new StudentLINQ(1, "Alice", "Computer Science", 3.9));
        studentManagement1.AddStudent(new StudentLINQ(2, "Bob", "Mathematics", 3.4));
        studentManagement1.AddStudent(new StudentLINQ(3, "Charlie", "Computer Science", 3.7));
        studentManagement1.AddStudent(new StudentLINQ(4, "David", "Mathematics", 2.9));
        studentManagement1.AddStudent(new StudentLINQ(5, "Eva", "Physics", 3.8));

        // Display all students
        studentManagement1.DisplayStudents();

        // Display students with GPA greater than 3.5
        studentManagement1.DisplayStudentsWithHighGPA(3.5);

        // Group students by major
        studentManagement1.GroupStudentsByMajor();

        // Order students by name
        studentManagement1.OrderStudentsByName();
    }
    static void Main()
    {
        //Basics();

        // Data Structures Demonstrations
        // DemonstrateDataStructures();

        // Exception Handling
        // DemonstrateExceptionHandling();

        //MethodsAndProperties();

        //CollectionAndGenerics
        //CollectionAndGenerics();

        //Program program = new Program();
        // program.LinqExample();

        //LamdaExp lambdaExample = new LamdaExp();

        //File Input output example
        /*string inputFilePath = "scores.txt"; // Input file path
        string outputFilePath = "results.txt"; // Output file path

        FileIO fileHandling = new FileIO();
        fileHandling.ProcessScores(inputFilePath, outputFilePath);*/

        //stream input output
        /*string filePath = "streamExample.txt"; 

        StreamHandling streamHandling = new StreamHandling();
        streamHandling.ProcessStream(filePath);*/

        string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "Data"); // Create a 'Data' folder in the current directory
        string fileName = "person.json"; // File name for serialized data
        string filePath = Path.Combine(folderPath, fileName); // Combine folder path and file name
       

        // Create a Person instance
        PersonModel personM = new PersonModel
        {
            Name = "John Doe",
            Age = 30,
            Address = new Address
            {
                Street = "123 Main St",
                City = "Anytown",
                State = "CA",
                ZipCode = "12345"
            }
        };
        personM.PhoneNumbers.Add("123-456-7890");
        personM.PhoneNumbers.Add("987-654-3210");

        // Serialize the Person object
        SerializationHandler serializationHandler = new SerializationHandler();
        serializationHandler.SerializePerson(filePath, personM);

        // Deserialize the Person object
        PersonModel deserializedPerson = serializationHandler.DeserializePerson(filePath);

    }
}
