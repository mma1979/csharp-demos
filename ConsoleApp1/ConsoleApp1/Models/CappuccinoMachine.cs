using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models;

public class CappuccinoMachine: DrinkMachine
{
    public void MakeCappuccino()
    {
        Console.WriteLine("Making cappuccino...");
        // Logic to make cappuccino
    }

    public void MakeCappuccino(MakeCappuccinoArgsDto args)
    {
        Console.WriteLine("make cu with args", args);
    }
}
