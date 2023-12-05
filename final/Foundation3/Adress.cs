using System;
using System.Security.Cryptography.X509Certificates;

public class Adress
{
    public string _street;
    public string _numberofLocation;
    public string _city;
    public string _state;
    public string _country;

    public Adress(string street, string numberofLocation, string city, string state, string country)
    {
        _street = street;
        _numberofLocation = numberofLocation;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetAdress()
    {
        string EventAdress = $"Adress: {_street}, {_numberofLocation} - {_city}, {_state} - {_country}";
        return EventAdress;
    }

}