using Microsoft.Data.SqlClient;

using System.Data;

namespace DAL;

public class Database
{

    public static DataTable GetCities()
    {
        using var connection = new SqlConnection("Server=127.0.0.1;Database=demo1-db;User Id=sa;Password=Abc@1234;Trust Server Certificate=true");

        var adapter = new SqlDataAdapter("SELECT * FROM Cities", connection);

        var dt = new DataTable();
        adapter.Fill(dt);
        return dt;
    }

    public static bool InsertCity(int id, string name)
    {
        using var connection = new SqlConnection("Server=127.0.0.1;Database=demo1-db;User Id=sa;Password=Abc@1234;Trust Server Certificate=true");

        using var command = new SqlCommand("Insert Into Cities(Id,Name) values(@Id,@Name)", connection);

        command.Parameters.AddWithValue("@Id", id);
        command.Parameters.AddWithValue("@Name", name);
        connection.Open();
        var rowsAffected = command.ExecuteNonQuery();
        return rowsAffected > 0;
    }
    }
