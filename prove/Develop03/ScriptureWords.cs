public class ScriptureWords
{

    private Dictionary<int, string> _scriptureVerseWordsDict = new Dictionary<int, string>();
    private List<string> _scriptureIndividualWordsList = new List<string>();


    public ScriptureWords()
    {
        _scriptureVerseWordsDict[1] = "Behold, I am Jesus Christ, whom the prophets testified shall come into the world.";
        _scriptureVerseWordsDict[2] = "And behold, I am the light and the life of the world; and I have drunk out of that bitter cup which the Father hath given me, and have glorified the Father in taking upon me the sins of the world, in the which I have suffered the will of the Father in all things from the beginning.";
    }

    public ScriptureWords(int numberOfVerses)
    {
        string scriptureWords;
        for (int number = 0; number < numberOfVerses; number++)
        {
            Console.WriteLine("Please put the words for the next verse to enter below:");
            scriptureWords = Console.ReadLine();
            _scriptureVerseWordsDict.Add(number, scriptureWords);
        }
    }

    private void CombineScriptureDictionaryWords(Dictionary<int, string> _scriptureVerseWordsDict, bool toLower = true, bool distinct = false)
    {
        foreach (var val in _scriptureVerseWordsDict.Values)
        {
            if (val == null) _scriptureIndividualWordsList.Add(string.Empty);
            else _scriptureIndividualWordsList.Add(val.ToLowerInvariant());
        }
    }

    public List<string> SendIndividualWordList()
    {   
        CombineScriptureDictionaryWords()
        return _scriptureIndividualWordsList;
    }

    private void AddNumbersToVerses()
    {
        List<int> verseNumbers;
        Reference ref1 = new Reference();

        verseNumbers = ref1.IterateThroughVerseRange();
        int verseNumbersCount = 0;

        foreach (KeyValuePair<int, string> dictLine in _scriptureVerseWordsDict)
        {
            int oldKey = dictLine.Key;
            string value = dictLine.Value;
            int newKey;
            newKey = verseNumbers[verseNumbersCount];
            verseNumbersCount += 1;
            _scriptureVerseWordsDict.Remove(oldKey);
            _scriptureVerseWordsDict[newKey] = value;
        }

    }
    
    public void DisplayWordsInScripture()
    {
        AddNumbersToVerses();
        foreach (KeyValuePair<int, string> dictLine in _scriptureVerseWordsDict)
        {
            Console.WriteLine($"{dictLine.Key} {dictLine.Value}");
        }    
    }

}