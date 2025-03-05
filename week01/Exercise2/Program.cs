using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine();

        Console.Write("What is your grade percentage? ");
        int gradeNumber = int.Parse(Console.ReadLine());

        string letterGrade = "";
        
        if (gradeNumber >= 90) {
            letterGrade = "A";
        }
        else if (gradeNumber >=80) {
            letterGrade = "B";;
        }
        else if (gradeNumber >=70) {
            letterGrade = "C";;
        }
        else if (gradeNumber >=60) {
            letterGrade = "D";;
        }
        else if (gradeNumber <60) {
            letterGrade = "F";;
        }
        else {
            Console.WriteLine("Invalid entry. Please try again.");
        }

        Console.WriteLine($"Your grade is {letterGrade}.");

        if (gradeNumber >=70) {
            Console.WriteLine("You passed the class!");
        }
        else {
            Console.WriteLine("I'm sorry, you did not pass the class.");
        }
    }
}