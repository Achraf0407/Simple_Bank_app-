using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Banque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cf = new ConvertForm();
            cf.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addClient = new AddClient();
            addClient.Show();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form addCompte = new AddCompte();
            addCompte.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form listClient = new ListClient();
            listClient.Show();
        }
    }
}
