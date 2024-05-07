using SaveTheOcean2.DTO;

namespace SaveTheOcean2.Persistence.DAO
{
    public interface IAnimalDAO
    {
        AnimalDTO GetAnimalById(int id);
        IEnumerable<AnimalDTO> GetAllAnimals();
        void AddAnimal(AnimalDTO animal);
    }
}
