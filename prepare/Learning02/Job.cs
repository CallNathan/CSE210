using System;

public class Job
{
    public string _jobName;
    public string _companyName;
    public int _startYear;
    public int _endYear;
    public void printJob(){
        Console.WriteLine($"{_jobName} {_companyName} {_startYear}-{_endYear}");
    }

}