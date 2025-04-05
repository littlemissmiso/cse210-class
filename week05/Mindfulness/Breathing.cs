public class Breathing : Activity
{
    public Breathing()
    {
        SetActivityName("Breathing");
        SetActivityDescription("This program will walk you through a series of timed breaths. Inhale and exhale when prompted. Focus on relaxation and steadiness.");
    }

    public void Run() 
    {
        DisplayStartMessage();
       
        SelectDuration();
        
        PauseBeforeStart();

        int inhaleTime = 6;
        int holdBreath = 4;
        int exhaleTime = 6;

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Thread.Sleep(1000);
            ShowCountDown("...Inhale...", inhaleTime);
            Console.WriteLine();
            ShowCountDown("...Hold breath...", holdBreath);
            Console.WriteLine();
            ShowCountDown("...Exhale...", exhaleTime);
            Console.WriteLine();
        }
        
        Console.WriteLine();
        Console.WriteLine($"Excellent work! You completed {_duration} seconds of the breathing activity. We hope you feel more relaxed.");
        Console.WriteLine("Press 'enter' to return to the menu.");
        Console.ReadLine();

    }
}
