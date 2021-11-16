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
                String[] list = fichier_mdp.Split(new[] { "}}}" }, StringSplitOptions.None);
                list = list.Skip(1).ToArray();
                int i;
                for (i = 0; i < list.Count(); i++)
                {
                    if(textBox1.Text == (list[i].Split(new[] { "{{{" }, StringSplitOptions.None)[0]))
                    {
                        MessageBox.Show("Nom déjà pris !");
                        return;
                    }
                }
                fichier_mdp = fichier_mdp + "}}}" + textBox1.Text + "{{{" + textBox2.Text + "{{{" + Base64Encode(textBox3.Text);
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

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
