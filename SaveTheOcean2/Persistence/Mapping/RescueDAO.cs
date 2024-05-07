using Npgsql;
using SaveTheOcean2.DTO;
using SaveTheOcean2.Persistence.DAO;

namespace SaveTheOcean2.Persistence.Mapping
{
    public class RescueDAO : IRescueDAO
    {
        private readonly string connectionString;

        public RescueDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddRescue(Rescued record)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand("INSERT INTO Rescue (Number, Date, Superfamily, Location) VALUES (@Number, @Date, @Superfamily, @Location);", connection))
                {
                    command.Parameters.AddWithValue("@Number", record.Number);
                    command.Parameters.AddWithValue("@Date", record.Date);
                    command.Parameters.AddWithValue("@Superfamily", record.Superfamily);
                    command.Parameters.AddWithValue("@Location", record.Location);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Rescued> GetRescues()
        {
            List<Rescued> rescues = new List<Rescued>();
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand("SELECT number, date, superfamily, location FROM Rescue;", connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Rescued rescue = new Rescued(new AnimalDTO());
                            rescue.Number = reader.GetString(0);
                            rescue.Date = reader.GetString(1);
                            rescue.Superfamily = reader.GetString(2);
                            rescue.Location = reader.GetString(3);
                            rescues.Add(rescue);
                        }
                    }
                }
            }
            return rescues;
        }

        public List<Rescued> GetRescueById(string id)
        {
            List<Rescued> rescues = new List<Rescued>();
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM Rescue WHERE Number = @Number;", connection))
                {
                    command.Parameters.AddWithValue("@Number", id);
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Rescued rescue = new Rescued(new AnimalDTO());
                            rescue.Number = reader.GetString(0);
                            rescue.Date = reader.GetString(1);
                            rescue.Superfamily = reader.GetString(2);
                            rescue.Location = reader.GetString(3);
                            rescues.Add(rescue);
                        }
                    }
                }
            }
            return rescues;
        }
    }
}
