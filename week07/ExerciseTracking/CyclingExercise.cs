public class CyclingExercise : Exercise
{
    private double _speed;

    public CyclingExercise(double speed, string date, int duration) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        int duration = GetDuration();
        return (_speed * duration) / 60;
    }

    public override double GetPace()
    {
        return (60 / _speed);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetDuration()} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}