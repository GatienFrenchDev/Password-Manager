﻿using System;
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
    public partial class ChangerMain : Form
    {
        public ChangerMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Veuillez entrez un mot de passe !");
            }
            else
            {
                String fichier_mdp = File.ReadAllText(@"C:\Users\"+Environment.UserName+@"\Desktop\pass.jpg");
                fichier_mdp.Split('²')[0] = textBox1.Text;
                File.WriteAllText(@"C:\Users\" + Environment.UserName + @"\Desktop\pass.jpg", fichier_mdp);
                MessageBox.Show("Mot de passe principale changé avec succès !");
            }
        }
    }
}
