using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Console.WriteLine();

        Job job1 = new Job();

        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2018;
        job1._endYear = 2024;
        
        // job1.DisplayJobDetails();

        // Console.WriteLine();

        Job job2 = new Job();

        job2._company = "Google";
        job2._jobTitle = "Systems Analyst";
        job2._startYear = 2017;
        job2._endYear = 2021;
        
        // job2.DisplayJobDetails();
        // Console.WriteLine();

        /*RESUME SECTION*/
        Resume resume1 = new Resume();
        resume1._name = "McKenna Johnson";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();
        
    }
}