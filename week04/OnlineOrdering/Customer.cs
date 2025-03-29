using System.Net.Sockets;

public class Customer 
{
    private string _customerName;
    public Address _address;

    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }

    public bool LivesInUSA()
    {
        return _address.GetLiveInUSA();
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public string GetCustomerAddress()
    {
        return _address.GetAddress();
    }

    public void DisplayCustomerInfo()
    {
        Console.WriteLine("Customer Name:");
        Console.WriteLine($"  {_customerName}");
        Console.WriteLine();
        _address.DisplayAddress();
   
    }
}