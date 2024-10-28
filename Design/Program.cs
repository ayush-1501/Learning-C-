using Design.DataStructures;
using System;
using System.Buffers.Text;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        // variables are used to store data, and each variable is associated with a specific data type that determines the kind of data it can hold.
        // Datatypes.MainDatatypes();

        //operators are special symbols that perform operations on variables and values.
        // Operators.MainOperators();


        //Control flow statements in C# allow you to dictate the order in which statements are executed based on certain conditions. 
        //Loops.MainLoops();

        //classes and objects are fundamental concepts of object-oriented programming (OOP). They allow you to model real-world entities and manage data more effectively. 
        //CallClass.FunctionToCallClass();

        /* Inheritance allows you to create new classes based on existing ones, facilitating code reuse.
       Polymorphism enables you to use methods in multiple forms, improving flexibility and maintainability.
       Encapsulation protects the internal state of an object by restricting access, promoting better data integrity.*/
       // ClassProperty.ClassFunctions();

       // ArraysDS arrays = new ArraysDS();
       // arrays.RunAllDemonstrations();

       // ListDS arraysDS = new ListDS();
       // arraysDS.RunAllDemonstrations();

       // DictionariesDS dictionariesDS = new DictionariesDS();
       // dictionariesDS.RunAllDemonstrations();

        //StacksAndQueuesDS stacksAndQueuesDS = new StacksAndQueuesDS();
       // stacksAndQueuesDS.RunAllDemonstrations();

        SetsDS setsDS = new SetsDS();
        setsDS.RunAllDemonstrations();
    }
}
