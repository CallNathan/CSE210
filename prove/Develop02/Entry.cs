public class Entry
{
    public Random random = new Random();
    public string _date;
    public string _prompt;
    public int _response;
    public int _thoughts;
    
    public void Load(){

        //System.IO.File.ReadAllLines();
    }
    public void GetPrompt() {
        
        int loop = 0;
        while (loop != 10) {
            int randomIndex = random.Next(0, Journal._prompts.Count);
            Console.WriteLine(Journal._prompts[randomIndex]);
            loop = loop + 1;
        }
    }
};