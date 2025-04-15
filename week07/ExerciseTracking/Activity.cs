using System.Diagnostics;

public abstract class Exercise
{
    protected double _distance;
    protected double _speed;
    protected double _time;
    protected string _date;
    

    public Exercise()
    {
        _distance = 0;
        _speed = 0;
        _time = 0;
    }
    public string GetDate()
    {
        Console.WriteLine();
        Console.WriteLine("Please enter the date of your exercise (mm/dd/yyyy):");
        _date = Console.ReadLine();
        return _date;
    }


    public abstract double GetDistance();
    
    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"";
    }
}