public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public int GetTop()
    {
        return 1;
    }
    public void SetTop()
    {

    }
    public int GetBottom()
    {
        return 1;
    }
    public void SetBottom()
    {

    }
    public string GetFractionString()
    {
        return "";
    }
    public double GetDecimalValue()
    {
        return 1.0;
    }
}