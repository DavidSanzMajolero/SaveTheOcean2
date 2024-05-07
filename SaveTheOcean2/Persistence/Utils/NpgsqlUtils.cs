using SaveTheOcean2.DTO;
using Npgsql;
using Microsoft.Extensions.Configuration;

namespace SaveTheOcean2.Persistence.Utils
{
    public class NpgsqlUtils
    {
        public static string OpenConnection()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            return config.GetConnectionString("MyPostgresConn");
        }

        public static AnimalDTO GetAnimal(NpgsqlDataReader reader)
        {
            AnimalDTO animal = new AnimalDTO
            {
                Date = reader.GetDateTime(0),
                Name = reader.GetString(1),
                Family = reader.GetString(2), 
                Species = reader.GetString(3), 
                Weight = reader.GetDouble(4) 
            };

            return animal;
        }
    }

}
