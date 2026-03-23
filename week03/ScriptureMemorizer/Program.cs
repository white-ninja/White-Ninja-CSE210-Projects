// EXCEEDING REQUIREMENTS:
// - Scriptures are loaded dynamically from a text file
// - Supports both single verses and verse ranges
// - Program can easily scale by adding more lines to the file
using System;

class Program
{
    static void Main(string[] args)
    {

        List<Scripture> scriptures = new List<Scripture>();

        string[] lines = File.ReadAllLines("scriptures.txt");

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            if (parts.Length == 4)
            {
                Reference reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
                scriptures.Add(new Scripture(reference, parts[3]));
            }
            else if (parts.Length == 5)
            {
                Reference reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]));
                scriptures.Add(new Scripture(reference, parts[4]));
            }
        }

        Random rand = new Random();
        Scripture scripture = scriptures[rand.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
                break;

            Console.WriteLine("\nPress Enter to continue or type 'quit': ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords();
        }
    }
}