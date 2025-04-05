//For extra -- I added an extra method to the 'Activity' class. It is a 'pause before start', allowing the user to click enter before starting the program. 
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine();

        while (true)
        {

            Console.WriteLine();
            Console.WriteLine("----- Mindfulness Program -----");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string _choice = Console.ReadLine();
            Console.WriteLine();

            if (_choice == "1")
            {
                Breathing breathing1 = new Breathing();
                breathing1.Run();
            }

            else if (_choice == "2")
            {
                Reflection reflect1 = new Reflection();
                reflect1.Run();
            }

            else if (_choice == "3")
            {
                Listing list1 = new Listing();
                list1.Run();
            }

            else if (_choice == "4")
            {
                Console.WriteLine("Have a great day!");
                break;
            }
        }
    }
}