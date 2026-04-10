// EXCEED REQUIREMENTS:
// Added a STREAK BONUS system 🔥
// Completing 3 goals in a row awards an extra 100 points.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
         GoalManager manager = new GoalManager();

        while (true)
        {
            manager.DisplayPlayerInfo();

            Console.WriteLine("\n1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            string choice = Console.ReadLine();

            if (choice == "1") manager.CreateGoal();
            else if (choice == "2") manager.ListGoals();
            else if (choice == "3") manager.RecordEvent();
            else if (choice == "4") manager.SaveGoals();
            else if (choice == "5") manager.LoadGoals();
            else if (choice == "6") break;
        }
    }
}