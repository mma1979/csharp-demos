using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models;

public interface IEspressoMachine
{
    void MakeEspresso();
    void MakeEspresso(MakeEspressoArgsDto args);
}

public interface ILatteMachine
{
    void MakeLatte();
}
public interface ICappuccinoMachine
{
    void MakeCappuccino();
    void MakeCappuccino(MakeCappuccinoArgsDto args);
}
public interface ITeaMachine
{
    void MakeTeaWithMilk();
}
