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
    public partial class supp : Form
    {
        public supp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String fichier_mdp = File.ReadAllText(@"C:\Users\" + Environment.UserName + @"\Desktop\pass.jpg");
            String[] list = fichier_mdp.Split(new[] { "}}}" }, StringSplitOptions.None);
            if (comboBox1.Text != "")
            {
                int i;

                for (i = 0; i < list.Count(); i++)
                {
                    if (comboBox1.Text == (list[i].Split(new[] { "{{{" }, StringSplitOptions.None)[0]))
                    {
                        list = list.Skip(i).ToArray();
                        MessageBox.Show("Site supprimé avec succès !");
                        File.WriteAllText(@"C:\Users\" + Environment.UserName + @"\Desktop\pass.jpg", String.Concat(list));
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuilez choisir un site !");
                return;
            }
        }

        private void supp_Load(object sender, EventArgs e)
        {
            String fichier_mdp = File.ReadAllText(@"C:\Users\" + Environment.UserName + @"\Desktop\pass.jpg");
            String[] list = fichier_mdp.Split(new[] { "}}}" }, StringSplitOptions.None);
            list = list.Skip(1).ToArray();

            int i;

            for (i = 0; i < list.Count(); i++)
            {
                comboBox1.Items.Add(list[i].Split(new[] { "{{{" }, StringSplitOptions.None)[0]);
            }
        }
    }
}
