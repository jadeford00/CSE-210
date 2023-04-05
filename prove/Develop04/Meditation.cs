using System;
using System.Threading;

public abstract class Meditation
{
    public abstract double Breath();

    public virtual void Quote()
    {
        Console.WriteLine("Relax and clear your mind");
    }
}