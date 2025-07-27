using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBusiness.City;

public class CityOperations
{
    public static bool InsertCity(int id, string name)
    {
        // Validate inputs
        if (id <= 0)
        {
            throw new ArgumentException("Id must be greater than zero.", nameof(id));
        }
        return DAL.Database.InsertCity(id, name);
    }
}
