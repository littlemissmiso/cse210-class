public class Reflection : Activity
{
    private List<string> _startingPrompt = new List<string>()
    {
        "Think of a time you chose kindness over being right.",
        "Thing of a time when you listened intently to someone.",
        "Think of a time you showed courage in a small way.",
        "Think of a time you made someone feel happy and included.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."
    };
    private List<string> _expoundingQuestions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like that before?",
        "How did you get started?",
        "What was your favorite thing about that experience?",
        "What did you learn about yourself during that experience?",
        "How did you feel after it was all over?",
        "Would you make the same choice if given the chance to do it over?",
        "What made that time different from other times things didn't go successfully?"
    };

    Random prompt = new Random();
    Random questions = new Random();


    public Reflection()
    {
        SetActivityName("Reflection");
        SetActivityDescription("This program is designed for mindful contemplation. Inspired by the prompt, think on times you have shown resilience and strength. This will help improve confidence and inner peace.");
    }

    public void Run()
    {
        DisplayStartMessage();
        Console.WriteLine();
        SelectDuration();

        Thread.Sleep(2000);
        
        DisplayPrompt();
        ShowTimerAnimation(5);
        PauseBeforeStart();

        List<int> usedQuestions = new List<int>();
        int _questions = 0;

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {  
            int availableList = questions.Next(_expoundingQuestions.Count);
                    
            if (!usedQuestions.Contains(availableList))
            {
                DisplayQuestions(availableList);
                Thread.Sleep(1000);
                ShowTimerAnimation(8);
                Console.WriteLine();
                usedQuestions.Add(availableList);
                 _questions++;
            }    
            
        }

        Console.WriteLine();
        DisplayEndMessage();
        Console.WriteLine("Press 'enter' to return to the menu.");
        Console.ReadLine(); 

    }

    public string GetRandomPrompt()
    {
        int randomPrompt = prompt.Next(_startingPrompt.Count);
        return _startingPrompt[randomPrompt];
    }

    public string GetRandomQuestion(int questionList)
    {
        return _expoundingQuestions[questionList];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine();
        Console.WriteLine($"---Prompt to Ponder---"); 
        Console.WriteLine($"'{GetRandomPrompt()}'");
    }

    public void DisplayQuestions(int questionList)
    {
        Console.WriteLine($"   >{GetRandomQuestion(questionList)}");
    }
}