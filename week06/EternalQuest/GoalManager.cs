using System.IO;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    
    public GoalManager()
    {

    }

    public void Start()
    {
        
         while (true)
        {
            _score = 0;

            Console.WriteLine();
            Console.WriteLine("----- Welcome to the Eternal Quest Program -----");
            Console.WriteLine();
            Console.WriteLine($"Current Score: {_score}");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create a new goal");
            Console.WriteLine(" 2. Display all goals");
            Console.WriteLine(" 3. Save goals");
            Console.WriteLine(" 4. Load goals");
            Console.WriteLine(" 5. Record event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string _choice = Console.ReadLine();
            Console.WriteLine();

            

            if (_choice == "1")
            {
                CreateGoal();
            }

            if (_choice == "2")
            {
                DisplayGoals();
            }

            if (_choice == "3")
            {
                SaveGoals();
            }

            if (_choice == "4")
            {
                LoadGoals();
            }

            if (_choice == "5")
            {
                RecordEvent();
            }

            if (_choice == "6")
            {
                Console.WriteLine("Have a nice day!");
                break;
            }
        }
    }

    public void DisplayGoals()
    {
        if (_goals.Count() > 0)
        {
            Console.WriteLine("Goal List:");

            int list = 1;
            
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{list}. {goal.GetDetailsString()}");
                list ++;
            }
        }
        
    }

    public void CreateGoal()
    {
        Console.WriteLine();
        Console.WriteLine("What kind of goal would you like to create?");
        Console.WriteLine("1. Simple Goal (one-time occurrence)");
        Console.WriteLine("2. Eternal Goal (long-term goal)");
        Console.WriteLine("3. Checklist Goal (multiple occurrences - frequency set by you)");
        Console.WriteLine("Please enter selection: ");

        string _selection = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Please enter the name of your goal: ");
        string name = Console.ReadLine();

        Console.WriteLine("Please enter a description of your goal: ");
        string description = Console.ReadLine();

        Console.WriteLine("Please enter the points associated with this goal: ");
        string points = Console.ReadLine();

        if (_selection == "1")
        {
            SimpleGoal _simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(_simpleGoal);

        }

        if (_selection == "2")
        {
            EternalGoal _eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(_eternalGoal);
        }

        if (_selection == "3")
        {
            Console.WriteLine("Please enter how many times you'd like to accomplish this goal: ");
            string _stringTarget = Console.ReadLine();
            int target = int.Parse(_stringTarget);

            Console.WriteLine("Please enter the bonus point amount: ");
            string _stringBonus = Console.ReadLine();
            int bonus = int.Parse(_stringBonus);

            ChecklistGoal _checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(_checklistGoal);
        }
    }

    public void RecordEvent()
    {
        DisplayGoals();
        Console.WriteLine("Which goal did you complete?");
        int _selection = int.Parse(Console.ReadLine());

        Console.WriteLine(_selection);

        
    }

    public void SaveGoals()
    {
        
            Console.WriteLine();
            Console.WriteLine("Please enter a filename: ");
            string filename = Console.ReadLine();
            Console.WriteLine();

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }       
        
    }

    public void LoadGoals()
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
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    string points = parts[3];
                    
                    if (type == "SimpleGoal")
                    {
                        Goal goal = new SimpleGoal(name, description, points);
                        _goals.Add(goal);
                    }

                    if (type == "EternalGoal")
                    {
                        Goal goal = new EternalGoal(name, description, points);
                        _goals.Add(goal);
                    }

                    if (type == "ChecklistGoal")
                    {
                        int target = int.Parse(parts[4]);
                        int bonus = int.Parse(parts[5]);

                        Goal goal = new ChecklistGoal(name, description, points, target, bonus);
                        _goals.Add(goal);
                    }
                    

                }
            }
        }
        
    }
   
