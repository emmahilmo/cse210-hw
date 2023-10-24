using System;
public class Address {
    private string _street;
    private string _city;
    private string _stateProvence;
    private string _country;
    private bool _USA = false;
    public Address(string street, string city, string stateProvence, string country)  {
        _street = street;
        _city = city;
        _stateProvence = stateProvence;
        _country = country;
        _USA = country == "USA";

    }
    public bool isInUSA() {
        return _USA;
    }
    public string GetAddress() {
        return $"{_street} {_city}, {_stateProvence} {_country}";
    }
}