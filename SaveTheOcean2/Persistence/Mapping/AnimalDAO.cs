using SaveTheOcean2.Persistence.DAO;
using Npgsql;
using SaveTheOcean2.Persistence.Utils;
using SaveTheOcean2.DTO;


namespace SaveTheOcean2.Persistence.Mapping
{
    public class AnimalDAO : IAnimalDAO
    {
        private readonly string connectionString;


        public AnimalDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public AnimalDTO GetAnimalById(int id)
        {
            AnimalDTO animal = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "SELECT \"id\", \"name\", \"place\", \"family\", \"species\", " +
                               "\"weight\" " +
                               "FROM \"animals\" WHERE \"id\" = @id";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // ORM: [--,--,--] -----> ContactDTO
                    animal = NpgsqlUtils.GetAnimal(reader);
                }
            }

            return animal;
        }

        public void AddAnimal(AnimalDTO animal)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "INSERT INTO \"animals\" (\"date\", \"name\", \"family\", \"species\", \"weight\") " +
                "VALUES (NOW(), @name, @place, @family, @species, @weight)";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", animal.Name);
                command.Parameters.AddWithValue("@family", animal.Family);
                command.Parameters.AddWithValue("@species", animal.Species);
                command.Parameters.AddWithValue("@weight", animal.Weight);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
       

        

        public IEnumerable<AnimalDTO> GetAllAnimals()
        {
            List<AnimalDTO> animals = new List<AnimalDTO>();

            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "SELECT \"date\", \"name\", \"place\", \"family\", \"species\", \"weight\" " +
                "FROM \"animals\"";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    AnimalDTO animal = NpgsqlUtils.GetAnimal(reader);
                    animals.Add(animal);
                }
            }
            return animals;
        }
    }

}
