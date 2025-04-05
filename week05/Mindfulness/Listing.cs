public class Listing : Activity
{
    
    private List<string> _prompts = new List<string>() {

        "What are the most beautiful things you can think of?",
        "What could you happily lose track of time doing?",
        "What makes you smile?",
        "If you could make anything better right now in the world, what would it be?",
        "Who are people you have helped this week?",
        "What are good things about you?"
    }; 
    Random prompt = new Random();

    public Listing()
    {
        SetActivityName("Listing");
        SetActivityDescription("This program is designed to be like a gratitude journal. List as many good things as you can that relate to the prompt within the selected time frame.");
    }
    
    public void Run()
    {
        DisplayStartMessage();

        Console.WriteLine();
        SelectDuration();

        Thread.Sleep(1000);
        
        Console.WriteLine();        
        Console.WriteLine("---Prompt---");
        Console.WriteLine(GetRandomPrompt());

        Thread.Sleep(1000);
        PauseBeforeStart();
      
        int _entries = 0;

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.ReadLine(); 
            _entries++;
        }

        Console.WriteLine();
        DisplayEndMessage();
        Console.WriteLine($"You entered {_entries} responses in {_duration} seconds.");
        Console.WriteLine("Press 'enter' to return to the menu.");
        Console.ReadLine();    
        
    }

    public string GetRandomPrompt()
    {
        
        int randomPrompt = prompt.Next(_prompts.Count);
        return _prompts[randomPrompt];
        
    }

    
}