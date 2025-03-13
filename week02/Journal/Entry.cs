public class Entry 
{
    public string _entryDate;
    public string _entryPrompt;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"{_entryDate} : {_entryPrompt}");
        Console.WriteLine(_entryText);
    }
}