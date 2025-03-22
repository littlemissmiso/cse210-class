using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("----- Scripture Memorizer Program -----");
        
        Console.WriteLine();

        Reference reference = new Reference("Mosiah", 24, 15);
        
        Scripture s1 = new Scripture(reference, "And now it came to pass that the burdens which were laid upon Alma and his brethren were made light; yea, the Lord did strengthen them that they could bear up their burdens with ease, and they did submit cheerfully and with patience to all the will of the Lord.");
        Console.WriteLine(s1.GetDisplayText());
        Console.ReadLine();

        //loop
            //display, hide, check if we need to quit
            //Use the function in the Scripture class
        
        while (true)
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("----- Scripture Memorizer Program -----");
            Console.WriteLine();
            
            Console.WriteLine(s1.GetDisplayText());
            Console.WriteLine();

            Console.WriteLine("Please press the 'enter' key to proceed, or type 'quit' to exit.");

            s1.HideRandomWords(5);            

            string endProgram = Console.ReadLine();

            if (endProgram == "quit")
            {
                break;
            }
        }
        

    }
}