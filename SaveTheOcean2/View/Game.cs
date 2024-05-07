namespace SaveTheOcean2
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void butt_leave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butt_start_Click(object sender, EventArgs e)
        {
            Play formGame = new Play(this);
            formGame.Show();
            this.Hide();
        }

        private void butt_rescued_Click(object sender, EventArgs e)
        {
            FormRescued formRescued = new FormRescued(this);
            formRescued.Show();
            this.Hide();
        }



        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
