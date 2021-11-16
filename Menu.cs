using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangerMain chang = new ChangerMain();
            chang.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Consulter consulter = new Consulter();
            consulter.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ajouter ajouter = new Ajouter();
            ajouter.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
             this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            supp supp_ = new supp();
            supp_.Show();
            this.Hide();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
