public class RunningExercise : Exercise
{
    private double _distance;

    public RunningExercise(double distance, string date, int duration) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        int duration = GetDuration();
        return duration / _distance;
    }

    public override double GetSpeed()
    {
        double pace = GetPace();
        return 60 / pace;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetDuration()} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}