public class Word()
{
    public List<string> _words;
    public List<string> _hiddenwords;
    public Boolean _hidden;

    public Boolean IsHidden(string isHidden)
    {
        Boolean used = false;

        foreach(string w in _hiddenwords)
        {
            if(w == isHidden)
            {
                used = true;
            }
            else
            {
                _hiddenwords.Add(isHidden);
            }
        }

        return used;
    }
    public Boolean AllHidden()
    {
        Boolean allHidden = false;
        if (_words.Count == _hiddenwords.Count)
        {
            allHidden = true;
        }

        return allHidden;
    }
}