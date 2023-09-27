using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry>_entries;
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

        public void SaveToFile(string file)
        {
            Console.WriteLine("Saving File.......");
        }

        public void LoadFromFile(string file)
        {
            foreach (Entry entries in _entries)
            {
                Console.WriteLine($"{entries.date},{entries.PromptText},{entries.EntryText}");  
            }
        }


    }


