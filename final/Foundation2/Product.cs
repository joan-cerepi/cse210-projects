using System;

public class Product
{
    private string _productName = "";
    private long _productId = 0;
    private double _price = 0.00;
    private int _quantity = 0;

    public Product()
    {

    }

    public Product(string productName, long productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public void SetProductName(string productName)
    {
        _productName = productName;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public void SetProductId(long productId)
    {
        _productId = productId;
    }

    public long GetProductId()
    {
        return _productId;
    }

    public void SetPrice(double price)
    {
        _price = price;
    }

    public double GetPrice()
    {
        return Math.Round(_price, 2);
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double GetFullPrice()
    {
        return Math.Round(_price * _quantity, 2);
    }
}