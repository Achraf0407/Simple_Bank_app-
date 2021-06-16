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

namespace App_Banque
{
    public partial class ListClient : Form
    {
        public ListClient()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        private void ListClient_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Nom", typeof(string));
            table.Columns.Add("Prenom", typeof(string));
            table.Columns.Add("Adresse", typeof(string));

            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"dbClient.txt");
            string[] data;

            for(int i = 0; i < lines.Length; i++)
            {
                data = lines[i].ToString().Split(',');
                string[] row = new string[data.Length];

                for(int j=0; j< data.Length; j++)
                {
                    row[j] = data[j].Trim();
                }

                table.Rows.Add(row);
            }
            button1.Enabled = false;
        }
    }
}
