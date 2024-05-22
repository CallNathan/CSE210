using System;
using System.IO;

public class createEntry {
    public string _Prompt;
    public string _Content;
    public DateTime _Date;
    
    public createEntry(string prompt, string content) {
            _Prompt = prompt;
            _Content = content;
            _Date = DateTime.Now; 


    }
    public void DisplayEntry()
    {
        Console.WriteLine("Journal Entry:");
        Console.WriteLine("Date: " + _Date);
        Console.WriteLine("Prompt: " + _Prompt);
        Console.WriteLine("Content: " + _Content);
    }
}