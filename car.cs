using System;
using System.Collections.Generic;

class Car {
    public string MakeModel;
    public int Price;
    public int Miles;
    public string Message;
    
    public Car(string makeModel, int price, int miles, string message)
    {
        MakeModel = makeModel;
        Price = price;
        Miles = miles;
        Message = message;
    }
    public bool WorthBuying(int maxPrice, int maxMile)
    {
    
        return (Price < maxPrice && Miles < maxMile);
    }
}

public class Program
{
    public static void Main()
    {
        Car geo = new Car("1996 Geo Metro", 1200, 69420, "The 1996 Geo Metro is still the most fuel efficient gasoline engine ever produced.-&rew");
    
        Car bmw = new Car("2007 351i", 8000, 120000, "this car is trash.  Don't buy.-Nikhil");
        
        Car subaru = new Car("2007 Subaru Impreza", 8000, 97000,"it's a reliable car-Chris");

        Car aztec = new Car("2001 Pontiac Aztec", 30000, 100000, "Blabber");

        List<Car> Cars = new List<Car>() {geo, bmw, subaru, aztec};

        Console.WriteLine("How much you trying to spend?");
        string maxPriceString = Console.ReadLine();
        int maxPrice = int.Parse(maxPriceString);
        Console.WriteLine("How many miles is too many miles?");
        string maxMileString = Console.ReadLine();
        int maxMile = int.Parse(maxMileString);

        List<Car> CarsMatchingSearch = new List<Car>(0);

        foreach (Car automobile in Cars)
        {
            if (automobile.WorthBuying(maxPrice, maxMile))
            {
              CarsMatchingSearch.Add(automobile);  
            }
            else
            {
                Console.WriteLine("Fuck off!");
            }
        }
        foreach (Car automobile in Cars)
        {
        Console.WriteLine(automobile.MakeModel);
        }
    }
}