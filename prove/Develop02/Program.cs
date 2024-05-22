using System;
using System.Net.Mime;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<string> promptList = new List<string> //you can just declare a list directly if you have values you want to put in it beforehand
            {
                "Who was the most interesting person I interacted with today?",
	            "What was the best part of my day?",
	            "How did I see the hand of the Lord in my life today?",
	            "What was the strongest emotion I felt today?",
	            "If I had one thing I could do over today, what would it be?"
            };
        PromptGenerator promptGenerator = new PromptGenerator(promptList);
        string prompt = promptGenerator.GetRandomPrompt();

        Console.WriteLine("prompt: " + prompt);
        string content = Console.ReadLine();

        createEntry CreateEntry = new createEntry(prompt, content);

        CreateEntry.DisplayEntry();
        Console.WriteLine("Save entry? Y or N");
        string save = Console.ReadLine();
        if (save == "Y") {
            string journal = "journal.txt";
            using (StreamWriter outputFile = new StreamWriter(journal, true)) 
            {
                outputFile.WriteLine(""); //just to put a line spacing between each new entry
                outputFile.WriteLine("Journal Entry:");
                outputFile.WriteLine($"Date: {DateTime.Now}");
                outputFile.WriteLine($"Prompt: {prompt}");
                outputFile.WriteLine($"Content: {content}");
            }
        }
        else {
            Console.WriteLine("It is generally a good idea to save your journals to preserve your state of mind.");
        }
        Console.WriteLine("Would you like to read past entries? Y or N");
        string answer = Console.ReadLine();
        if (answer == "Y") {
            string journal = "journal.txt";
            using (StreamReader inputFile = new StreamReader(journal)) {
                string reading = inputFile.ReadToEnd();
                Console.WriteLine(reading);
            }
        }
        else {
            Console.WriteLine("Okay");
        }
    }
    //random output generator from list, should work well enough for a list of any length that isnt 0
//     static List<string> CreateEntry(string Prompt) 
//     {
//         List<string> entry = new();
//         Console.WriteLine("What is todays date?");
//         string date = Console.ReadLine();
//         Console.WriteLine($"please write a response to the prompt {Prompt}");
//         string response = Console.ReadLine();
//         entry.Add(date);
//         entry.Add(Prompt);
//         entry.Add(response);

//         //To print each line in a list of strings

//         // foreach (string Item in entry) {
//         //     Console.WriteLine(Item);
//         // }
        

//         return entry;
//     }

 }