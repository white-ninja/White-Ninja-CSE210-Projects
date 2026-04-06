// EXCEEDING REQUIREMENTS:
// This program tracks how many times each activity
// has been completed during the session and allows
// the user to view statistics from the menu.
using System;

class Program
{
    static void Main(string[] args)
    {
         while (true)
        {
            Console.Clear();
            Console.WriteLine("Hello World! This is the Mindfulness Project.");
            Console.WriteLine("This program will help you practice mindfulness through various activities.");
            Console.WriteLine("\nPlease select an activity from the menu below:");
            Console.WriteLine("==============================================");
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                new BreathingActivity().Run();
            }
            else if (choice == "2")
            {
                new ReflectionActivity().Run();
            }
            else if (choice == "3")
            {
                new ListingActivity().Run();
            }
            else if (choice == "4")
            {
                Statistics.DisplayStats();
            }
            else if (choice == "5")
            {
                break;
            }
        }
    }
}