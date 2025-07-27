using AppBusiness.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AppBusiness.Helpers;

public static class Editor
{
    public static void EditCar(Car car)
    {
        car.Make = "Toyota";
        car.Model = "Corolla";
        car.Year = 2022;
    }

    public static void EditTruck(Truck truck)
    {
        truck.Make = "Toyota";
        truck.Model = "Corolla";
        truck.Year = 2022;
    }

    public static void AddOne(int x)
    {
        x++;
    }

    public static void AddTow(ref int x)
    {
        x+=2; // x=x+2
    }

    public static bool IsOdd(int value, out int x)
    {
        x = value;
        return value % 2 != 0;
    }

    public static (bool, int) IsEven(int value)
    {
        var DivOut = value % 2;
        var isEven = DivOut == 0;

        return (isEven, DivOut);
    }
}
