using System;

class Program
{
    static void Main(string[] args)
    {
        // print scripture and reference
        // display menu options for user and get user input
        // run the input and either exit the program or run the word hider
        // pick random words to hide, convert the words in the words to hide list
        // into underscores for the quantity of characters
        // keep hiding words until all words are hidden
        // update the word bank to only include the words that are still visible
        // use dictionary with string and bool key value pairs to determine if word can
        // be used in the random words to hide list


        // create a list or dictionary to seperate multiple verses
        // figure out how to accept multiple verses and print them properly


        // ScriptureWords sw = new ScriptureWords();
        // sw.DisplayWordsInScripture();

        // Reference ref1 = new Reference("Alma", "12", 1, 5);
        // ref1.IterateThroughVerseRange();

        Reference ref1 = new Reference();
        ScriptureWords scripWords1 = new ScriptureWords();

        WordHider wh = new WordHider(scripWords1.CombineScriptureDictionaryWords());



        

        // write code to accept number of verses to add
        // and then run a loop that asks for verses to add


        scripWords1.AddNumbersToVerses(ref1.IterateThroughVerseRange());
        
        
    }
}