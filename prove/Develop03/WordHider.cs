// public class WordHider
// {
//     private List<string> _hiddenList; 
//     public WordHider()
//     {
//         Verse ether12 = new Verse();
//         List<string> text = ether12.getWords();
//         _hiddenList = HideWords(text, 5);
//     }

//     public List<string> returnHidden()
//     {
//         return _hiddenList;
//     }
//     public List<string> HideWords(List<string> WordList, int HiddenWords)
//     {
//         Random rnd = new Random();
//         for (int i = 0; i < HiddenWords; i++)
//         {
//             int randInt = rnd.Next(WordList.Count);
//             WordList.RemoveAt(randInt);
//             string blank = "______";
//             WordList.Insert(randInt, blank);
//         }
//         return WordList;
//     }
// }