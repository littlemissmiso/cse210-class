//BONUS CONTENT//
//I added extra input options for a gratitude journal entry and a help entry. See rows 45-54//

using System;
using System.Collections.Generic;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("-------------------------------");
        string selection;

        Journal journal = new Journal();
        string filename = "";

        do 
        {
            Console.WriteLine("1. New Entry ");
            Console.WriteLine("2. Display All Entries ");
            Console.WriteLine("3. Save Journal Entry to a File ");
            Console.WriteLine("4. Load Journal File ");
            Console.WriteLine("5. Exit Program ");
            Console.Write("Please enter a menu number: ");
            selection = Console.ReadLine();
            Console.WriteLine();

            if (selection == "1") //Create an entry object to pass to the journal for storage//
            {
               Entry newEntry = new Entry();
               DateTime todayDate= DateTime.Today;
               newEntry._entryDate = todayDate.ToString("MM-dd-yyyy");

               PromptGenerator promptGenerator = new PromptGenerator();
               string randomPrompt = promptGenerator.GetRandomPrompt();
               newEntry._entryPrompt = randomPrompt;

               Console.WriteLine(newEntry._entryDate);
               Console.WriteLine($"Prompt: {randomPrompt}");
               Console.Write(">");
               newEntry._entryText = Console.ReadLine();

            //BONUS CONTENT//
               Console.WriteLine(newEntry._goodThing);
               Console.WriteLine("What is one good thing from today?");
               Console.Write(">");
               newEntry._goodThing = Console.ReadLine();

               Console.WriteLine(newEntry._helpThing);
               Console.WriteLine("What is one thing you wish you had help with today?");
               Console.Write(">");
               newEntry._helpThing = Console.ReadLine();
               Console.WriteLine();
            //BONUS CONTENT END (for this file)//

               journal.AddEntry(newEntry); 
               
            }

            else if (selection == "2")
            {
                journal.DisplayAll();
            }

            else if (selection == "3")
            {
                journal.SaveToFile(filename);
            }

            else if (selection == "4")
            {
                journal.LoadFromFile();
            }

            else if (selection == "5")
            {
                Console.WriteLine("Have a nice day!");
            }

            else
            {
                Console.WriteLine("Invalid entry. Please try again.");
            }

        }
        while (selection != "5");




            

        
    }
}