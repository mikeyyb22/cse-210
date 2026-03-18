// Keeps track of both the reference and text of scripture. 
// Hides words
// Gets rendered display of text

public class Scripture()
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        //TO DO - create list, split up words in text to create Word objects and put into list
    }

    // hide random words (public)
    public void HideRandomWords(int numberToHide)
    {
        
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