using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models;

public class EspressoMachine : DrinkMachine, IEspressoMachine
{
    private EspressoMachine()
    {
        
    }

    public EspressoMachine(DrinkMachineDto dto):base(dto)
    {
        
    }
    public void MakeEspresso()
    {
        Console.WriteLine("Making espresso...");
        // Logic to make espresso
    }

    public void MakeEspresso(MakeEspressoArgsDto args)
    {
        Console.WriteLine("Making espresso with ars...", args.ToString());
        // Logic to make espresso
    }

    public override void SayYourName()
    {
        Console.WriteLine($"I am a espresso machine of brand {Brand} and model {Model}.");
    }
}

