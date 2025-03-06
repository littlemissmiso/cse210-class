using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine();

        int magicNumber = 4;

        int numberGuess = -1;

        while (magicNumber != numberGuess) {

            Console.Write("Please guess the magic number: ");
            numberGuess = int.Parse(Console.ReadLine());

            if (numberGuess == magicNumber) {
                Console.WriteLine("Congratulations, you guessed it!");
                break;
            }
            else if (numberGuess > magicNumber) {
                Console.WriteLine("Lower.");
            }
            else {
                Console.WriteLine("Higher.");
            }

        }

        

    }
}