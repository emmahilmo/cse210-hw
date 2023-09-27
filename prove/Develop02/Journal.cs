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
        
            string filename = "entry.txt";

            using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (Entry entries in _entries)
                    {
                        outputFile.WriteLine($"{entries._date}");
                        outputFile.WriteLine($"{entries._promptText}");
                        outputFile.WriteLine($"{entries._entryText}");
                    }
                }
        }

        public void LoadFromFile(string file)
        {
        }

}


