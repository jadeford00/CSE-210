public abstract class Meditation
{
    private int _duration;

    public Meditation(int duration)
    {
        _duration = duration;
    }
    
    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    // public void SetDuration(int duration)
    // {   
    //     _duration = duration;
    //     Console.WriteLine("How long would you like to do this activity? ");
    //     string input = Console.ReadLine();
    // }

    public abstract double DisplayStarting();
 
    public abstract double DisplayEnding();

} 


    //       public int DisplayDuration()
    // {
    //     Console.WriteLine("How long would you like to do this activity? ");
    //     string input = Console.ReadLine();

    //     for (int i = _duration; i > 0; i--)
    //     {
    //         Console.WriteLine(i);
    //         Thread.Sleep(1000);
    //     }
    // }