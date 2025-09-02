
// Amir Moeini Rad
// September 2025

// Main Concept: Tuples in C#

namespace Tuples
{    
    class Program
    {
        static void Main()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Tuples in C#.NET.");
            Console.WriteLine("-----------------\n");


            // Define a tuple with three elements
            // Tuple is a lightweight data structure that can hold a fixed number of items of different types.
            var person = (Name: "Alice", Age: 25, City: "New York");


            // Access tuple elements
            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age: {person.Age}");
            Console.WriteLine($"City: {person.City}");


            // Another way to access a tuple element (by position)
            Console.WriteLine($"Name again: {person.Item1}");


            Console.WriteLine("\nDone.");
        }
    }
}
