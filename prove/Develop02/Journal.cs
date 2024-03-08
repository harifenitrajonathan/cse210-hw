using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        Console.WriteLine("Journal Entries:");
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string _file)
    {
        using (StreamWriter writer = new StreamWriter(_file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._Date}: {entry._Prompt}");
                writer.WriteLine($"Response: {entry._Response}");
                writer.WriteLine();
            }
        }
    }

    public void LoadFromFile(string _file)
    {
        _entries.Clear();
        using (StreamReader reader = new StreamReader(_file))
        {
            string _line;
            while ((_line = reader.ReadLine()) != null)
            {
                string _prompt = _line.Substring(_line.IndexOf(':') + 1).Trim();
                string _response = reader.ReadLine().Substring("Response: ".Length);
                _entries.Add(new Entry { _Date = DateTime.Now, _Prompt = _prompt, _Response = _response });
                reader.ReadLine();
            }
        }
    }
}