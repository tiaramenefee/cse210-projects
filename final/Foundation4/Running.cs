public class Running : Activity
{
    private double _distanceKm;

    public Running(string date, int minutes, double distanceKm)
        : base(date, minutes)
    {
        _distanceKm = distanceKm;
    }

    public override double GetDistance()
    {
        return _distanceKm;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetLengthMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetLengthMinutes() / GetDistance();
    }
}