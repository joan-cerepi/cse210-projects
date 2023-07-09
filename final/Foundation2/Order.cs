using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer = new Customer();
    private double _shippingCost = 0.00;
    private string _packingLabel = "";
    private string _shippingLabel = "";

    public Order()
    {

    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    public void SetShippingCost()
    {
        _shippingCost = _customer.LivesInUS() ? 5.00 : 35.00;
    }

    public double GetShippingCost()
    {
        return _shippingCost;
    }

    public void SetPackingLabel()
    {
        foreach (Product product in _products)
        {
            string productName = product.GetProductName();
            long productId = product.GetProductId();
            _packingLabel += $"{productName}\n{productId}\n\n";
        }
    }

    public string GetPackingLabel()
    {
        return _packingLabel.Trim();
    }

    public void SetShippingLabel()
    {
        string customerName = _customer.GetName();
        string customerAddress = _customer.GetAddress().GetFullAddress();
        _shippingLabel = $"{customerName}\n{customerAddress}";
    }

    public string GetShippingLabel()
    {
        return _shippingLabel;
    }

    public double GetTotalPrice()
    {
        double totalCost = 0;
        foreach(Product product in _products)
        {
            totalCost += product.GetFullPrice();
        }
        return Math.Round(totalCost + _shippingCost, 2);
    }
}