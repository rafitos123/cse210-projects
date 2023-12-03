using System;

public class Order
{
    private List<Product> _product = new List<Product>();
    //private List<Costumer> _costumer = new List<Costumer>();
    private Costumer _costumer;
    int TotalPrice = 0;
    string _packingLabel = "Product:";
    string _shipping = "Shipping:";



    public Order(List<Product> product, Costumer costumer)
    {
        _product = product;
        _costumer = costumer;
    }

    public int GetTotal()
    {
        
        foreach(Product myProduct in _product)
        {
            TotalPrice = TotalPrice + myProduct.GetPriceQuantity();
            
        }

        if(_costumer.inUsa())
            {
                return TotalPrice + 5;
            }
        else if(!_costumer.inUsa())
        {
            return TotalPrice + 35;
        }
        

        return TotalPrice;
    }

    public string GetPacking()
    {
        foreach(Product myProduct in _product)
        {
            _packingLabel = _packingLabel + $"\n{myProduct.GetName()} - ID: {myProduct.GetId()}";
            
        }
        return _packingLabel;
        
    }

    public string GetShipping()
    {
        Console.WriteLine();
        _shipping = _shipping + $"\n{_costumer.GetNameCostumer()} - {_costumer.FullAdress()}";

        return _shipping;
    }

}