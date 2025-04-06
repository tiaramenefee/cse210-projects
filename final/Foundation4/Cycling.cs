public class Cycling : Activity
{
    private double _speedKph;

    public Cycling(string date, int minutes, double speedKph)
        : base(date, minutes)
    {
        _speedKph = speedKph;
    }

    public override double GetSpeed()
    {
        return _speedKph;
    }

    public override double GetDistance()
    {
        return (_speedKph * GetLengthMinutes()) / 60;
    }

    public override double GetPace()
    {
        return 60 / _speedKph;
    }
}