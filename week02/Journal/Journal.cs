//BONUS CONTENT//
//I added extra input options for a gratitude journal entry and a help entry. See rows 22-24, 39, 62-63, and 68-69 //

using System.IO; 
using System.Collections.Generic;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry) /*Put newEntry into _entries*/
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll() /*Display all the entries in _entries list (loop) */
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine($"Date: {entry._entryDate} - Prompt: {entry._entryPrompt}");
            Console.WriteLine($"'{entry._entryText}'");
            
            Console.WriteLine($"GRATITUDE: {entry._goodThing}");
            Console.WriteLine($"HELP: {entry._helpThing}");
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename) //Loop through each item in _entries and save in a file//
    {
        Console.WriteLine("Saving to a file...");
        Console.WriteLine("Please enter a filename: ");
        filename = Console.ReadLine();
        Console.WriteLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine($"{entry._entryDate}|{entry._entryPrompt}|{entry._entryText}|{entry._goodThing}|{entry._helpThing}");
            }
        }       
    }

    public void LoadFromFile() //Loop through each line of the file and create Entry objects to put in the list//
    {
        Console.WriteLine("Please enter a filename: ");
        string filename = Console.ReadLine();
        Console.WriteLine();
        

        if (File.Exists(filename))
        {

            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                string entryDate = parts[0];
                string entryPrompt = parts[1];
                string entryText = parts[2];
                string goodThing = parts[3];
                string helpThing = parts[4];

                Console.WriteLine($"Date: {entryDate} - Prompt: {entryPrompt}");
                Console.WriteLine($"'{entryText}'");
                Console.WriteLine();
                Console.WriteLine($"One good thing from today: {goodThing}");
                Console.WriteLine($"One thing I need help with today: {helpThing}");
            }
        }
    }
}

