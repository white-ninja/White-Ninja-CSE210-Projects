using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    // ⭐ EXCEED REQUIREMENT — STREAK SYSTEM
    private int _streak = 0;

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nScore: {_score} | 🔥 Streak: {_streak}");
    }

    public void ListGoals()
    {
        int i = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{i}. {g.GetStatus()} {g.GetName()}");
            i++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
            _goals.Add(new SimpleGoal(name, desc, points));

        else if (type == "2")
            _goals.Add(new EternalGoal(name, desc, points));

        else if (type == "3")
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you complete? ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        int earned = _goals[choice].RecordEvent();
        _score += earned;

        // 🔥 STREAK BONUS
        _streak++;
        if (_streak % 3 == 0)
        {
            int streakBonus = 100;
            Console.WriteLine("🔥 STREAK BONUS! +100 points!");
            _score += streakBonus;
        }

        Console.WriteLine($"You earned {earned} points!");
    }

    public void SaveGoals()
    {
        using (StreamWriter output = new StreamWriter("goals.txt"))
        {
            output.WriteLine(_score);
            output.WriteLine(_streak);

            foreach (Goal g in _goals)
                output.WriteLine(g.GetStringRepresentation());
        }
    }

    public void LoadGoals()
    {
        string[] lines = File.ReadAllLines("goals.txt");
        _score = int.Parse(lines[0]);
        _streak = int.Parse(lines[1]);
        _goals.Clear();

        for (int i = 2; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string[] data = parts[1].Split(",");

            if (parts[0] == "SimpleGoal")
                _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2])));

            else if (parts[0] == "EternalGoal")
                _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));

            else if (parts[0] == "ChecklistGoal")
                _goals.Add(new ChecklistGoal(data[0], data[1], int.Parse(data[2]),
                    int.Parse(data[5]), int.Parse(data[3])));
        }
    }
}