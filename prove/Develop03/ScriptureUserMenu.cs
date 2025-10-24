using System.ComponentModel;

public class ScriptureUserMenu
{
    private string _userChoice;
    private string _keepRunningChoice = "";

    public ScriptureUserMenu()
    {
        // write a menu that allows the user to enter in a new scripture
        // including the reference and words
        // also have the user pick between exiting the program and hiding more words
        Console.WriteLine("Welcome to the Scripture Memorizer!\n");

        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Use preloaded scripture");
        Console.WriteLine("2. Input your own scripture");
        Console.WriteLine("3. Exit Program");
        Console.Write("Please type the menu number of the option you have selected: ");

        _userChoice = Console.ReadLine();
        }

    public void RunUserChoice()
    {
        // write a for each loop using a number from the user
        // to determine how many times to run the add scripture to scripture
        // words dictionary
        switch (_userChoice)
        {
            case "1": // use preloaded scripture
                Reference ref1 = new Reference();
                ref1.DisplayReference();
                ScriptureWords scripWords = new ScriptureWords();
                scripWords.DisplayAllWordsInScripture();
                break;

            case "2": // user input scripture
                
                break;

            case "3": // exit program
                Environment.Exit(0);
                break;
        }
    }

    public void KeepRunningUntilNoMoreWords()
    {
        ScriptureWords scripWords1 = new ScriptureWords();
        WordHider wh = new WordHider();
        List<string> individualWordList = scripWords1.CombineScriptureDictionaryWords();

        while (_keepRunningChoice != "quit")
        {
            Console.WriteLine($"Press enter to hide words or type 'quit' to exit the program:");
            _keepRunningChoice = Console.ReadLine();
            _keepRunningChoice = _keepRunningChoice.ToLower();

            if (_keepRunningChoice == "")
            {
                List<string> wordsToHide = wh.PickWordsToHide(individualWordList);
                scripWords1.DisplayRemainingWordsInScripture(wordsToHide);

                // remove the hidden words from the available word list
                foreach (string word in wordsToHide)
                {
                    individualWordList.Remove(word);
                }

                if (scripWords1.CheckIfAllWordsAreHidden() == true)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}