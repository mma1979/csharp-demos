using ConsoleApp1.Infrastrcture;
using ConsoleApp1.Models;

var drinkMachine =  new DrinkMachine(
    new DrinkMachineDto("BrandX","ModelY","12345", 2));



Console.WriteLine(drinkMachine.ToString());


try
{
    

    var espressoMachine = new EspressoMachine(new DrinkMachineDto(null, "ModelY", "12345", 2));
    espressoMachine.SayYourName();

    var x = 10;
    var y = 0;
    Console.WriteLine(x / y);
}

//catch (ValidationException ex)
//{
//    Console.WriteLine($"ValidationException: {ex.Message}");
//}
//catch (ArgumentNullException ex)
//{
//    Console.WriteLine($"ArgumentNullException: {ex.Message}");
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine($"DivideByZeroException: {ex.Message}");
//}
catch (Exception ex)
{

    switch (ex.GetType())
    {   case Type t when t == typeof(ValidationException):
            Console.WriteLine($"ValidationException: {ex.Message}");
            break;
        default:
            break;
    }
}


Console.WriteLine("Done");

using var latteMachine = new LatteMachine(new DrinkMachineDto("BrandA", "ModelB", "67890", 1));
latteMachine.SayYourName();

    




