using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        int squareNumber;
        int birthYear = 0;
        DisplayWelcome();
        string Username = PromptUserName();
        int Usernumber = PromptUserNumber();
        PromptUserBirthYear(out birthYear);
        squareNumber = SquareNumber(Usernumber);
        DisplayResult(squareNumber, Username, birthYear);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your Username? ");
        string username = Console.ReadLine();
        return username;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int Usernumber = int.Parse(Console.ReadLine());
        return Usernumber;
    }
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("what year were you born? ");
        birthYear = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int userNumber)
    {
        int squareNumber = userNumber*userNumber;
        return squareNumber;
    }
    static void DisplayResult(int squareNumber, string Username, int birthYear)
    {
        int age = 2026-birthYear; 
        Console.WriteLine($"Your name is {Username}");
        Console.WriteLine($"Your Birthday is in {birthYear} and you'll be turning {age} years old");
        Console.WriteLine($"Your number squared is {squareNumber}");
    }
}

/* 
        For this assignment, write a C# program that has several simple functions:

        DisplayWelcome - Displays the message, "Welcome to the Program!"
        PromptUserName - Asks for and returns the user's name (as a string)
        PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        PromtUserBirthYear - Accepts out integer parameter and prompts the user for the year they were born. The out parameter is set to their birth year. This function does not return a value. The user's birth year is given back from the function via the out parameter.
        SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        DisplayResult - Accepts the user's name, the squared number, and the user's birth year. Display the user's name and squared number. Calculate hold many years old they will turn this year and display that.
        Your Main function should then call each of these functions saving the return values and passing data to them as necessary.
        */