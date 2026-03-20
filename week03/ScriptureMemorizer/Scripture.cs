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
        for (int i = 1; i <= numberToHide; i++)
        {
            int randomWord = random.Next(scriptureLength);
            Word wordToElim = _words[randomWord];
            // if (wordToElim.IsHidden() == true)
            // {

            // }
        }
    }

    // get display text (public)
    public string GetDisplayText()
    {
        return "";
    }

    // check if scripture is completely hidden (private)
    private bool isCompletelyHidden()
    {
        return false;
    }
}