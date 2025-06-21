namespace AdmissionCommittee;

using System;
using Npgsql;

public class DatabaseHelper
{
    private string connString = "Host=127.0.0.1;Port=5432;Database=AdmissionCommittee;Username=postgres;Password=1478";

    public void GetAllDirections()
    {
        using (var conn = new NpgsqlConnection(connString))
        {
            conn.Open();
            using (var cmd = new NpgsqlCommand("SELECT id, name FROM directions", conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        Console.WriteLine($"ID: {id}, Название: {name}");
                    }
                }
            }
        }
    }
}