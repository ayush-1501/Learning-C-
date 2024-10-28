using System;

class Car
{
    // Fields
    public string Make;
    public string Model;
    public int Year;

    // Constructor
    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    // Method
    public void DisplayInfo()
    {
        Console.WriteLine($"Car Make: {Make}, Model: {Model}, Year: {Year}");
    }
}

class CallClass
{
    public static void FunctionToCallClass()
    {
        // Creating objects of the Car class
        Car car1 = new Car("Toyota", "Camry", 2020);
        Car car2 = new Car("Honda", "Civic", 2021);

        // Calling methods on the objects
        car1.DisplayInfo(); // Output: Car Make: Toyota, Model: Camry, Year: 2020
        car2.DisplayInfo(); // Output: Car Make: Honda, Model: Civic, Year: 2021
    }
}
