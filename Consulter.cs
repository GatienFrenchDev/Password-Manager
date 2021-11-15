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
    }
}
