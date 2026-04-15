public class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetDate() => _date;
    public int GetMinutes() => _minutes;

    // Virtual methods (will be overridden)
    public virtual double GetDistance() { return 0; }
    public virtual double GetSpeed() { return 0; }
    public virtual double GetPace() { return 0; }

    public virtual string GetSummary()
    {
        return $"{_date} ({_minutes} min) - Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace {GetPace():0.0} min/km";
    }
}