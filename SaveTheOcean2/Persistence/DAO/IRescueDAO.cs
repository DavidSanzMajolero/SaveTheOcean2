
namespace SaveTheOcean2.Persistence.DAO
{
    public interface IRescueDAO
    {
        void AddRescue(Rescued resc);
        List<Rescued> GetRescues();
        List<Rescued> GetRescueById(string id);
    }
}
