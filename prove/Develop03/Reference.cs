public class Reference()
{
    public string _book;
    public string _passage;
    public int _chapter;
    public int _verse;

    



    public List<string> SplitVerse()
    {
        List<string> verse = new();
        string[] splitVerse = _passage.Split(" ");
        foreach(string word in splitVerse)
        {
            verse.Add(word);
        }
        return verse;
    }
    public void DisplayVerse()
    {
        Console.WriteLine($"{_book} {_chapter}: {_verse} {_passage}");
    }
    public void DisplayVerseMin()
    {
        Console.Write($"{_book} {_chapter}: {_verse} ");
    }

    /*public string getReference()
    {
        string savedBook = "you didn't save anything";
        string pick = "";
        Boolean repeat = true;
        while (repeat == true){
            Console.WriteLine("We have several books to choose from, pick one: ");
            Console.WriteLine("1. Old Testament");
            Console.WriteLine("2. New Testament");
            Console.WriteLine("3. Book of Mormon");
            Console.WriteLine("4. Doctrine and Covenants");
            Console.Write("Please enter a number: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                repeat=false;
                pick = "Old Testament";
            }
            else if (choice == 2)
            {
                repeat = false;
                pick = "New Testament";
            }
            else if (choice == 3)
            {
                repeat = false;
                pick = "Book Of Mormon";
            }
            else if (choice == 4)
            {
                repeat = false;
                pick = "Doctrine And Covenants";
            }
            else
            {
                Console.WriteLine("please enter a value 1-4");
            }

        }
        string filename = "Scriptures.txt";
        string file = System.IO.File.ReadAllText(filename);
        string[] books = file.Split("***");
        
        foreach(string book in books)
        {
            string[] splitter = book.Split("%%");
            if( splitter[0]== pick)
            {
                int verseIndex = 0;
                
                Console.WriteLine("We have multiple verses available in that book pick one: ");
                string[] littleBooks = book.Split("||");
                foreach(string littleBook in littleBooks)
                {
                    verseIndex++;
                    splitter = littleBook.Split("&&&");
                    Console.WriteLine($"{verseIndex}: {splitter[0]}");
                    Console.WriteLine("Pick this verse?");
                    Console.WriteLine("1: Yes, 2: No");
                    if (int.Parse(Console.ReadLine()) == 1)
                    {
                        savedBook = book;
                        break;
                    }
                }
                
            }
            else
            {
                Console.WriteLine("cry");
            }
        }

        return savedBook;
    }*/
}