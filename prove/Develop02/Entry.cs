public class Entry
{
    public Random random = new Random();
    public string _date;
    public string _prompt;
    public string _response;
    public string _thoughts;
    private DateTime date = DateTime.Now;
    public void Load(){

        //System.IO.File.ReadAllLines();
    }
    public string GetPrompt() {
        int randomIndex = random.Next(0, Journal._prompts.Count);
        Console.WriteLine(Journal._prompts[randomIndex]);
        _date =  date.ToString(); //datetime to string was aquired from this source https://learn.microsoft.com/en-us/dotnet/api/system.datetime.tostring?view=net-10.0
        Console.WriteLine(_date);

        return (Journal._prompts[randomIndex]);
    }
    
};