public class Reception : Event
{
    private string _rsvpEmail;


    public Reception(string title, string descritpion, DateTime date, string time, Address address, string rsvpEmail) : base(title, descritpion, date, time, address)
    {
        this._rsvpEmail = rsvpEmail;
    }


    public override string GetFullDetails()
    {
        return base.GetFullDetails() + "\nType: Reception\nRSVP: " + _rsvpEmail;
    }

}