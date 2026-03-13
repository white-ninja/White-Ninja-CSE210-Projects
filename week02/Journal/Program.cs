using System;

// Creativity Feature:
// This program allows multiple prompts per journal entry.
// Instead of responding to a single prompt, the user responds
// to several prompts in one entry, allowing deeper reflection.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

         Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Quit");

            Console.Write("Choose option: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();

                for (int i = 0; i < 3; i++)
                {
                    string prompt = promptGen.GetRandomPrompt();

                    Console.WriteLine(prompt);
                    Console.Write("> ");

                    string response = Console.ReadLine();

                    entry._prompts.Add(prompt);
                    entry._responses.Add(response);
                }

                journal.AddEntry(entry);
            }

            else if (choice == 2)
            {
                journal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.Write("Filename: ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }

            else if (choice == 4)
            {
                Console.Write("Filename: ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }
        }

    }
}