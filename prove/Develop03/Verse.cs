public class Verse
{
    private string _text = "And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that faith is things which are hoped for and not seen; wherefore, dispute not because ye see not, for ye receive no witness until after the trial of your faith.";
    private string _reference = "Ether 12:6";
    private string[] _wordArray;
    private List<string> _wordList = new List<string>();
    private List<string> _hideList = new List<string>();

    public Verse()
    {
        ParseVerse(_text);
    }

    public List<string> getWords()
    {   
        if (_hideList.Count == 0)
        {
            return _wordList;
        }

        else
        {
            return _hideList;
        }
    }

    public List<string> hideWords()
    {
        WordHider hide1 = new WordHider();
        List<string> words = hide1.returnHidden();
        _wordList = words;
        return _wordList;
    }

    private void ParseVerse(string text)
    {
        _wordArray = text.Split(" ");
        _wordList = _wordArray.ToList();
    }

    public void DisplayVerse()
    {
        if (_hideList.Count == 0)
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
            foreach (string word in _hideList)
            {
                Console.Write(word);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    public void UpdateVerse(List<string> newList)
    {
        _hideList = newList;
    }
}
