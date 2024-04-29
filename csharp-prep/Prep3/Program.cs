using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        //string Snumber = "";
        string SGuess = "";
        int Guess = 0;
        //Console.Write("What is the magic number?");
        //Snumber = Console.ReadLine();
        //int number = int.Parse(Snumber);

        Random randomnumber = new Random();
        int number = randomnumber.Next(1,100);

        while (number != Guess) {
            Console.WriteLine("What is your guess?");
            SGuess = Console.ReadLine();
            Guess = int.Parse(SGuess);

            if (Guess > number) {
                Console.WriteLine("Lower");
            }
            else if (Guess < number) {
                Console.WriteLine("Higher");
            }
            else {
                Console.WriteLine("You Guessed it!");
            }
        }
        
    }
}