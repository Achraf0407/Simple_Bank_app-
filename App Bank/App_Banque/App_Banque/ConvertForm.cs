using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_devise;

namespace App_Banque
{
    public partial class ConvertForm : Form
    {
        public ConvertForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double start = double.Parse(textBox1.Text);
            string CurrencyStart = comboBox1.Text;
            string CurrencyEnd = comboBox2.Text;

            Devise d1;
            if(CurrencyStart == "EU")
            {
                d1 = new EU(start);
            }else if (CurrencyStart == "US")
            {
                d1 = new US(start);
            }
            else
            {
                d1 = new MAD(start);
            }

            textBox2.Text = d1.ConvertTo(CurrencyEnd).ToString();

        }
    }
}
