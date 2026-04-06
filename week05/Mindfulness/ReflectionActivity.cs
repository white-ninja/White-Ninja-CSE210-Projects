using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time you did something difficult.",
        "Think of a time you helped someone.",
        "Think of a time you were brave."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful?",
        "What did you learn?",
        "How did you feel?",
        "What made this different?"
    };

    public ReflectionActivity()
        : base("Reflection Activity",
        "Reflect on times you showed strength.")
    { }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine("\n" + question);
            ShowSpinner(5);
        }

       DisplayEndingMessage();
       Statistics.ReflectionCount++;
    }
}