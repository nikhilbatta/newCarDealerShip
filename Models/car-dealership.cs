namespace Dealership
{
class Car {
    private string _MakeModel;
    private int _Price;
    private int _Miles;
    private string _Message;
    
    public Car(string makeModel, int price, int miles, string message)
    {
        _MakeModel = makeModel;
        _Price = price;
        _Miles = miles;
        _Message = message;
    }
    public string GetMakeModel()
    {
        return _MakeModel;
    }
    public int GetPrice()
    {
        return _Price;
    }
    public int GetMiles()
    {
        return _Miles;
    }
    public string Message()
    {
        return _Message;
    }
    public void SetPrice(int newPrice)
    {
        _Price = newPrice;
    }
    public bool WorthBuying(int maxPrice, int maxMile)
    {
    
        return (_Price < maxPrice && _Miles < maxMile);
    }
}
}