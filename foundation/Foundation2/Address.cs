using System.Text;

public class Address{
    public Address(
        string streetAddress,
        string city, 
        string state, 
        string country
    )
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public string GetCountry()
    {
        return _country;
    }
    public string DisplayAddress(){
        StringBuilder address = new();
        address.AppendLine(_streetAddress);
        address.AppendLine($"{_city}, {_state} {_country}");
        return address.ToString();
    }
}