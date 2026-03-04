using System;
using System.Runtime.CompilerServices;

public class Resume
{
    public string _name;
    public List<Job> _jobList = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Full Name: {_name}");
        foreach(Job fullJob in _jobList)
        {
            Console.WriteLine($"{fullJob._jobName} {fullJob._companyName} {fullJob._startYear}-{fullJob._endYear}");
        }
    }

}