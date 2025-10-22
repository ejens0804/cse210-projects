public class ScriptureWords
{
    // private string _scriptureWordsString;
    private Dictionary<string, int> _scriptureVerseWordsDict = new Dictionary<string, int>();
    private List<string> _scriptureIndividualWordsList = new List<string>();

    public ScriptureWords()
    {
        
    }











    public ScriptureWords()
    {
        _scriptureWordsString = "Behold, I am Jesus Christ, whom the prophets testified shall come into the world. (verse change) And behold, I am the light and the life of the world; and I have drunk out of that bitter cup which the Father hath given me, and have glorified the Father in taking upon me the sins of the world, in the which I have suffered the will of the Father in all things from the beginning.";
    }

    public ScriptureWords(string scriptureWords)
    {
        _scriptureWordsString = scriptureWords;
    }


    private List<string> ConvertScriptureStringToWordList(string scriptureWords)
    {
        return _scriptureWordsList;
    }

    public void DisplayWordsInScripture()
    {
        Console.WriteLine(_scriptureWordsString);
    }

    public void AddWordsToScripture()
    {

    }

    public void AddNumbersToVerses(List<int> verseNumbers)
    {
        foreach (int number in verseNumbers)
        {
            
        }

    }

}