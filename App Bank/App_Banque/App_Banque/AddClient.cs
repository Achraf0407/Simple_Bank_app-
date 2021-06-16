using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompteAPP;

namespace App_Banque
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = textBox1.Text;
            string prenom = textBox2.Text;
            string adresse = textBox3.Text;

            Client cl = new Client(nom, prenom, adresse);
            string res = "nom=" + nom + " , prenom=" + prenom + " , adresse=" + adresse;
            
            StreamReader sr = new StreamReader(@"dbClient.txt");
            string oldData = sr.ReadLine();
            sr.Close();
            
            StreamWriter sw = new StreamWriter(@"dbClient.txt");
            sw.WriteLine(oldData + (Environment.NewLine) + res);
            sw.Close();

            MessageBox.Show("Client added successfully");
        }
    }
}
