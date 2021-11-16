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
    public partial class Consulter : Form
    {
        public Consulter()
        {
            InitializeComponent();
        }

        private void Consulter_Load(object sender, EventArgs e)
        {
            String fichier_mdp = File.ReadAllText(@"C:\Users\" + Environment.UserName + @"\Desktop\pass.jpg");
            String[] list = fichier_mdp.Split(new[] { "}}}" }, StringSplitOptions.None);

            //enlève le mot de passe principale de la liste
            list = list.Skip(1).ToArray();

           int i;

            for (i = 0; i < list.Count(); i++)
            {
                comboBox1.Items.Add(list[i].Split(new[] { "{{{" }, StringSplitOptions.None)[0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text != "")
            {
                Clipboard.SetText(label1.Text);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            String fichier_mdp = File.ReadAllText(@"C:\Users\" + Environment.UserName + @"\Desktop\pass.jpg");
            String[] list = fichier_mdp.Split(new[] { "}}}" }, StringSplitOptions.None);

            //enlève le mot de passe principale de la liste
            list = list.Skip(1).ToArray();

            int i;

            for (i = 0; i < list.Count(); i++)
            {
                if(list[i].Split(new[] { "{{{" }, StringSplitOptions.None)[0] == comboBox1.Text)
                {
                    label1.Text = list[i].Split(new[] { "{{{" }, StringSplitOptions.None)[1];
                    label2.Text = Base64Decode(list[i].Split(new[] { "{{{" }, StringSplitOptions.None)[2]);
                }
                
            }

            label2.Visible = true;
            label1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                Clipboard.SetText(label2.Text);
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private void Consulter_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
