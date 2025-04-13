public class ChecklistGoal : Goal 
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) :base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {ShowName()} - {ShowDescription()} ({ShowPoints()} points) - {ChecklistProgress()}/{ShowTarget()}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{ShowName()}|{ShowDescription()}|{ShowPoints()}|{ShowTarget()}|{ShowBonus()}";
    }

    public int ShowTarget()
    {
        return _target;
    }

    public int ShowBonus()
    {
        return _bonus;
    }

    public override int RecordEvent()
    {
        return 0;
    }

    public int ChecklistProgress()
    {
        return _amountCompleted;
    }

    public override bool IsComplete()
    {
        return false;
    }

}