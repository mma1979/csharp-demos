using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBusiness.Models;

public class LatteMachine: DrinkMachine,ILatteMachine, IDisposable
{
    public LatteMachine(DrinkMachineDto dto): base(dto)
    {
        
    }
    public void MakeLatte()
    {
        Console.WriteLine("Making latte...");
        // Logic to make latte
    }

    public void NotInInterface()
    {
        Console.WriteLine("This method is not in the interface.");
    }   

    public void Dispose()
    {
        // Dispose of any resources if necessary
        Console.WriteLine("Disposing LatteMachine resources.");
        GC.SuppressFinalize(this);
        GC.Collect();
    }
}
