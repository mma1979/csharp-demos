using DAL;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBusiness.City;

public class CityQuery
{
    public static List<City> GetCities()
    {
      var cityDt  = Database.GetCities();
        var cities = cityDt.AsEnumerable()
            .Select(row => new City
            {
                Id = row.Field<int>("Id"),
                Name = row.Field<string>("Name")
            })
            .ToList();

        return cities;  
    }
}
