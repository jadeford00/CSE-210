public abstract class Activity
{
    private double _pace;
    private  double _speed;
    private string _activityDate;
    private int _minutes;
    private double _distance;


    public Activity(double pace, double speed, string activityDate, int minutes, double distance)
    {
        _pace = pace;
        _speed = speed;
        _activityDate = activityDate;
        _minutes = minutes;
        _distance = distance;
    }

    public virtual double GetDistance()
    {
        return _distance;
    }

    public virtual double GetSpeed()
    {
        return _speed;
    }

    public virtual double GetPace()
    {
        return _pace;
    }

    public virtual int GetMinutes()
    {
        return _minutes;
    }
    
    public virtual string GetActivityDate()
    {
        return _activityDate;
    }

    public virtual string GetSummary()
    {
        return $"{GetActivityDate()} {GetType().Name} ({_minutes} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kpb, Pace: {GetPace()} min/km ";
    }
}