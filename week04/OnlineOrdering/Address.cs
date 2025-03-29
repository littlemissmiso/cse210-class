public class Address 
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    public bool _liveInUSA;

    public bool GetLiveInUSA()
    {
        return _liveInUSA;
    }

    private void SetLiveInUSA(bool value)
    {
        _liveInUSA = value;
    }

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;

        _liveInUSA = country == "USA" || country == "United States";

    }

    public string GetAddress()
    {
        return $"  {_street}\n  {_city}\n  {_state}, {_country}";
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"Address:");
        Console.WriteLine($"  {_street}");
        Console.WriteLine($"  {_city}");
        Console.WriteLine($"  {_state}, {_country}");
    }
}