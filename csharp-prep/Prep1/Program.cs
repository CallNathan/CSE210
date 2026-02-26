using System;

class Program
{
    static void Main(string[] args)
    {
        String firstName = "";
        String lastName = "";
        Console.WriteLine("Hello Prep1 World!");

        Console.WriteLine("What is your first name?");
        firstName = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        lastName = Console.ReadLine();

        Console.Write("Your name is " + lastName + ", " + firstName + " " + lastName); 
    }
}