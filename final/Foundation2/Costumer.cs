using System;

public class Costumer
{
    private string _CostumerName;
    private Adress _adress;

    public Costumer(string CostumerName, Adress adress)
    {
        _CostumerName = CostumerName;
        _adress = adress;
    }

    public bool inUsa()
    {
        return _adress.GetCountry();
    }

    public string FullAdress()
    {
        return _adress.GetAdress();
    }

    public string GetNameCostumer()
    {
        return _CostumerName;
    }

}