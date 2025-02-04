
public class Journal
{
    public string _name;
    public List<Entry> _entries = new List<Entry>();


    public void Display()
    {
        Console.WriteLine($"Journal Entries: {_entries.Count}");
        foreach (Entry item in _entries)
        {
            item.Display();
        }
    }

    public void AddEntry(string promptText, string entryText)
    {
        string date = DateTime.Now.ToShortDateString();  
        Entry newEntry = new Entry(date, promptText, entryText);
        _entries.Add(newEntry);
    }


    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");  
            string date = parts[0];
            string promptText = parts[1];
            string entryText = parts[2];

            Entry newEntry = new Entry(date, promptText, entryText);
            _entries.Add(newEntry);
        }
    }


    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry.Date}|{entry.PromptText}|{entry.EntryText}");
            }
        }
    }
}
