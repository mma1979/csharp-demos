using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models;

public class TeaMachine: DrinkMachine
{
    public void MakeTeaWithMilk()
    {
        Console.WriteLine("Making Tea with Milk");
    }
}
