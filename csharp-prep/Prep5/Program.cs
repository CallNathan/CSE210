using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        WelcomeMessage();
        string name = PromptName();
        int number = PromptFavoriteNumber();
        int square = SquareFavNumber(number);

        DisplayResults(number, name, square);

    }
    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the program");
    }
    static string PromptName()
    {
        Console.Write("What's your neme?");
        string name = Console.ReadLine();
        
        return name;
    }
    static int PromptFavoriteNumber()
    {
        Console.Write("What's your favorite number?");
        int FavNumber = int.Parse(Console.ReadLine());

        return FavNumber;
    }
    static int SquareFavNumber(int FavNumber) 
    {
        int SquareNumber = FavNumber*FavNumber;
        return SquareNumber;
    }

    static void DisplayResults(int Dnumber, string Dname, int Dsquare)
    {
        Console.WriteLine($"{Dname}, The square of your favorite number is {Dsquare}.");
    }
}