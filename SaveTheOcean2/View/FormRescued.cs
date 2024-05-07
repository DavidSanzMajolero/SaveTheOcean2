using SaveTheOcean2.DTO;
using SaveTheOcean2.Persistence.Utils;
using SaveTheOcean2.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaveTheOcean2.Persistence.DAO;
using SaveTheOcean2.Persistence.Mapping;


namespace SaveTheOcean2
{
    public partial class FormRescued : Form
    {
        private Game formMenu;
        public FormRescued(Game formMenu)
        {
            InitializeComponent();
            this.formMenu = formMenu;
            FormRescued_Load();
        }

        private void FormRescued_Load()
        {
            IRescueDAO rescueDAO = new RescueDAO(NpgsqlUtils.OpenConnection());
            List<Rescued> rescued = rescueDAO.GetRescues();
            dataGridView1.DataSource = rescued;
            dataGridView1.Columns["number"].Visible = true;
            dataGridView1.Columns["date"].HeaderText = "Date";
            dataGridView1.Columns["superfamily"].HeaderText = "Superfamily";
            dataGridView1.Columns["location"].HeaderText = "Location";
        }

        private void butt_back_Click(object sender, EventArgs e)
        {
            this.formMenu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //select by number
            IRescueDAO rescueDAO = new RescueDAO(NpgsqlUtils.OpenConnection());
            List<Rescued> rescued = rescueDAO.GetRescues();
            rescued = rescued.Where(x => x.Number == textBox1.Text).ToList();
            dataGridView1.DataSource = rescued;

        }
    }
}
