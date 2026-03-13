public class Entry
{
    public string _date;
    public List<string> _prompts = new List<string>();
    public List<string> _responses = new List<string>();

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");

        for (int i = 0; i < _prompts.Count; i++)
        {
            Console.WriteLine(_prompts[i]);
            Console.WriteLine(_responses[i]);
            Console.WriteLine();
        }
    }
}