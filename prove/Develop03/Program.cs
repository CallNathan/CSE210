using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference();
        reference._passage= "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        reference._book="1st Nephi";
        reference._chapter= 3;
        reference._verse= 7;

        /*string savedReference = test.getReference();
        Console.WriteLine(savedReference);
        string[] splitReference = savedReference.Split("&&&");
        test._book=splitReference[0];
        test._verse=splitReference[1];*/ //omitted as it doesn't work and i will return to it if i have time

        Scripture scripture = new Scripture();
        scripture._words = reference.SplitVerse();
        Console.Clear();

        Boolean keepGoing = true;
        Console.WriteLine("Welcome to scripture memorizer.");
        //reference.DisplayVerse();
        //Console.WriteLine("Pick a scripture")
        while (keepGoing==true){
            reference.DisplayVerseMin();
            scripture.DisplayRender();
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish");
            string decision = Console.ReadLine();
            if (decision != "quit")
            {
                Console.Clear();
                scripture.RemoveWord();
            }
            else
            {
                keepGoing = false;
            }
        }
        
        
    }
}