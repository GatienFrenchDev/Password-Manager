﻿using System;
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
    }
}
