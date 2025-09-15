using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    private List<string> _prompts = new List<string>
    {
        "What made you smile today?",
        "What challenge did you overcome today?",
        "How did someone show kindness to you today?",
        "What are you grateful for today?",
        "Describe a moment today where you felt peace."
    };

    private Random _random = new Random();

    public void WriteEntry()
    {
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your Response: ");
        string response = Console.ReadLine();

        Entry newEntry = new Entry(prompt, response);
        _entries.Add(newEntry);
    }

    public void DisplayJournal()
    {
        Console.WriteLine("\n--- Journal Entries ---\n");

        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
        }
        else
        {
            foreach (var entry in _entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.ToCsv());
            }
        }

        Console.WriteLine($"Journal saved to {filename}");
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                Entry entry = Entry.FromCsv(line);
                if (entry != null)
                {
                    _entries.Add(entry);
                }
            }

            Console.WriteLine($"Journal loaded from {filename}");
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
}
