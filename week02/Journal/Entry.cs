//BONUS CONTENT//
//I added extra input options for a gratitude journal entry and a help entry. See rows 11-12, 19-20 //

public class Entry 
{
    public string _entryDate;
    public string _entryPrompt;
    public string _entryText;


    public string _goodThing;
    public string _helpThing;

    public void Display()
    {
        Console.WriteLine($"{_entryDate} : {_entryPrompt}");
        Console.WriteLine(_entryText);

        Console.WriteLine($"One good thing from today: {_goodThing}");
        Console.WriteLine($"One thing I need help with today: {_helpThing}");
    }
}