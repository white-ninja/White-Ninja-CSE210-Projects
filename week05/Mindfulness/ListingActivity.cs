using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people you appreciate?",
        "What are your strengths?",
        "Who did you help this week?"
    };

    public ListingActivity()
        : base("Listing Activity",
        "List as many positive things as you can.")
    { }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);
        ShowCountdown(5);

        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"You listed {items.Count} items!");
        DisplayEndingMessage();
        Statistics.ListingCount++;
    }
}