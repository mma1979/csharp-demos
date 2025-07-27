using AppBusiness.Customers;
using AppBusiness.Helpers;
using AppBusiness.Models;

var customer = new Customer(1, "Customer", "email", "01008986368");

customer.PrintAddresses<ExternalAddress>();
customer.PrintAddresses<InternalAddress>();


var car = new Car("Honda", "Civic", 2020);
Console.WriteLine(car.ToString());

Editor.EditCar(car);
Console.WriteLine(car.ToString());


var truck = new Truck("Honda", "Truck", 2020);
Console.WriteLine(truck.ToString());

Editor.EditTruck(truck);
Console.WriteLine(truck.ToString());

var x = 10;

Console.WriteLine($"X={x}");

Editor.AddOne(x);

Console.WriteLine($"X={x}");

Editor.AddTow(ref x);


Console.WriteLine($"X={x}");

var isOdd = Editor.IsOdd(x, out var y);
Console.WriteLine($"Is {y} odd? {isOdd}");

var result = Editor.IsEven(x);
Console.WriteLine($"Is {result.Item2} even? {result.Item1}");

var (isEven, divOut) = Editor.IsEven(x);
Console.WriteLine($"Is {divOut} even? {isEven}");