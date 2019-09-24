using System;
using System.Collections.Generic;

class Car {
    public string MakeModel;
    public int Price;
    public int Miles;
    
    public bool WorthBuying(int maxPrice)
    {
        return (Price < maxPrice);
    }
}

public class Program
{
    public static void Main()
    {
        Car geo = new Car();
        geo.MakeModel= "1996 Geo Metro";
        geo.Price = 1200;
        geo.Miles = 69420;
    
        Car bmw = new Car();
        bmw.MakeModel ="2007 351i";
        bmw.Price = 8000;
        bmw.Miles = 120000;

        Car subaru = new Car();
        subaru.MakeModel = "2007 Subaru Impreza";
        subaru.Price = 8000;
        subaru.Miles = 97000;

        Car aztec = new Car();
        aztec.MakeModel = "2001 Pontiac Aztec";
        aztec.Price = 30000;
        aztec.Miles = 100000;

        List<Car> Cars = new List<Car>() {geo, bmw, subaru, aztec};

        Console.WriteLine("How much you trying to spend?");
        string maxPriceString = Console.ReadLine();
        int maxPrice = int.Parse(maxPriceString);

        List<Car> CarsMatchingSearch = new List<Car>(0);

        foreach (Car automobile in Cars)
        {
            if (automobile.WorthBuying(maxPrice))
            {
              CarsMatchingSearch.Add(automobile);  
            }
        }
    foreach (Car automobile in Cars)
    {
        Console.WriteLine(automobile.MakeModel);
    }
    }
}
