using System.Diagnostics;

public class Running : Exercise
{
    
    public Running () : base()
    {
        
    }
    
    public override double GetDistance()
    {
        Console.WriteLine("How far did you run? (in miles): ");
        _distance = double.Parse(Console.ReadLine());
        return _distance;
    }

    public override double GetSpeed()
    {
        Console.WriteLine("How much time did you spend running? (in minutes): ");
        _time = double.Parse(Console.ReadLine());
        _speed = (_distance / _time) * 60;
        return _speed;
    }

    public override double GetPace()
    {
        double _pace = _time / _distance;
        return _pace;
    }


    public override string GetSummary()
    {
        return $"{_date} | Running ({_time} min) - Distance {_distance} miles, Speed {_speed:F2} mph, Pace: {GetPace():F2} min per mile";
    }
}