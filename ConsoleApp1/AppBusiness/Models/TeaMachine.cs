using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBusiness.Models;

public class TeaMachine: DrinkMachine
{
    public void MakeTeaWithMilk()
    {
        Console.WriteLine("Making Tea with Milk");
    }
}
