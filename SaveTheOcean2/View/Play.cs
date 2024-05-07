using SaveTheOcean2.View;
using System.ComponentModel;


namespace SaveTheOcean2
{
    public partial class Play : Form
    {
        private Game formMenu;
        private string rol;
        private string playername;
        public Play(Game formMenu)
        {
            InitializeComponent();
            this.formMenu = formMenu;
        } 

        private void txtBoxName_Validating(object sender, CancelEventArgs e)
        {
            string text = txtBoxName.Text.Trim();
             if (Helper.StartWithNumbers(text))
            {
                NameProvider.SetError(txtBoxName, "El nombre no puede comenzar por numeros");
                e.Cancel = true;
            }
            else if(string.IsNullOrEmpty(text))
            {
                NameProvider.SetError(txtBoxName, "El nombre no debe estar vacio");
                e.Cancel = true;
            }
            else
            {
                NameProvider.SetError(txtBoxName, "");
                e.Cancel = false;
            }
        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                butt_tecnico.Enabled = false;
                butt_veterinario.Enabled = false;
            }
            else
            {
                butt_tecnico.Enabled = true;
                butt_veterinario.Enabled = true;
            }
        }
        private void butt_tecnic_Click(object sender, EventArgs e)
        {
            rol = "Tecnic";
            playername = txtBoxName.Text;
            View.Game2 formGame = new View.Game2(formMenu, playername, rol);
            formGame.Show();
            this.Close();
        }
        private void butt_veterinari_Click(object sender, EventArgs e)
        {
            rol = "Veterinari";
            playername = txtBoxName.Text;
            View.Game2 formGame = new View.Game2(formMenu, playername, rol);
            formGame.Show();
        }
    }

}
