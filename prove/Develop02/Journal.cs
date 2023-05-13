using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        // Add entry to the _entries list.
        _entries.Add(entry);
    }
    public void DisplayEntries()
    {
        // Store length of the _entries member list.
        int journalEntriesLength = _entries.Count;
        // If _entries is not an empty list, display each entry.
        if (journalEntriesLength != 0)
        {
            // Iterate through each entry and call the Display method
            // for each one.
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
        else
        {
            Console.WriteLine("Journal doesn't contain any entries.");
        }
    }
    public void LoadFromFile()
    {
        Console.Write("Enter your filepath: ");
        // Prompt user for filepath and store it in filePath.
        string filePath = Console.ReadLine();
        // Read all file lines into a lines list of strings.
        string[] lines = File.ReadAllLines(filePath);
        // Iterate through each line in the lines list and split
        // the data into entries.
        foreach (string line in lines)
        {
            // Instantiate new blank entry object to populate later.
            Entry newEntry = new Entry();
            // Split each line at -|- into parts.
            string[] lineParts = line.Split("-|-");
            // Part 1 is entry date.
            newEntry._date = lineParts[0];
            // Part 2 is entry prompt.
            newEntry._prompt = lineParts[1];
            // Part 3 is entry answer.
            newEntry._answer = lineParts[2];
            // Part 4 is the entry inspirational quote.
            newEntry._inspirationalQuote = lineParts[3];

            // Add entry into the _entries list.
            _entries.Add(newEntry);
        }
    }
    public void SaveToFile()
    {
        Console.Write("Enter your filepath: ");
        // Prompt user for a file path.
        string path = Console.ReadLine();
        // Open file for writing.
        using (StreamWriter filePath = new StreamWriter(path))
        {
            // Store _entries length.
            int journalEntriesLength = _entries.Count;

            if (journalEntriesLength != 0)
            {
                // Iterate through the list of entries and save its
                // data to the file.
                foreach (Entry entry in _entries)
                {
                    string date = entry._date;
                    string prompt = entry._prompt;
                    string answer = entry._answer;
                    string inspirationalQuote = entry._inspirationalQuote;

                    filePath.WriteLine($"{date}-|-{prompt}-|-{answer}-|-{inspirationalQuote}");
                }
            }
            else
            {
                Console.WriteLine("There are no entries in the journal!");
            }
        }
    }
}