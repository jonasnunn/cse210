public class Verse
{
    private string _text = "And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that faith is things which are hoped for and not seen; wherefore, dispute not because ye see not, for ye receive no witness until after the trial of your faith.";
    private string _reference = "Ether 12:6";
    private string[] _wordArray;
    private List<string> _wordList = new List<string>();
    private List<string> _hidenList = new List<string>();

    public Verse()
    {
    
    }

    public List<string> hideWords(List<string> WordList)
    {
        Random rnd = new Random();
        for (int i = 0; i < 5; i++)
        {
            int randInt = rnd.Next(WordList.Count);
            WordList.RemoveAt(randInt);
            string blank = "______";
            WordList.Insert(randInt, blank);
        }
        return WordList;
    }

    public void ParseVerse(string text)
    {
        _wordArray = text.Split(" ");
        _wordList = _wordArray.ToList();
    }

    public void DisplayVerse()
    {
        if (_hidenList.Count == 0)
        {
            Console.Clear();
            Console.WriteLine(_reference);
            foreach (string word in _wordList)
            {
                Console.Write(word);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.Clear();
            Console.WriteLine(_reference);
            foreach (string word in _hidenList)
            {
                Console.Write(word);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    public void UpdateVerse(List<string> newList)
    {
        _hidenList = newList;
    }
}
