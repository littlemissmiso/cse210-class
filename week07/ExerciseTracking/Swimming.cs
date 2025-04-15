public class Swimming : Exercise
{
    private double _distanceSwim;
    public Swimming () : base()
    {
        
    }
    
    public override double GetDistance()
    {
        Console.WriteLine("How far did you swim? (in laps): ");
        _distance = double.Parse(Console.ReadLine());
        _distanceSwim = _distance * 50 / 1000 * 0.62;
        return _distanceSwim;
    }

    public override double GetSpeed()
    {
        Console.WriteLine("How much time did you spend swimming? (in minutes): ");
        _time = double.Parse(Console.ReadLine());
        _speed = (_distanceSwim / _time) * 60;
        return _speed;
    }

    public override double GetPace()
    {
        double _pace = _time / _distanceSwim;
        return _pace;
    }


    public override string GetSummary()
    {
        return $"{_date} | Swimming ({_time} min) - Distance {_distanceSwim} miles ({_distance} laps), Speed {_speed:F2} mph, Pace: {GetPace():F2} min per mile";
    }

}