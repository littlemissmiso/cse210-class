public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 10;

    }

    public void SetActivityName(string name)
    {
        _name = name;
    }

    public void SetActivityDescription(string description)
    {
        _description = description;
    }

    public void SelectDuration()
    {
        Console.WriteLine(">How many seconds would you like to do the activity for? (example: 20, 30, 45)");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    
    public void DisplayStartMessage()
    {
        Console.WriteLine($"-----Welcome to the {_name} activity.-----");
        Console.WriteLine();
        Console.WriteLine($"{_description}");

    }

    public void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Congratulations, you completed the {_name} activity. We hope you feel happier. :)");
        Console.WriteLine();
    }

    public void PauseBeforeStart()
    {
        Console.WriteLine();
        Console.WriteLine("Ready?");
        Console.Write("Please press 'enter' to begin.");
        Console.ReadLine();
        Console.WriteLine();
    }

    public void ShowTimerAnimation(int animationTime)
    {
        DateTime _animationPause = DateTime.Now.AddSeconds(animationTime);

        while (DateTime.Now < _animationPause)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }

    }

    public void ShowCountDown(string breath, int second)
    {
        Console.WriteLine($"{breath}");
        Thread.Sleep(1000);
        DateTime endTime = DateTime.Now.AddSeconds(second);
        
        while (DateTime.Now < endTime)
        {
            int remaining = (int)(endTime - DateTime.Now).TotalSeconds;
            Console.Write($"\r{remaining}");
            Thread.Sleep(1000); 
        }
    }
}