using AppBusiness.City;

var cities = CityQuery.GetCities();

foreach (var city in cities)
{
    Console.WriteLine($"Id: {city.Id}, Name: {city.Name}");
}
Console.WriteLine("=================================");

var isInserted = CityOperations.InsertCity(6, "New City");

cities = CityQuery.GetCities();

foreach (var city in cities)
{
    Console.WriteLine($"Id: {city.Id}, Name: {city.Name}");
}