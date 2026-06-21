using System.Runtime.InteropServices;

public class Journal()
{
    private DateTime date = DateTime.Now;
    public List<Entry> _entries = new List<Entry>();
    public static List<string> _prompts = [
        "Who was the most interesting person I met today?",
        "What was the best part of my day?",
        "How did i see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did I find easy to do today?",
        "Was I kind to someone today? How was I kind?",
        "What do I plan to do tomorrow?",
    ]; //I got static from this source since i needed a static list apperently. https://stackoverflow.com/questions/19393481/c-sharp-initialize-a-static-list-in-a-class

    public void NewEntry()
    {
        Entry newEntry = new Entry();
        newEntry._date = date.ToString(); //datetime to string was aquired from this source https://learn.microsoft.com/en-us/dotnet/api/system.datetime.tostring?view=net-10.0
        newEntry._prompt = newEntry.GetPrompt();
        Console.Write("Please give your response to the prompt: ");
        newEntry._response = Console.ReadLine();
        Console.WriteLine("Any Additional Thoughts? Write them now.");
        newEntry._thoughts = Console.ReadLine();
        _entries.Add(newEntry);
    }

    public void Display()
    {
        foreach(Entry entry in _entries)
        {
            Console.WriteLine("Date: " + entry._date);
            Console.WriteLine("Prompt: " + entry._prompt);
            Console.WriteLine("Response: " + entry._response);
            Console.WriteLine("Additional Thoughts: " + entry._thoughts);
            Console.WriteLine("Press Enter to see next entry.");
            Console.ReadLine();

        }
    }
    public void Save()
    {
        string filename = "backup.txt";
        Console.WriteLine("Please enter a file name. (something like Name.txt)");
        
        filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine("Journal");
            outputFile.WriteLine("|");
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"Date,: {entry._date}*");
                outputFile.WriteLine($"Prompt,: {entry._prompt}*");
                outputFile.WriteLine($"Response,: {entry._response}*");
                outputFile.WriteLine($"Additional Thoughts,: {entry._thoughts}*");
                outputFile.WriteLine("|");
            }
        }
    }
    public void Load()
    {
        
        string filename = "Test.txt";
        Console.WriteLine("Please enter the full filename of the file you want to load.");
        filename = Console.ReadLine();

        string file = System.IO.File.ReadAllText(filename); 

        //Console.WriteLine(file);
        
        
        string[] journal = file.Split("|");

        foreach(string section in journal)
        {
            if(section == "" || section=="\r\n")
            {
                //do nothing
            }
            else 
            {
                Entry loadEntry = new Entry();
                Console.WriteLine("");
                //Console.WriteLine(section);
                string[] lines = section.Split("*");
                int index = 0;
                foreach(string line in lines)
                {
                    if(index == 0)
                    {
                        string newString = line.Remove(0,7);  //source for this was gotten from https://www.codecademy.com/resources/docs/c-sharp/strings/remove
                        loadEntry._date=newString;
                        //Console.WriteLine(loadEntry._date);
                    }
                    else if (index == 1)
                    {
                        string newString = line.Remove(0,10);
                        loadEntry._prompt=newString;
                        //Console.WriteLine(loadEntry._prompt);

                    }
                    else if (index == 2)
                    {
                        string newString = line.Remove(0,12);
                        loadEntry._response=newString;
                        //Console.WriteLine(loadEntry._response);

                    }
                    else if (index == 3)
                    {
                        string newString = line.Remove(0,23); 
                        loadEntry._thoughts=newString;
                        //Console.WriteLine(loadEntry._thoughts);

                    }
                    else if (index ==4 )
                    {
                        _entries.Add(loadEntry);
                    }
                    else
                    {
                        //Panic
                    }
                    index++;
                    
                }
                
            }
            
        }
            
        Console.WriteLine("File Loaded Successfully");
        /*foreach(Entry entry in _entries)
        {
            Console.WriteLine($"Date: " + entry._date);
            Console.WriteLine($"Prompt: " + entry._prompt);
            Console.WriteLine($"Response: " + entry._response);
            Console.WriteLine($"Additional Thoughts: {entry._thoughts}");
            Console.WriteLine("Press Enter to see next entry.");
            Console.ReadLine();

        }*/
        //The above block was used to verify Load was correctly loading entries. It is no longer needed.
        
    }
    
}