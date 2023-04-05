public class Lecture : Event
{
    private string _speaker;
    private string _capacity;

    public Lecture(string title, string descritpion, DateTime date, string time, Address address, string speaker, string capacity) : base(title, descritpion, date, time, address)
    {
        this._speaker = speaker;
        this._capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + "\nType: Lecture\nSpeaker " + _speaker + "\nCapacity: " + _capacity;
    }
}