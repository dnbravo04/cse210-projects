class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        Console.WriteLine("All Journal Entries:");
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string fileName)
    {
        System.Text.Json.JsonSerializerOptions options = new System.Text.Json.JsonSerializerOptions
        {
            WriteIndented = true
        };

        string json = System.Text.Json.JsonSerializer.Serialize(_entries, options);

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.Write(json);
        }
    }

    public void LoadFromFile(string fileName)
    {
        _entries.Clear();

        if (File.Exists(fileName))
        {
            string json = File.ReadAllText(fileName);
            _entries = System.Text.Json.JsonSerializer.Deserialize<List<Entry>>(json);
        }
    }
}
