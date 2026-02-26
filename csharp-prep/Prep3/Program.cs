using System;


class Program
{
    static void Main(string[] args)
    {

        Random randomGen = new Random();

        int randomNumber = randomGen.Next(1,1000);
        string guess = "0";
        int guesses = 0;
        string again;
        string againNormal = "yes";

        Console.WriteLine("I have picked a random number between 1 and 1000. how long till you guess?");
        while (againNormal == "yes")
        {
        while (int.Parse(guess) != randomNumber) 
        {
            
            guesses ++;
            Console.WriteLine("What is your guess?  ");
            guess = Console.ReadLine();
            if (int.Parse(guess) < randomNumber)
            {
                Console.WriteLine("Nope, that's not it. You guessed too low.");
            }
            else if (int.Parse(guess) > randomNumber)
            {
                Console.WriteLine("Nope, you guessed too high. ");
            }

            else if (int.Parse(guess) == randomNumber)
            {
                Console.WriteLine($"You got it! very nice. It took you {guesses} tries.");
            }

            else {
                Console.WriteLine("an error has occured.");
            }
        }
        Console.WriteLine("want to play again? ");
        again = Console.ReadLine();
        againNormal = again.Trim().ToLower();
        }
    }

}