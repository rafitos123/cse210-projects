using System;

public class Adress
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country; 

    public Adress(string street, string city, string stateOrProvince, string country )
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool GetCountry()
    {
        if(_country == "USA")
        {
           return true;
        }
        else
        {
            return false;
        }
    }

    public string GetAdress()
    {
       string CostumerAdress = $"{_street}, {_city} - {_stateOrProvince}, {_country}";
        return CostumerAdress; 
    }

}