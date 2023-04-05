public class Swimming : Activity
{
    private double _pace;
    private  double _speed;
    private string _activityDate;
    private int _minutes;
    private double _distance;
    private int _laps;


    public Swimming(double pace, double speed, string activityDate, int minutes, double distance, int laps) : base(pace, speed, activityDate, minutes, distance)
    {
        _pace = pace;
        _speed = speed;
        _activityDate = activityDate;
        _minutes = minutes;
        _distance = distance;
        _laps = laps;   
    }


    public override double GetDistance()
    {
        return _laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return (_distance / _minutes) * 60.0;
    }

    public override double GetPace()
    {
        return _minutes / _distance;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $"{GetActivityDate()} Swimming ({_minutes} min) - Distance: {GetDistance()} laps, Speed: {GetSpeed()} kpb, Pace: {GetPace()} min/km ";
    }
}