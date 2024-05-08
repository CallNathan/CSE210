using System;

class Program
{
    static void Main(string[] args)
    {
        string randomPrompt = "";
        Console.WriteLine("Hello Sandbox World!");
        randomPrompt = promptGenerator();
        List<string> entry = CreateEntry(randomPrompt);
        
    }
    //random output generator from list, should work well enough for a list of any length that isnt 0
    static string promptGenerator() 
    {
	    List<string> promptList = new List<string> //you can just declare a list directly if you have values you want to put in it beforehand
        {
        "Who was the most interesting person I interacted with today?",
	    "What was the best part of my day?",
	    "How did I see the hand of the Lord in my life today?",
	    "What was the strongest emotion I felt today?",
	    "If I had one thing I could do over today, what would it be?"
        };

	    Random rand = new();
	    int randomNumber = rand.Next(0, promptList.Count);
	    string randomPrompt = promptList[randomNumber];

	    //Console.WriteLine(randomPrompt);
        return randomPrompt;
    }
    static List<string> CreateEntry(string Prompt) 
    {
        List<string> entry = new();
        Console.WriteLine("What is todays date?");
        string date = Console.ReadLine();
        Console.WriteLine($"please write a response to the prompt {Prompt}");
        string response = Console.ReadLine();
        entry.Add(date);
        entry.Add(Prompt);
        entry.Add(response);

        //To print each line in a list of strings

        // foreach (string Item in entry) {
        //     Console.WriteLine(Item);
        // }
        

        return entry;
    }

}