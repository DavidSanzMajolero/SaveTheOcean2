using System;

namespace SaveTheOcean2
{
    public class Player
    {
        public string Name { get; set; }
        public int Experience { get; set; }

        public Player(string name, int experience)
        {
            this.Name = name;
            this.Experience = experience;
        }

        public void AddExperience(int experience)
        {
            this.Experience += experience;
        }

        public void RemoveExperience(int experience)
        {
            this.Experience -= experience;
        }
        public override string ToString()
        {
            return $"Player: {Name} - Experience: {Experience}";
        }
    }
}
