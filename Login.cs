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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private string main_mdp = string.Empty;
        private void Login_Load(object sender, EventArgs e)
        {
            String fichier_mdp = File.ReadAllText(@"C:\Users\" + Environment.UserName + @"\Desktop\pass.jpg");
            main_mdp = fichier_mdp.Split('²')[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == main_mdp)
            {
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
        }
    }
}
