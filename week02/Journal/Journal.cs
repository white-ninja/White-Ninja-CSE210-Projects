using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter output = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                for (int i = 0; i < entry._prompts.Count; i++)
                {
                    output.WriteLine($"{entry._date}|{entry._prompts[i]}|{entry._responses[i]}");
                }
            }
        }
    }

   
    public void LoadFromFile(string filename)
    {
    string[] lines = File.ReadAllLines(filename);

    _entries.Clear();

    foreach (string line in lines)
    {
        string[] parts = line.Split("|");

        Entry entry = new Entry();
        entry._date = parts[0];

        entry._prompts.Add(parts[1]);
        entry._responses.Add(parts[2]);

        _entries.Add(entry);
    }
    }
}