using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBusiness.Models;

public record DrinkMachineDto(string Brand,
    string Model,
    string SerialNumber,
    int Age
);

public record MakeEspressoArgsDto(bool IsDoubleShot, int SugerCount, bool WithMilk);
public record MakeCappuccinoArgsDto(bool IsDoubleShot, int SugerCount, bool WithMilk);