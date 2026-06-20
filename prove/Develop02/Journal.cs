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
}