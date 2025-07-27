using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBusiness.Parents;

public class Child
{
    public int Id { get; set; }
    public string Name { get; set; } public string Description { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }
    public Parent Parent { get; set; }
    public int ParentId { get; set; }
    public Child()
    {
        
    }
    public Child(string name, int age, string grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }
    public override string ToString()
    {
        return $"{Name} (Age: {Age}, Grade: {Grade})";
    }
}
