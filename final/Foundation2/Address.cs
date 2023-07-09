using System;

public class Address
{
    private string _streetAddress = "";
    private string _city = "";
    private string _stateProvince = "";
    private string _country = "";

    public Address()
    {

    }

    public Address(string streetAddress, string city, string stateProvice, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvice;
        _country = country;
    }

    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }

    public string GetStreetAddress()
    {
        return _streetAddress;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetStateProvince(string stateProvince)
    {
        _stateProvince = stateProvince;
    }

    public string GetStateProvince()
    {
        return _stateProvince;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }

    public string GetCountry()
    {
        return _country;
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}, {_country}";
    }

    public bool IsInUS()
    {
        return _country == "USA";
    }
}