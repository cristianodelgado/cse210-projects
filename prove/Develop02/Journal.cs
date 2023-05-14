using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries;
    public string loadFile;
    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            System.Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.Prompt},{entry.Response},{entry.Date}");
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        loadFile = File.ReadAllText(fileName);
        Console.WriteLine(loadFile);

        

    }
}
