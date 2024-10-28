using System;

namespace Design.MethodsAndProperties
{
    //basically way to access array of class 
    public class StringCollection
    {
        private string[] items = new string[10]; // Array to hold string items
        private int count = 0; // Current count of items

        // Indexer to allow array-like access

        //Indexers in C# allow instances of a class or struct to be indexed like arrays. They provide a way to access elements of a collection or a data structure using array-like syntax.
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Index out of range.");
                }
                return items[index];
            }
            set
            {
                if (index < 0 || index >= items.Length)
                {
                    throw new IndexOutOfRangeException("Index out of range.");
                }
                items[index] = value;
                if (index >= count)
                {
                    count = index + 1; // Update count if necessary
                }
            }
        }

        // Method to add a new item
        public void Add(string item)
        {
            if (count >= items.Length)
            {
                throw new InvalidOperationException("Collection is full.");
            }
            items[count] = item;
            count++;
        }

        // Property to get the current count of items
        public int Count
        {
            get { return count; }
        }
    }
}


/*
 * Items in the collection:
Apple
Banana
Cherry

After modification:
Apple
Blueberry
Cherry
Error: Index out of range.
*/


/*
 * Book Class
 namespace Design.Library
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return $"{Title} by {Author}";
        }
    }
}


Library Class with Indexer

using System;

namespace Design.Library
{
    public class Library
    {
        private Book[] books = new Book[100]; // Array to hold books
        private int count = 0; // Current number of books

        // Indexer to allow access to books
        public Book this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Index out of range.");
                }
                return books[index];
            }
            set
            {
                if (index < 0 || index >= books.Length)
                {
                    throw new IndexOutOfRangeException("Index out of range.");
                }
                books[index] = value;
                if (index >= count)
                {
                    count = index + 1; // Update count if necessary
                }
            }
        }

        // Method to add a book
        public void AddBook(Book book)
        {
            if (count >= books.Length)
            {
                throw new InvalidOperationException("Library is full.");
            }
            books[count] = book;
            count++;
        }

        // Property to get the current count of books
        public int Count => count;
    }
}

//main
using System;
using Design.Library;

class Program
{
    static void Main(string[] args)
    {
        var library = new Library();

        // Adding books to the library
        library.AddBook(new Book("1984", "George Orwell"));
        library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee"));
        library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald"));

        Console.WriteLine("Books in the library:");
        DisplayBooks(library);

        // Modifying a book
        library[1] = new Book("Brave New World", "Aldous Huxley"); // Change "To Kill a Mockingbird" to "Brave New World"

        Console.WriteLine("\nAfter modification:");
        DisplayBooks(library);
    }

    static void DisplayBooks(Library library)
    {
        for (int i = 0; i < library.Count; i++)
        {
            Console.WriteLine(library[i]);
        }
    }
}
*/