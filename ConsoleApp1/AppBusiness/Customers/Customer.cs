using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBusiness.Customers;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public List<CustomerAddress<ExternalAddress>> ExternalAddresses { get; set; } = [];
    public List<CustomerAddress<InternalAddress>> InternalAddresses { get; set; } = [];

    public Customer(int id, string name, string email, string phoneNumber)
    {
        Id = id;
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;

        
    }

    public void PrintAddresses<T>() where T: IAddress
    {
        var message = typeof(T) switch
        {
            Type t when t == typeof(ExternalAddress) => "External Addresses",
            Type t when t == typeof(InternalAddress) => "Internal Addresses",
            _ => "Unknown Addresses"
        };

        Console.WriteLine($"{message} for {Name}:");
    }
    public override string ToString()
    {
        return $"{Id}: {Name} ({Email}, {PhoneNumber})";
    }
}
