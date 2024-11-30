using System.Net.Sockets;

public class Customer
{
    public Customer(
        string name,
        Address address
    )
    {
        _name = name;
        _address = address;
    }
    private string _name;
    private Address _address;

    public bool IsInUSA(){
        if (_address.GetCountry().Equals("USA"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetCustomerName(){
        return _name;
    }
    public Address GetCustomerAddress(){
        return _address;
    }
}