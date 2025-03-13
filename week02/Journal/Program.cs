using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("-------------------------------");
        string selection;
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

            if (selection == "1")
            {
               Entry entry1 = new Entry();
               entry1 = 
            }
            else if (selection == "2")
            {

            }
            else if (selection == "3")
            {

            }
            else if (selection == "4")
            {

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