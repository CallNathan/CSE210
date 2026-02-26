using System;

class Program
{
    static void Main(string[] args)
    {
        string stringGrade;
        int Grade;
        string letterGrade = "";
        int lastDigitOfGrade;

        Console.WriteLine("Hello Develop02 World!");

        Console.Write("What is your Grade, rounding up.");
        stringGrade = Console.ReadLine();
        Grade = int.Parse(stringGrade);

        if (Grade < 60) {
            letterGrade = "F";
        }
        else if (Grade >=60 && Grade < 70) {
            letterGrade = "D";
        }
        else if (Grade >=70 && Grade < 80) {
            letterGrade = "C";
        }
        else if (Grade >=80 && Grade < 90) {
            letterGrade = "B";
        }
        else if (Grade >= 90) {
            letterGrade = "A";
        }
        else {
            Console.WriteLine("you didn't enter a valid grade it seems");
        }
        lastDigitOfGrade = Math.Abs(Grade % 10);

        if (lastDigitOfGrade >= 7 && letterGrade != "A") {
            letterGrade = letterGrade + "+";
        }
        else if (lastDigitOfGrade <= 3) {
            letterGrade = letterGrade + "-";
        }
        else {
            //Do nothing
        }
        
        Console.WriteLine($"A percent of {stringGrade} gets you a letter grade of {letterGrade}");
    }
}