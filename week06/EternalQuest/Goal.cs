public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public Goal(string name, string description, string points)
    {
        _name = name;
        _description = description;
        _points = int.Parse(points);
    } 

    public virtual string GetDetailsString()
    {
        //Should return the details of the goal that could be shown in a list. (include checkbox, name, description)
        //In the case of the checklist goal class, this should be overwritten to show the number of times the goal has been accomplished
        return $"[ ] {ShowName()} - {ShowDescription()} ({ShowPoints()} points)";
    }

    public string ShowName()
    {
        return _name;
    }

    public string ShowDescription()
    {
        return _description;
    }

    public int ShowPoints()
    {
        return _points;
    }

    //These below stay blank (get overidden in other classes)
    public abstract string GetStringRepresentation(); //This should provide all the details of the goal in a way that is easy to save to a file and load later

    public abstract int RecordEvent();
    
    public abstract bool IsComplete();
    
}