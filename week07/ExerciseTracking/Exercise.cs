using System.Runtime.InteropServices;

public abstract class Exercise
{
    private string _date;
    private int _duration;

    public Exercise(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public abstract string GetSummary();

}