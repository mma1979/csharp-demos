using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBusiness.Models;

public class EspressoAnLatteMachine:DrinkMachine, IEspressoMachine, ILatteMachine
{
    public EspressoAnLatteMachine(DrinkMachineDto dto):base(dto)
    {
    }
    
    public void MakeEspresso()
    {
        throw new NotImplementedException();
    }

    public void MakeEspresso(MakeEspressoArgsDto args)
    {
        throw new NotImplementedException();
    }

    public void MakeLatte()
    {
        throw new NotImplementedException();
    }

    public string Name { get; set; }
}
