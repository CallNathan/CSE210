using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        string letter = "";
        Console.Write("What is your grade percent?");
        string stringGrade = Console.ReadLine();
        int grade = int.Parse(stringGrade);
        if (grade >= 90)
        {
            letter = "A";
        } 
        else if (grade < 90 && grade >= 80) {
            letter = "B";
        }
        else if (grade < 80 && grade >= 70) {
            letter = "C";
        }
        else if (grade < 70 && grade >= 60) {
            letter = "D";
        }
        else {
            letter = "F";
        }
        Console.WriteLine($"You got a {letter} grade.");
        
        if (grade >= 70) {
            Console.WriteLine("You passed!");
        }
        else {
            Console.WriteLine("sorry, better luck next time.");
        }
    }
}