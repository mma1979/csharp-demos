using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBusiness.Models;

public struct Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }
    public override string ToString()
    {
        return $"{Year} {Make} {Model}";
    }
}