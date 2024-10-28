using System;
using System.Collections.Generic;

namespace Design.DataStructures
{
    public class StacksAndQueuesDS
    {
        public void DemonstrateStack()
        {
            // Creating a stack of integers
            Stack<int> stack = new Stack<int>();

            // Pushing elements onto the stack
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Stack contents (LIFO):");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            // Popping an element from the stack
            Console.WriteLine($"\nPopped from stack: {stack.Pop()}");

            // Peek at the top element
            Console.WriteLine($"Top element after pop: {stack.Peek()}");

            // Checking the count of elements in the stack
            Console.WriteLine($"Number of elements in stack: {stack.Count}");
        }

        public void DemonstrateQueue()
        {
            // Creating a queue of strings
            Queue<string> queue = new Queue<string>();

            // Enqueuing elements into the queue
            queue.Enqueue("Alice");
            queue.Enqueue("Bob");
            queue.Enqueue("Charlie");

            Console.WriteLine("\nQueue contents (FIFO):");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // Dequeuing an element from the queue
            Console.WriteLine($"\nDequeued from queue: {queue.Dequeue()}");

            // Peek at the front element
            Console.WriteLine($"Front element after dequeue: {queue.Peek()}");

            // Checking the count of elements in the queue
            Console.WriteLine($"Number of elements in queue: {queue.Count}");
        }

        // Method to call all demonstrations
        public void RunAllDemonstrations()
        {
            DemonstrateStack();
            DemonstrateQueue();
        }
    }
}

/*
 * Stack contents (LIFO):
3
2
1

Popped from stack: 3
Top element after pop: 2
Number of elements in stack: 2

Queue contents (FIFO):
Alice
Bob
Charlie

Dequeued from queue: Alice
Front element after dequeue: Bob
Number of elements in queue: 2
*/