public class SwimmingExercise : Exercise
{
    private int _lapLength = 50;
    private int _laps;

    public SwimmingExercise(int laps, string date, int duration) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return ((double)_laps * (double)_lapLength) / 1000;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        int duration = GetDuration();
        return (duration / distance);
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        int duration = GetDuration();
        return (distance / duration) * 60;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({_laps} laps) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}