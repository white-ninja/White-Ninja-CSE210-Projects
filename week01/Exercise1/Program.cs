using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        // Ask the user for their first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Ask the user for their last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Greet the user by their full name
        Console.WriteLine();
        Console.Write($"Hello, your name is {lastName}, {firstName} {lastName}! Welcome to C# programming.");
    }
}