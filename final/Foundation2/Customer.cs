public class Customer
{
    public string _customerName;
    private Address address;

    public Customer(string customerName, Address address)
    {
        this._customerName = customerName;        
        this.address = address;
    }
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }

    public override string ToString()
    {
        return $"Name: {_customerName}\nAddress: {address.DisplayAddressString()}";
    }
}