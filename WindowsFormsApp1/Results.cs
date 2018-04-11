using System;
using System.Data;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using System.ComponentModel;

namespace WindowsFormsApp1
{
    public partial class Results : Form
    {
        class Choice
        {
            public ObjectId Id { get; set; }
            public string C { set; get; }
            public double R { set; get; }
            public string V { set; get; }
        }
        public Results()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Form c = new LAB1();
            c.Show();
            this.Hide();
        }

        private void TurnButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            LAB1 lab1 = new LAB1();
            MongoClient client = new MongoClient("mongodb://localhost");
            var db = client.GetDatabase("SysAnalys1");
            var collection = db.GetCollection<Choice>("users");
            BindingList<Choice> doclist = new BindingList<Choice>();

            foreach (var deger in collection.Find(_ => true).ToList())
            {
                doclist.Add(deger);
                Application.DoEvents();
            }
            dataGridView1.DataSource = doclist;

        }

        private void UnturnButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
