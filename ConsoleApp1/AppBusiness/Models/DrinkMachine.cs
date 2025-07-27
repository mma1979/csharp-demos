using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBusiness.Models;




public class DrinkMachine
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string SerialNumber { get; set; }
    public int Age { get; set; }

    public DrinkMachine()
    {

    }

    public  DrinkMachine(DrinkMachineDto dto)
    {
        if(string.IsNullOrEmpty(dto.Brand))
            throw new ValidationException("FIELD_IS_REQUIRED");

        Brand = dto.Brand;
        Model = dto.Model;
        SerialNumber = dto.SerialNumber;
        Age = dto.Age;
    }


   public virtual void  SayYourName()
    {
        Console.WriteLine($"I am a drink machine of brand {Brand} and model {Model}.");
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Brand, Model, SerialNumber, Age);
    }

    public override bool Equals(object? obj)
    {
        if (obj is not DrinkMachine other)
            return false;
        return Brand == other.Brand &&
               Model == other.Model &&
               SerialNumber == other.SerialNumber &&
               Age == other.Age;
    }

    override public string ToString()
    {
        return $"{Brand} {Model} ({SerialNumber}) - Age: {Age} years";
    }

    
}
