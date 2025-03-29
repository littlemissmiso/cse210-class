using System;
using System.Collections.Generic;
public class Order
{
    private List<Product> _products;
    private Customer _customer;
    

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProducts(Product product)
    {
        _products.Add(product);
    }

    public double TotalOrderCost()
    {
        double totalOrderCost = 0;

        foreach (var product in _products)
        {
            totalOrderCost += product.ComputeTotalCost();
        } 

        if (_customer.LivesInUSA())
        {
            totalOrderCost += 5.00;
        }
        else
        {
            totalOrderCost += 35.00;
        }

        return totalOrderCost;
    }

    public string ReturnPackingLabel()
    {
        string _packingLabel = "Packing Label:\n";
        
        foreach (var product in _products)
        {
            _packingLabel += $"  Product: {product.GetProductName()} | ID: {product.GetProductID()}\n";
        }

        return _packingLabel;
    }

    public string ReturnShippingLabel()
    {
        return $"Shipping Address: \n  {_customer.GetCustomerName()}\n{_customer.GetCustomerAddress()}\n";
    }
}