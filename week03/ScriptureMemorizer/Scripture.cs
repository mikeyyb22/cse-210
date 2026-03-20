// Keeps track of both the reference and text of scripture. 
// Hides words
// Gets rendered display of text

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    Random random = new Random();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        // Create list, split up words in text to create Word objects and put into list _words
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    // hide random words (public)
    public void HideRandomWords(int numberToHide)
    {
        int scriptureLength = _words.Count;
        int alreadyHidden = 0;
        bool fullyHidden = false;
        while (alreadyHidden < numberToHide)
        {
            fullyHidden = isCompletelyHidden();
            if (fullyHidden == true)
            {
                break;
            }
            else
            {
                int randomWord = random.Next(scriptureLength);
                Word wordToElim = _words[randomWord];
                if (wordToElim.IsHidden() == false)
                {
                    wordToElim.Hide();
                    _words[randomWord] = wordToElim;
                    alreadyHidden++;
                }
            }
        }
    }

    // get display text (public)
    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word word in _words)
        {
            string wordText = word.GetDisplayText();
            displayText += $"{wordText} ";
        }
        return displayText;
    }

    // check if scripture is completely hidden 
    public bool isCompletelyHidden()
    {
        int scriptureLength = _words.Count;
        int hiddenCounter = 0;
        foreach (Word word in _words)
        {
            bool hidden = word.IsHidden();
            if (hidden == true)
            {
                hiddenCounter++;
            }
        }
        if (hiddenCounter == scriptureLength)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}