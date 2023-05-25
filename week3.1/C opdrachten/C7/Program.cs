using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Car
{
    private int _mileage;

    public int Mileage
    {
        get { return _mileage; }
    }

    public void Drive()
    {
        _mileage += 1;
    }
}

class Program
{
    public static void Main()
    {
        Car car = new Car();
        for (int i = 0; i < 10; i++)
            car.Drive();
        int mileage = car.Mileage;
        Console.WriteLine($"The car's mileage is {mileage}");
    }
}