public class WordHider
{
    public WordHider() { }

    public List<string> PickWordsToHide(List<string> wordsToChooseFrom, int count = 10)
    {
        if (wordsToChooseFrom.Count == 0)
            return new List<string>();

        Random rndm = new Random();
        int wordsToPick = Math.Min(count, wordsToChooseFrom.Count);
        List<string> availableWords = new List<string>(wordsToChooseFrom);
        List<string> pickedWords = new List<string>();

        for (int i = 0; i < wordsToPick; i++)
        {
            int index = rndm.Next(availableWords.Count);
            pickedWords.Add(availableWords[index]);
            availableWords.RemoveAt(index);
        }
        return pickedWords;
    }
}








// public class WordHider
// {
//     private static readonly Random _random = new Random(); // Reuse Random instance
//     private List<string> _randomWordsToHide = new List<string>();

//     public List<string> PickWordsToHide(List<string> wordsToChooseFrom, int count = 5)
//     {
//         if (wordsToChooseFrom.Count == 0)
//             return new List<string>();

//         int wordsToPick = Math.Min(count, wordsToChooseFrom.Count);
        
//         // Use HashSet for O(1) lookup instead of copying entire list
//         HashSet<int> usedIndices = new HashSet<int>();
        
//         while (usedIndices.Count < wordsToPick)
//         {
//             int index = _random.Next(wordsToChooseFrom.Count);
//             if (usedIndices.Add(index)) // Only adds if not already present
//             {
//                 _randomWordsToHide.Add(wordsToChooseFrom[index]);
//             }
//         }
        
//         return _randomWordsToHide;
//     }
// }


