public class Scripture()
{
    public List<string> _words;
    public List<Word> _removedWords;
    
    private Random random = new();


    public void RemoveWord()
    {
        int randomIndex = 0;
        int i = 0;

        while (i != 5){
            i++;
            int maxIndex = _words.Count();
            randomIndex = random.Next(0, maxIndex);
            Word word = new();
            word._words = _words;
            Boolean used = word.IsHidden(_words[randomIndex]);
            Boolean allHidden = word.AllHidden();
            if(allHidden == true) {
                break;
            }
            else if (used == false)
            {
                _words[randomIndex]="____ ";
            }
            else
            {
                i--;
            }
        }


    }
    public void DisplayRender()
    {
        foreach(string word in _words)
        {
            Console.Write($"{word} ");
        }
    }
}