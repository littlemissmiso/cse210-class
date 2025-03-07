using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        Console.WriteLine();

        DisplayWelcome();

        string personName = PromptUserName();
        int personNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(personNumber);

        DisplayResult(personName, squaredNumber);


        
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your full name: ");
            string fullName = Console.ReadLine();
            return fullName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

        static int SquareNumber(int userNumber)
        {
            int numberSquared = userNumber * userNumber;
            return numberSquared;     
            
        } 

        static void DisplayResult(string fullName, int numberSquared)
        {
            Console.WriteLine($"{fullName}, the square of your number is {numberSquared}.");
        }
    }
}