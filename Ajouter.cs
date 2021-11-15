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
    public partial class Ajouter : Form
    {
        public Ajouter()
        {
            InitializeComponent();
        }

        private String fichier_mdp = String.Empty;

        private void Ajouter_Load(object sender, EventArgs e)
        {
            fichier_mdp = File.ReadAllText(@"C:\Users\" + Environment.UserName + @"\Desktop\pass.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Merci de remplir tout les champs");
            }
            else
            {
                fichier_mdp = fichier_mdp + "}}}"+textBox1.Text+"{{{"+textBox2.Text+"{{{"+textBox3.Text;
                File.WriteAllText(@"C:\Users\" + Environment.UserName + @"\Desktop\pass.jpg", fichier_mdp);
                MessageBox.Show("Mot de passe enregistré avec succès !");
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
