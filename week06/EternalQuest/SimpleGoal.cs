public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) :base(name, description, points)
    {
         _isComplete = false;
    }


    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{ShowName()}|{ShowDescription()}|{ShowPoints()}";
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return 0;

    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
}