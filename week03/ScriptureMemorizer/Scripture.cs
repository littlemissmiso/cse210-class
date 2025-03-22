//Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text
using System.Runtime.CompilerServices;

public class Scripture 
{
    private Reference _reference;
    private List<Word> _words;
    

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
                
        _words = new List<Word>();
        
        //I need to split up the words in text and store each as a word object in the list _words
        //Split and then loop through each word, then create a word object and put it into _words

        string[] iterateScripture = text.Split(' ');
        foreach (string word in iterateScripture)
        {
            Word singleWord = new Word(word);
            _words.Add(singleWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        // set the state of a randomly selected group of words to be hidden
        // 1. Need to find a set of visible words
        // 2. Randomly select 'numbertohide' of those words (could use loops or if statements, etc)
        // 3. Use the Hide function
        List<Word> availableWords = new List<Word>();

        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                availableWords.Add(w);
            }
        }

        Random selection = new Random();
        List<Word> hiddenWords = new List<Word>();

        while (hiddenWords.Count < numberToHide)
        {
            int index = selection.Next(availableWords.Count);
            Word hideWord = availableWords[index];

            if (!hiddenWords.Contains(hideWord))
            {
                hideWord.Hide();
                hiddenWords.Add(hideWord);
            }
        }

        if (availableWords.Count == 0)     
        {
            return;
        }
    }

    public string GetDisplayText()
    {
        // Reference, ALL the words
        List<string> display = new List<string>();

        foreach (var w in _words)
        {
            string displayText = w.GetDisplayText();
            display.Add(displayText);
        }

        string _scriptureWords = string.Join(" ", display);
        return $"{_reference.GetDisplayText()}{_scriptureWords}";
    }

    
   
    

}