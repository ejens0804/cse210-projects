public class ScriptureWords
{
    private string _scriptureWordsString;
    private List<string> _scriptureWordsList = new List<string>();

    public ScriptureWords()
    {
        _scriptureWordsString = "Behold, I am Jesus Christ, whom the prophets testified shall come into the world. (verse change) And behold, I am the light and the life of the world; and I have drunk out of that bitter cup which the Father hath given me, and have glorified the Father in taking upon me the sins of the world, in the which I have suffered the will of the Father in all things from the beginning.";
    }

    public ScriptureWords(string scriptureWords)
    {
        
    }


    private List<string> ConvertScriptureStringToWordList(string scriptureWords)
    {
        return _scriptureWordsList;
    }
    
    public void DisplayWordsInScripture()
    {
        Console.WriteLine(_scriptureWordsString);
    }



}