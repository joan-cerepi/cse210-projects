using System;

public class Customer
{
    private string _name = "";
    private Address _address = new Address();

    public Customer()
    {

    }

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public bool LivesInUS()
    {
        return _address.IsInUS();
    }
}