using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GatienFrenchDev sur GitHub\n\n© Password Manager version 1.1 - 2021\n\nCode source accesible ici :\nhttps://github.com/GatienFrenchDev/Password-Manager\n\nContact : contact@gatiendev.tk", "A propos");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Title = "Sauvegarde de la mot de passe";
            fileDialog.Filter = "Image|*.jpg";
            fileDialog.FileName = "sauvegarde.jpg";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                File.Copy(@"C:\Users\" + Environment.UserName + @"\Desktop\pass.jpg", fileDialog.FileName);
                MessageBox.Show("Fichier sauvegardé avec succès !");
            }
        }
    }
}
