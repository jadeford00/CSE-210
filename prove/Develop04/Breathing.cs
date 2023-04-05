public class Breathing : Meditation
{
    private double _startingMessage;
    private double _endingMessage;

    public Breathing(int duration, double startingMessage, double endingMessage) : base (duration)
    {
        _startingMessage = startingMessage;
        _endingMessage = endingMessage;
    }
    public override double DisplayStarting()
    {
        return _startingMessage;
    }

    public override double DisplayEnding()
    {
        return _endingMessage;
    }
}