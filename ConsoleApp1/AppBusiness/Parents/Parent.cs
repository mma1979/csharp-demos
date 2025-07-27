using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBusiness.Parents;

public class Parent
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public List<Child> Children { get; set; } = [];

    public Parent()
    {
        
    }
    public Parent(string name, string email, string phoneNumber)
    {
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
    }
    
    public override string ToString()
    {
        return $"{Name} ({Email}, {PhoneNumber}) - Children: {string.Join(", ", Children.Select(e=>e.Name))}";
    }
}
