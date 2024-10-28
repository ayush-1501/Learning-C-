using System;

class ClassProperty
{
    public static void ClassFunctions()
    {
        // Demonstrate Inheritance
        Console.WriteLine("Demonstrating Inheritance:");
        DemonstrateInheritance();
        Console.WriteLine();

        // Demonstrate Polymorphism
        Console.WriteLine("Demonstrating Polymorphism:");
        DemonstratePolymorphism();
        Console.WriteLine();

        // Demonstrate Encapsulation
        Console.WriteLine("Demonstrating Encapsulation:");
        DemonstrateEncapsulation();
    }

    static void DemonstrateInheritance()
    {
        // Base class
        Animal myAnimal = new Dog();
        myAnimal.Speak(); // Inherited method
        ((Dog)myAnimal).Bark(); // Cast to Dog to call Dog's own method
    }

    static void DemonstratePolymorphism()
    {
        // Base class
        Animal myAnimal = new Cat(); // Upcasting
        myAnimal.Speak(); // Calls Cat's Speak method due to polymorphism
    }

    static void DemonstrateEncapsulation()
    {
        BankAccount account = new BankAccount();
        account.Deposit(100);
        account.Withdraw(50);
        Console.WriteLine($"Current Balance: {account.GetBalance()}");
    }

    // Base class
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal speaks");
        }
    }

    // Derived class for Inheritance
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog barks");
        }
    }

    // Derived class for Polymorphism
    class Cat : Animal
    {
        public override void Speak() // Overriding the Speak method
        {
            Console.WriteLine("Cat meows");
        }
    }

    // Encapsulation example
    class BankAccount
    {
        private decimal balance; // Private field

        public void Deposit(decimal amount) // Public method to modify the balance
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}");
            }
        }

        public void Withdraw(decimal amount) // Public method to modify the balance
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew: {amount}");
            }
            else
            {
                Console.WriteLine("Insufficient funds or invalid amount.");
            }
        }

        public decimal GetBalance() // Public method to access the balance
        {
            return balance;
        }
    }
}
