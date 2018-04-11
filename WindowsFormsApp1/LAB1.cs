using System;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Drawing;
using MongoDB.Bson.Serialization.Attributes;

namespace WindowsFormsApp1
{
    public partial class LAB1 : Form
    {
        public int count = 7;
        public string[] val = new string[20];
        public TextBox[] box = new TextBox[20];
        public RadioButton[] radiobutt1 = new RadioButton[20];
        public RadioButton[] radiobutt2 = new RadioButton[20];
        public RadioButton[] radiobutt3 = new RadioButton[20];
        string yes = "Предпочтительнее первая проблема";
        string no = "Предпочтительнее вторая проблема";
        string maybe = "Обе проблемы равнозначны";
        class Choice
        {
            public ObjectId id { set; get; }
            public string Заключение { set; get; }


        }
        public LAB1()
        {
            InitializeComponent();
        }
       
        class Problem
        {
            public ObjectId id { set; get; }
            public string Problems { set; get; }
            
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form1 = new Form1();
            form1.Show();
        }

        private void TurnButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
        
        private async void LAB1_Load(object sender, EventArgs e)  
        {
            
            int y = 0, k = 0, b = 0, z = 0, c = 0;
            MongoClient client = new MongoClient("mongodb://localhost");
            var db = client.GetDatabase("SysAnalys1");
            var collection = db.GetCollection<Problem>("problems");
            var filter = new BsonDocument();
            var eps = await collection.Find(filter).ToListAsync();
            for (int j = 0; j < 3; j++)
            {
                foreach (var d in eps)
                {
                    val[j] = d.Problems;
                    j++;
                }
            }

            foreach (var d in eps)
            {                   
                c++; 
            }
            var rez = (c - 1) * (c - 2);
            var rez1 = (c - 1) * (c - 3);
            for (int j = 0; j < rez; j++)
            {
                
                box[j] = new TextBox();
                box[j].Location = new Point(30, 30);
                box[j].Size = new Size(1000, 20);
                box[j].Enabled = false;
                
                flowLayoutPanel1.Controls.Add(box[j]);

                radiobutt1[j] = new RadioButton();
                radiobutt1[j].Location = new Point(30, 30);
                radiobutt1[j].Size = new Size(206, 20);
                radiobutt1[j].Text = yes;
                flowLayoutPanel1.Controls.Add(radiobutt1[j]);

                radiobutt2[j] = new RadioButton();
                radiobutt2[j].Location = new Point(30, 30);
                radiobutt2[j].Text = no;
                radiobutt2[j].Size = new Size(206, 20);
                flowLayoutPanel1.Controls.Add(radiobutt2[j]);

                radiobutt3[j] = new RadioButton();
                radiobutt3[j].Location = new Point(30, 30);
                radiobutt3[j].Text = maybe;
                radiobutt3[j].Size = new Size(206, 20);
                flowLayoutPanel1.Controls.Add(radiobutt3[j]);
            }                  
            for (int a=0; a < rez; a++)
            {
                z = a;
                for (k=y; z < rez1; k++, z++)
                {
                    int p = z + 1;
                    if (val[p] != null && val[b] != null)
                    {
                        box[k].Text = "Проблема " + b + ":" + val[b] + " и " + "Проблема " + p + ":"+ val[p];
                    }
                }
                y = (c - a)*(a - c + 5) - 1;
                
                b++;

            }


        }

        public string L;
        public double[] c = new double[7];
        public double[] v = new double[7];
        public double r = 0;
        public double[,] value = new double[7, 7];


        private async void testbutton_Click(object sender, EventArgs e)
        {
            
            MongoClient client = new MongoClient("mongodb://localhost");
            var db = client.GetDatabase("SysAnalys1");
            var collection = db.GetCollection<Choice>("users");

            value[0, 1] = 0.5; value[1, 0] = 0.5;
            value[0, 2] = 0.5; value[2, 0] = 0.5;
            value[0, 3] = 0.5; value[3, 0] = 0.5;
            value[0, 4] = 1; value[4, 0] = 0;
            value[0, 5] = 1; value[5, 0] = 0;
            value[0, 6] = 0.5; value[6, 0] = 0.5;

            value[1, 2] = 0; value[2, 1] = 1;
            value[1, 3] = 0.5; value[3, 1] = 0.5;
            value[1, 4] = 0.5; value[4, 1] = 0.5;
            value[1, 5] = 1; value[5, 1] = 0;
            value[1, 6] = 0; value[6, 1] = 1;

            value[2, 3] = 0.5; value[3, 2] = 0.5;
            value[2, 4] = 1; value[4, 2] = 0;
            value[2, 5] = 1; value[5, 2] = 0;
            value[2, 6] = 0; value[6, 2] = 1;

            value[3, 4] = 1; value[4, 3] = 0;
            value[3, 5] = 1; value[5, 3] = 0;
            value[3, 6] = 0; value[6, 3] = 1;

            value[4, 5] = 1; value[5, 4] = 0;
            value[4, 6] = 0; value[6, 4] = 1;

            value[5, 6] = 0; value[6, 5] = 1;

            for (int i = 0; i < 7; i++)
            {
                c[i] = value[i, 0] + value[i, 1] + value[i, 2] + value[i, 3] + value[i, 4] + value[i, 5] + value[i, 6];
                r += value[i, 0] + value[i, 1] + value[i, 2] + value[i, 3] + value[i, 4] + value[i, 5] + value[i, 6];
                c[i] = Math.Round(c[i], 3);
                
            }
            for (int j = 0; j < 7; j++)
            {
                v[j] = c[j] / r;
                v[j] = Math.Round(v[j], 5);
                key[j] = v[j];
            }
            L = "В порядке возрастания представлены альтернативы: ";
            Array.Sort(v);
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (key[j] == v[i])
                    {
                        
                        L += "Z" + j + " ";
                    }
                }
            }
            Choice docum1 = new Choice
            {
                Заключение = L,
            };
            await collection.InsertOneAsync(docum1);
        }

        public double[] key = new double[7];
        private async void result1_Click(object sender, EventArgs e)
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            var db = client.GetDatabase("SysAnalys1");
            var collection = db.GetCollection<Choice>("users");

            count++;
            for (int i = 0; i < count; i++)
            {
                c[i] = value[i, 0] + value[i, 1] + value[i, 2] + value[i, 3] + value[i, 4] + value[i, 5] + value[i, 6];
                r += value[i, 0] + value[i, 1] + value[i, 2] + value[i, 3] + value[i, 4] + value[i, 5] + value[i, 6];
                c[i] = Math.Round(c[i], 3);
                
            }
            for (int j = 0; j < count; j++)
            {
                v[j] = c[j] / r;
                v[j] = Math.Round(v[j], 3);
                key[j] = v[j];
            }
            Array.Sort(v);
            L = "В порядке возрастания представлены альтернативы: ";
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (key[j] == v[i])
                    {
                        L += "Z" + j + " ";
                    }
                }
            }
            Choice docum1 = new Choice
            {
                Заключение = L,
            };
            await collection.InsertOneAsync(docum1);
            Form d = new Results();
            d.Show();
        }
    }  
}

//private void Yes1_CheckedChanged(object sender, EventArgs e)
//{           
//    if (Yes1.Checked)
//    {
//        if (textBox1.Text == "Приглашение популярной поп-группы предпочтительнее проведения рекламной акции")
//        {
//            value[0, 1] = 1;
//            value[1, 0] = 0;
//        }
//        else if (textBox1.Text == "Приглашение популярной поп-группы предпочтительнее скидки каждому покупателю")
//        {
//            value[0, 2] = 1;
//            value[2, 0] = 0;
//        }
//        else if (textBox1.Text == "Приглашение популярной поп-группы предпочтительнее раздачи призов")
//        {
//            value[0, 3] = 1;
//            value[3, 0] = 0;
//        }
//        else if (textBox1.Text == "Приглашение популярной поп-группы предпочтительнее приглашения на открытие администрации города")
//        {
//            value[0, 4] = 1;
//            value[4, 0] = 0;
//        }
//        else if (textBox1.Text == "Приглашение популярной поп-группы предпочтительнее организации театрального произведения")
//        {
//            value[0, 5] = 1;
//            value[5, 0] = 0;
//        }
//        else if (textBox1.Text == "Приглашение популярной поп-группы предпочтительнее устройства лотереи")
//        {
//            value[0, 6] = 1;
//            value[6, 0] = 0;
//        }
//    }
//}

//private void No1_CheckedChanged(object sender, EventArgs e)
//{
//    if (No1.Checked)
//    {
//        if (textBox1.Text == "Приглашение популярной поп-группы предпочтительнее проведения рекламной акции")
//        {
//            value[0, 1] = 0;
//            value[1, 0] = 1;
//        }
//        else if (textBox1.Text == "Приглашение популярной поп-группы предпочтительнее скидки каждому покупателю")
//        {
//            value[0, 2] = 0;
//            value[2, 0] = 1;
//        }
//        else if (textBox1.Text == "Приглашение популярной поп-группы предпочтительнее раздачи призов")
//        {
//            value[0, 3] = 0;
//            value[3, 0] = 1;
//        }
//        else if (textBox1.Text == "Приглашение популярной поп-группы предпочтительнее приглашения на открытие администрации города")
//        {
//            value[0, 4] = 0;
//            value[4, 0] = 1;
//        }
//        else if (textBox1.Text == "Приглашение популярной поп-группы предпочтительнее организации театрального произведения")
//        {
//            value[0, 5] = 0;
//            value[5, 0] = 1;
//        }
//        else if (textBox1.Text == "Приглашение популярной поп-группы предпочтительнее устройства лотереи")
//        {
//            value[0, 6] = 0;
//            value[6, 0] = 1;
//        }
//    }
//}

//private void Middle1_CheckedChanged(object sender, EventArgs e)
//{
//    if (Middle1.Checked)
//    {
//        if (textBox1.Text == "Приглашение популярной поп-группы предпочтительнее проведения рекламной акции")
//        {
//            value[0, 1] = 0.5;
//            value[1, 0] = 0.5;
//        }
//        else if (textBox1.Text == "Приглашение популярной поп-группы предпочтительнее скидки каждому покупателю")
//        {
//            value[0, 2] = 0.5;
//            value[2, 0] = 0.5;
//        }
//        else if (textBox1.Text == "Приглашение популярной поп-группы предпочтительнее раздачи призов")
//        {
//            value[0, 3] = 0.5;
//            value[3, 0] = 0.5;
//        }
//        else if (textBox1.Text == "Приглашение популярной поп-группы предпочтительнее приглашения на открытие администрации города")
//        {
//            value[0, 4] = 0.5;
//            value[4, 0] = 0.5;
//        }
//        else if (textBox1.Text == "Приглашение популярной поп-группы предпочтительнее организации театрального произведения")
//        {
//            value[0, 5] = 0.5;
//            value[5, 0] = 0.5;
//        }
//        else if (textBox1.Text == "Приглашение популярной поп-группы предпочтительнее устройства лотереи")
//        {
//            value[0, 6] = 0.5;
//            value[6, 0] = 0.5;
//        }
//    }
//}