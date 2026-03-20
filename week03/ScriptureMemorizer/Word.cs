// Keeps track of a single word and whether it's shown or hidden

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        char[] characters = _text.ToCharArray();
        for (int i = 0; i < characters.Length; i++)
        {
            characters[i] = '_';
        }
        _text = new string(characters);
    }

    public void Show()
    {

    }

    public bool IsHidden()
    {
        return false;
    }

    public string GetDisplayText()
    {
        return _text;
    }
}