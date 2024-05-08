using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new();
            job1._company = "Microsoft";
            job1._jobTitle = "Software Engineer";
            job1._startYear = 2019;
            job1._endYear = 2022;     

        Console.WriteLine(job1);    
    }
}