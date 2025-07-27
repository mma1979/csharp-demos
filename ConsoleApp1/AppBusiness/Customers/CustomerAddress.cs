using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBusiness.Customers;

public class CustomerAddress<T> where T : IAddress
{
    public T Address { get; set; }
    public string Type { get; set; } // "External" or "Internal"
    public CustomerAddress(T address, string type)
    {
        Address = address;
        Type = type;
    }
    public override string ToString()
    {
        return $"{Type} Address: {Address}";
    }
}


public class ExternalAddress: IAddress
{
       public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }

    public ExternalAddress()
    {
        
    }
    public ExternalAddress(string street, string city, string state, string zipCode)
    {
        Street = street;
        City = city;
        State = state;
        ZipCode = zipCode;
    }
    public override string ToString()
    {
        return $"{Street}, {City}, {State} {ZipCode}";
    }
}

public class InternalAddress: IAddress
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public InternalAddress()
    {
        
    }
    public InternalAddress(string street, string city, string state, string zipCode)
    {
        Street = street;
        City = city;
        State = state;
        ZipCode = zipCode;
    }
    public override string ToString()
    {
        return $"{Street}, {City}, {State} {ZipCode}";
    }
}
