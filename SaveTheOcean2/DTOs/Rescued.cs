using SaveTheOcean2.DTO;
using SaveTheOcean2.View;


namespace SaveTheOcean2
{
    public class Rescued
    {
        public string? Number { get; set; }
        public string? Date { get; set; }
        public string? Superfamily { get; set; }
        public AnimalDTO Animal { get; set; }
        public string? Location { get; set; }
        public static string[] Locations { get; set; } = { "La piscina de barrio", "Mar Mediterrani", "Oasis ostentoso", "Balsa botin", "Barceloneta" };

        public Rescued(AnimalDTO animal)
        {
            this.Number = "RES" +  Helper.RandomNum(1000).ToString("D3");
            this.Date = DateTime.Now.ToString("dd/MM/yyyy");
            this.Animal = animal;
            this.Superfamily = animal.Family;
            this.Location = Locations[Helper.RandomNum(Locations.Length)];
        }
    }
}
