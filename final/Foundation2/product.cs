using System;

public class Product
{
    private string _productName;
    private string _id;
    private int _price;
    private int _quantity;

    public Product(string productName, string id, int price, int quantity)
    {
        _productName = productName;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public int GetPriceQuantity()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _productName;
    }

    public string GetId()
    {
        return _id;
    } 
}