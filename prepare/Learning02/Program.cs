using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobName = "software engineer";
        job1._companyName = "microsoft";
        job1._startYear = 1987;
        job1._endYear = 2026;

        job1.printJob();

        Job job2 = new Job();
        job2._jobName = "developer";
        job2._companyName = "apple";
        job2._startYear = 2002;
        job2._endYear = 2026;

        job2.printJob();

        Resume newResume = new Resume();

        newResume._name = "nathan call";
        newResume._jobList.Add(job1); 
        newResume._jobList.Add(job2); 

        Console.WriteLine($"{newResume._jobList[1]._companyName}");

        newResume.Display();
    }
}