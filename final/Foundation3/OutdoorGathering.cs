public class Outdoorgathering : Event
{
    private string _weatherStatement;


     public Outdoorgathering(string title, string descritpion, DateTime date, string time, Address address, string weatherStatement) : base(title, descritpion, date, time, address)
     {
        this._weatherStatement = weatherStatement;
     }


    public override string GetFullDetails()
    {
        return base.GetFullDetails() + "\nType: Outdoor Gathering\nWeather: " + _weatherStatement; 
    }
}