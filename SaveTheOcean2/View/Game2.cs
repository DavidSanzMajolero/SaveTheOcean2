using SaveTheOcean2.DTO;
using SaveTheOcean2.Persistence.DAO;
using SaveTheOcean2.Persistence.Mapping;
using SaveTheOcean2.Persistence.Utils;
using System;

namespace SaveTheOcean2.View
{
    public partial class Game2 : Form
    {
        private Game formMenu;
        private AnimalDTO animal;
        private Player player;
        private Rescued rescued;
        private string superFamily;
        private string newName;
        private double newWeight;
        private DateTime newDateTime;
        private string newSpecies;

        private int newGradeAfectation;
        const string Rescue112Msg = "¡Saludos, {0}! Se ha recibido una alerta del 112 sobre un animal en peligro.";
        const string TreatmentMsg = "{0} presenta un nivel de afectación (GA) del {1}%. \n¿Prefieres tratarlo o trasladarlo al centro?";
        const string XpAugmentMsg = " ¡Tu experiencia ha aumentado en +50 puntos!";
        const string XpDecreaseMsg = " ¡Tu experiencia ha disminuido en -20 puntos!";
        const string TreatmentExitMsg = "¡El tratamiento aplicado ha reducido el GA al {0}%! ¡Éxito en el rescate! {1}, de la especie {2}, ha sido devuelto a su hábitat natural.";
        const string TreatmentNotExitMsg = "¡El tratamiento aplicado ha reducido el GA al {0}%! El animal {1}, de la especie {2}, necesita más cuidados. ¡Será trasladado al CRAM!";

        public Game2(Game formMenu, string playerName, string role)
        {
            InitializeComponent();
            this.formMenu = formMenu;

            superFamily = Helper.GetRandomSuperfamily();
            newName = Helper.GetRandomName();
            newWeight = Helper.GetRandomWeight();
            newDateTime = Helper.GetRandomDateTime();
            newSpecies = Helper.GetRandomSpecies();

            animal = new AnimalDTO
            {
                Name = newName,
                Family = superFamily,
                Species = newSpecies,
                Weight = newWeight,
                Date = newDateTime
            };

            rescued = new Rescued(animal);

            player = new Player(playerName, role == "Técnico" ? 45 : 80);



            lbl_msgRescate.Text = string.Format(Rescue112Msg, playerName);
            lbl_FitxaRescat.Text = Helper.PrintRescueAndDataSheetInfo(rescued);
            lbl_choose.Text = string.Format(TreatmentMsg, rescued.Animal.Name, animal.CalculateNewGradeAfectation(true));

        }

        private void butt_heal_Click(object sender, EventArgs e)
        {
            newGradeAfectation = animal.CalculateNewGradeAfectation(true);
            UpdateUIAfterTreatment();
            IRescueDAO rescueDAO = new RescueDAO(NpgsqlUtils.OpenConnection());
            rescueDAO.AddRescue(rescued);
        }

        private void butt_move_Click(object sender, EventArgs e)
        {
            newGradeAfectation = animal.CalculateNewGradeAfectation(false);
            UpdateUIAfterTreatment();
            IRescueDAO rescueDAO = new RescueDAO(NpgsqlUtils.OpenConnection());
            rescueDAO.AddRescue(rescued);
        }

        private void UpdateUIAfterTreatment()
        {
            lbl_msgRescate.Hide();
            lbl_FitxaRescat.Hide();
            lbl_choose.Hide();
            butt_curar.Hide();
            butt_trasladar.Hide();
            if (newGradeAfectation <= 30)
            {
                lbl_msgtreatment.Text = string.Format(TreatmentExitMsg, newGradeAfectation, rescued.Animal.Name, rescued.Animal.Species);
                lbl_msgtreatment.Show();
                lbl_msgxp.Text = string.Format(XpAugmentMsg);
                lbl_msgxp.Show();
                player.AddExperience(50);
            }
            else
            {
                lbl_msgtreatment.Text = string.Format(TreatmentNotExitMsg, newGradeAfectation, rescued.Animal.Name, rescued.Animal.Species);
                lbl_msgtreatment.Show();
                lbl_msgxp.Text = string.Format(XpDecreaseMsg);
                lbl_msgxp.Show();
                player.RemoveExperience(20);
            }
            butt_menu.Show();
            Player playerNew = new Player(player.Name, player.Experience);
            XMLHelper.AppendPerson(playerNew);
        }

        private void butt_gomenu_Click(object sender, EventArgs e)
        {
            formMenu.Show();
            this.Close();
        }

        private void lbl_playerInfo_Click(object sender, EventArgs e)
        {

        }

        private void Game2_Load(object sender, EventArgs e)
        {

        }
    }

    public class Helper
    {
        public static string PrintRescueAndDataSheetInfo(Rescued rescued)
        {
            string rescueInfo = $"Rescue Number: {rescued.Number}\n" +
                                $"Rescue Date: {rescued.Date}\n" +
                                $"Superfamily: {rescued.Superfamily}\n" +
                                $"Location: {rescued.Location}\n";

            string dataSheetInfo = $"Name: {rescued.Animal.Name}\n" +
                                   $"Superfamily: {rescued.Animal.Family}\n" +
                                   $"Species: {rescued.Animal.Species}\n" +
                                   $"Approx. Weight: {rescued.Animal.Weight:F1} kg\n";

            return $"Rescue Information:\n{rescueInfo}\nData Sheet Information:\n{dataSheetInfo}";
        }

        public static bool ValidateOption(int userInput, int min, int max)
        {
            return userInput >= min && userInput <= max;
        }

        public static int RandomNum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public static bool StartWithNumbers(string text)
        {
            return char.IsDigit(text[0]);
        }

        public static int RandomNum(int max)
        {
            Random random = new Random();
            return random.Next(max);
        }

        public static string GetRandomSuperfamily()
        {
            string[] superfamily = { "Sea Turtle", "Sea Bird", "Cetacean" };
            int index = RandomNum(superfamily.Length);
            return superfamily[index];
        }

        public static DateTime GetRandomDateTime()
        {
            DateTime start = new DateTime(2020, 1, 1);
            Random random = new Random();
            int range = (DateTime.Today - start).Days;
            return start.AddDays(random.Next(range));
        }

        public static string GetRandomName()
        {
            string[] names = { "Turtle", "Dolphin", "Squid", "Seal", "Orca", "Penguin" };
            int index = RandomNum(names.Length);
            return names[index];
        }

        public static string GetRandomSpecies()
        {
            string[] species = { "Caretta", "Delphinus", "Phocoena", "Pinnipeds" };
            int index = RandomNum(species.Length);
            return species[index];
        }

        public static double GetRandomWeight()
        {
            Random random = new Random();
            return random.NextDouble() * (100 - 1) + 1;
        }

        
    }
}
