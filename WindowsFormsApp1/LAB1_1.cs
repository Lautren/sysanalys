using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LAB1_1 : Form
    {
        public LAB1_1()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LAB1_1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(" ");
            dt.Columns.Add("z1");
            List<string> m1= new List<string>();
            List<string> m2 = new List<string>();
            m1.Add("z1");
            m1.Add("z2");
            m1.Add("z3");
            m1.Add("z4");
            m1.Add("z5");

            m2.Add("z1");
            m2.Add("z2");
            m2.Add("z3");
            m2.Add("z4");
            m2.Add("z5");
            for (int i = 0; i < 5; i++)
            {
                DataRow r = dt.NewRow();
                r[" "] = m1[i];
                r["z1"] = m2[i];
                dt.Rows.Add(r);
            }

            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
