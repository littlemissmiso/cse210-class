public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, string points) :base(name, description, points)
    {
        
    }


    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{ShowName()}|{ShowDescription()}|{ShowPoints()}";
    }

    public override string GetDetailsString()
    {
        return $"[ ] {ShowName()} - {ShowDescription()} ({ShowPoints()} points each occurrence)";
    }

    public override int RecordEvent()
    {
        return 0;
    }

    public override bool IsComplete()
    {
        return false;
    }
}