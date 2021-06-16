using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompteAPP;
using Lib_devise;

namespace App_Banque
{
    public partial class AddCompte : Form
    {
        public AddCompte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double solde = double.Parse(textBox1.Text);
            double taux = double.Parse(textBoxTaux.Text);

            if (taux >= 0 && taux <= 100)
            {
                Compte compte1 = new CompteEpargne(new Client("Nouri", "Aimene", "Bd Tah"), new MAD(solde), taux);
                MessageBox.Show(compte1.ToString());
            }
            else
            {
                MessageBox.Show("Taux doit etre compris entre 0 et 100");
            }
        }
    }
}
