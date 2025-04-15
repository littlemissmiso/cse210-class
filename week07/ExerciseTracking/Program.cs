using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {        
        List<string> _activities = new List<string>();

        string _selection = "";

        while (_selection != "5")
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Exercise Tracking Program");
            Console.WriteLine();
            Console.WriteLine("----MENU----");
            Console.WriteLine("1. Running");
            Console.WriteLine("2. Stationary Bike");
            Console.WriteLine("3. Lap Swimming");
            Console.WriteLine("4. See Full Exercise Report");
            Console.WriteLine("5. Exit Program");
            Console.Write("Please enter your selection: "); 

            _selection = Console.ReadLine();

        
            if (_selection == "1")
            {
                Running _run = new Running();
                _run.GetDate();
                _run.GetDistance();
                _run.GetSpeed();
                _run.GetPace();

                string _runSummary = _run.GetSummary();
                _activities.Add(_runSummary);

                Console.WriteLine();
                Console.WriteLine("Exercise report added.");
                
            }

            if (_selection == "2")
            {
                Cycling _cycle = new Cycling();
                _cycle.GetDate();
                _cycle.GetDistance();
                _cycle.GetSpeed();
                _cycle.GetPace();

                string _cycleSummary = _cycle.GetSummary();
                _activities.Add(_cycleSummary);

                Console.WriteLine();
                Console.WriteLine("Exercise report added.");
            }

            if (_selection == "3")
            {
                Swimming _swim = new Swimming();
                _swim.GetDate();
                _swim.GetDistance();
                _swim.GetSpeed();
                _swim.GetPace();

                string _swimSummary = _swim.GetSummary();
                _activities.Add(_swimSummary);

                Console.WriteLine();
                Console.WriteLine("Exercise report added.");
            }

            if (_selection == "4")
            {
                foreach (string activity in _activities)
                {
                    Console.WriteLine();
                    Console.WriteLine(activity);
                } 
            }

            if (_selection == "5")
            {
                Console.WriteLine("Have a nice day!");
                break;
            }
    }
    }
}