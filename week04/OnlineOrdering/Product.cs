public class Product 
{
    private string _productName;
    private int _productID;
    private double _productPrice;
    private double _productQuantity;

    private double _finalCost;

    public Product(string product, int id, double price, double quantity)
    {
        _productName = product;
        _productID = id;
        _productPrice = price;
        _productQuantity = quantity;

    }

    public double ComputeTotalCost()
    {
        double price = _productPrice;
        double quantity = _productQuantity;
        
        
        _finalCost = price * quantity;
        return _finalCost;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public int GetProductID()
    {
        return _productID;
    }

    public void DisplayProductInfo()
    {
        Console.WriteLine($"Product Name: {_productName}");
        Console.WriteLine($"Product ID: {_productID}");
        Console.WriteLine($"Individual Price: ${_productPrice:F2}");
        Console.WriteLine($"Product Quantity: {_productQuantity}");
        Console.WriteLine($"Total Item(s) Cost: ${_finalCost:F2}");

    }
}