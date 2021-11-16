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
            try
            {
                String fichier_mdp = File.ReadAllText(@"C:\Users\" + Environment.UserName + @"\Desktop\pass.jpg");
                main_mdp = Base64Decode(fichier_mdp.Split('²')[0]);
            }
            catch
            {
                using (FileStream fs = File.Create(@"C:\Users\" + Environment.UserName + @"\Desktop\pass.jpg"))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("YWRtaW4=²");
                    fs.Write(info, 0, info.Length);
                }
            }
            
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
