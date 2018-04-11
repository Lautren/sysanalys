using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WindowsFormsApp1
{
    public partial class addV : Form
    {
        public string N;
       

        public addV()
        {
            InitializeComponent();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        class Problem
        {
            public ObjectId id { set; get; }
            public string Problems { set; get; }
        }
        public int n;
        public TextBox[] box = new TextBox[50];

        public TextBox[] box1 = new TextBox[50];
        private async void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != null)
            {
                MongoClient client = new MongoClient("mongodb://localhost");
                var db = client.GetDatabase("SysAnalys1");
                var collection = db.GetCollection<Problem>("problems");
                var filter = new BsonDocument();
                await collection.DeleteManyAsync(filter);
                N = textBox3.Text;
                n = Int32.Parse(N);
                textBox2.Visible = false;
                textBox3.Visible = false;
                button1.Visible = false;
                button2.Visible = true;
                flowLayoutPanel1.Visible = true;
                
                for (int j = 0; j < n; j++)
                {
                    box[j] = new TextBox();
                    box[j].Location = new Point(30, 30);
                    box[j].Text = "Проблема " + j.ToString();
                    box[j].Enabled = false;
                    flowLayoutPanel1.Controls.Add(box[j]);
                    
                    box1[j] = new TextBox();
                    box1[j].Location = new Point(20, 20);
                    box1[j].Size = new Size(608, 20);
                    box1[j].Name = "textbox" + j;
                    flowLayoutPanel1.Controls.Add(box1[j]);
                }

            } else { MessageBox.Show("Не было введено целое значение"); }
        }
    
        private void addV_Load(object sender, EventArgs e)
        {

        }
       
        private async void button2_Click(object sender, EventArgs e)
        {
            
            MongoClient client = new MongoClient("mongodb://localhost");
            var db = client.GetDatabase("SysAnalys1");
            var collection = db.GetCollection<Problem>("problems");
            
            for (int j = 0; j < n; j++)
            {
                Problem docum1 = new Problem
                {
                    
                    Problems = box1[j].Text,
                };
                await collection.InsertOneAsync(docum1);
            }
            this.Hide();
            Form a = new LAB1();
            a.Show(); 
        }
    }
}
