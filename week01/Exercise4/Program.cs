using System;
using System.Diagnostics.CodeAnalysis;
using System.Formats.Asn1;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine();

        int number = -1;
        List<int> numberList = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (number != 0) 
        { 
            Console.Write("Enter number: ");
            string stringNumber = Console.ReadLine();
            number = int.Parse(stringNumber);

            if (number != 0)
            {
                numberList.Add(number);
            }
        }

        int numberSum = 0;

        foreach (int num in numberList)
        {
            numberSum += num;
        }

        Console.WriteLine($"The total of the list is {numberSum}.");
      
        float average = ((float)numberSum) / numberList.Count;
        Console.WriteLine($"The average is: {average}");

        int maxNumber = numberList[0];

        foreach (int num in numberList)
        {
            if (num > maxNumber)
            {
                maxNumber = num;
            }
        }
        Console.WriteLine($"The max is: {maxNumber}");
    
    }
}
