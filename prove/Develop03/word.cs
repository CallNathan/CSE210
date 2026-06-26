public class Word()
{
    public List<string> words;
    public Dictionary<int, string> removedWords;
    private int maxIndex = 0;
    private Random _random = new Random();
    private int randomIndex;

    public void RemoveWord()
    {
        maxIndex = words.Count();
        randomIndex = _random.Next(0, maxIndex);
        string removedWord = words[randomIndex];
        removedWords.Add(randomIndex, removedWord);
        words.RemoveAt(randomIndex); 

    }
    
}