public abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private string _time;
    private Address _address;


    public Event(string title, string descritpion, DateTime date, string time, Address address)
    {
        this._title = title;
        this._description = descritpion;
        this._date = date;
        this._time = time;
        this._address = address;
    }

    public string GetStandardDetails()
    {
        return "Title: " + _title + "\nDescription: " + _description + "\nDate: " + _date + "\nTime: " + _time + "Address: " + _address.GetAddress();
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    // public abstract double Get

    public virtual string GetShortDescription()
    {
        return "Type: Event\nTitle: " + _title + "\nDate: " + _date;
    }
}