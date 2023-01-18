using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Google";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2021;
        Console.WriteLine(job1._company);

        Job job2 = new Job();
        job2._company = "Amazon";
        job2._jobTitle = "Software Engineer Dev";
        job2._startYear = 2022;
        job2._endYear = 2023;
        Console.WriteLine(job2._company);

        Resume myResume = new Resume();
        myResume._name = "Jonas Nunn";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}