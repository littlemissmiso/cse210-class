public class PromptGenerator 
{
    public List<string> _prompts = new List<string>() {
        "How much do your current goals reflect your desires vs someone else's?",
        "The world would be a lot better if...",
        "What are small things people have done that really made your day?",
        "What biases do you need to work on?",
        "Imagine you arrive at a closed door. What does it look like, and what is on the other side?",
        "What do you wish you could do more quickly? More slowly?",
        "What made you feel most alive when you were young?",
        "Who is somebody you miss? Why?",
        "Why do you dress the way you do?",
        "What is a view about the world that has changed as you've gotten older?"
    };

    private Random randomPrompt = new Random();
    

    public string GetRandomPrompt() //Get a random index value, and look up string in _prompts//
    {
        int option = randomPrompt.Next(_prompts.Count);
        return _prompts[option];
    }
}