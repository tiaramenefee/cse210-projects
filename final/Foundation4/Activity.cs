public abstract class Activity
{
    private string _date;
    private int _lengthMinutes;

    public Activity(string date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public int GetLengthMinutes()
    {
        return _lengthMinutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public abstract double GetDistance(); // in kilometers
    public abstract double GetSpeed();    // in km/h
    public abstract double GetPace();     // in min/km

    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_lengthMinutes} min) - " +
               $"Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
    }
}