using System;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class LAB1 : Form
    {
        public int count = 6;
        class Choice
        {
            public string C { set; get; }
            public double R { set; get; }
            public string V { set; get; }

        }
        public LAB1()
        {
            InitializeComponent();
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

        private async void button1_Click(object sender, EventArgs e)
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            var db = client.GetDatabase("SysAnalys1");
            var collection = db.GetCollection<Choice>("users");
            

            count++;
            for (int i = 0; i < count; i++)
            {
                c[i] = value[i, 0] + value[i, 1] + value[i, 2] + value[i, 3] + value[i, 4] + value[i, 5] + value[i, 6];
                r+= value[i, 0] + value[i, 1] + value[i, 2] + value[i, 3] + value[i, 4] + value[i, 5] + value[i, 6];
                
                L += i + "=" + c[i] + " ";
                
            }
            for (int j = 0; j < count; j++)
            {
                v[j] = c[j] / r;
                
                K += j + "=" + v[j] + " ";
                
            }

            Choice docum1 = new Choice
            {
                V = K,
                R = r,
                C = L
            };
            await collection.InsertOneAsync(docum1);
        }

        private void LAB1_Load(object sender, EventArgs e)  
        {
            
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            comboBox1.Items.Add("Приглашение популярной поп-группы предпочтительнее проведения рекламной акции");
            comboBox1.Items.Add("Приглашение популярной поп-группы предпочтительнее скидки каждому покупателю");
            comboBox1.Items.Add("Приглашение популярной поп-группы предпочтительнее раздачи призов");
            comboBox1.Items.Add("Приглашение популярной поп-группы предпочтительнее приглашения на открытие администрации города");
            comboBox1.Items.Add("Приглашение популярной поп-группы предпочтительнее организации театрального произведения");
            comboBox1.Items.Add("Приглашение популярной поп-группы предпочтительнее устройства лотереи");

            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            comboBox2.Items.Add("Проведение рекламной акции предпочтительнее скидки каждому покупателю");
            comboBox2.Items.Add("Проведение рекламной акции предпочтительнее раздачи призов");
            comboBox2.Items.Add("Проведение рекламной акции предпочтительнее приглашения на открытие администрации города");
            comboBox2.Items.Add("Проведение рекламной акции предпочтительнее организации театрального произведения");
            comboBox2.Items.Add("Проведение рекламной акции предпочтительнее устройства лотереи");

            comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            comboBox3.Items.Add("Скидка каждому покупателю предпочтительнее раздачи призов");
            comboBox3.Items.Add("Скидка каждому покупателю предпочтительнее приглашения на открытие администрации города");
            comboBox3.Items.Add("Скидка каждому покупателю предпочтительнее организации театрального произведения");
            comboBox3.Items.Add("Скидка каждому покупателю предпочтительнее устройства лотереи");

            comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            comboBox4.Items.Add("Раздача призов предпочтительнее приглашения на открытие администрации города");
            comboBox4.Items.Add("Раздача призов предпочтительнее организации театрального произведения");
            comboBox4.Items.Add("Раздача призов предпочтительнее устройства лотереи");
 
            comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            comboBox5.Items.Add("Приглашение на открытие администрации города предпочтительнее организации театрального произведения");
            comboBox5.Items.Add("Приглашение на открытие администрации города предпочтительнее устройства лотереи");

            comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            comboBox6.Items.Add("Организация театрального произведения предпочтительнее устройства лотереи");
            
        }

        private void addComboBox_Click(object sender, EventArgs e)
        {
           
        }


        public string K;
        public string L;
        public double[] c = new double[10];
        public double[] v = new double[10];
        public double r = 0;
        public double[,] value = new double[10, 10];
        private void Yes1_CheckedChanged(object sender, EventArgs e)
        {           
            if (Yes1.Checked)
            {
                if (comboBox1.Text == "Приглашение популярной поп-группы предпочтительнее проведения рекламной акции")
                {
                    value[0, 1] = 1;
                    value[1, 0] = 0;
                }
                else if (comboBox1.Text == "Приглашение популярной поп-группы предпочтительнее скидки каждому покупателю")
                {
                    value[0, 2] = 1;
                    value[2, 0] = 0;
                }
                else if (comboBox1.Text == "Приглашение популярной поп-группы предпочтительнее раздачи призов")
                {
                    value[0, 3] = 1;
                    value[3, 0] = 0;
                }
                else if (comboBox1.Text == "Приглашение популярной поп-группы предпочтительнее приглашения на открытие администрации города")
                {
                    value[0, 4] = 1;
                    value[4, 0] = 0;
                }
                else if (comboBox1.Text == "Приглашение популярной поп-группы предпочтительнее организации театрального произведения")
                {
                    value[0, 5] = 1;
                    value[5, 0] = 0;
                }
                else if (comboBox1.Text == "Приглашение популярной поп-группы предпочтительнее устройства лотереи")
                {
                    value[0, 6] = 1;
                    value[6, 0] = 0;
                }
            }
        }

        private void No1_CheckedChanged(object sender, EventArgs e)
        {
            if (No1.Checked)
            {
                if (comboBox1.Text == "Приглашение популярной поп-группы предпочтительнее проведения рекламной акции")
                {
                    value[0, 1] = 0;
                    value[1, 0] = 1;
                }
                else if (comboBox1.Text == "Приглашение популярной поп-группы предпочтительнее скидки каждому покупателю")
                {
                    value[0, 2] = 0;
                    value[2, 0] = 1;
                }
                else if (comboBox1.Text == "Приглашение популярной поп-группы предпочтительнее раздачи призов")
                {
                    value[0, 3] = 0;
                    value[3, 0] = 1;
                }
                else if (comboBox1.Text == "Приглашение популярной поп-группы предпочтительнее приглашения на открытие администрации города")
                {
                    value[0, 4] = 0;
                    value[4, 0] = 1;
                }
                else if (comboBox1.Text == "Приглашение популярной поп-группы предпочтительнее организации театрального произведения")
                {
                    value[0, 5] = 0;
                    value[5, 0] = 1;
                }
                else if (comboBox1.Text == "Приглашение популярной поп-группы предпочтительнее устройства лотереи")
                {
                    value[0, 6] = 0;
                    value[6, 0] = 1;
                }
            }
        }

        private void Middle1_CheckedChanged(object sender, EventArgs e)
        {
            if (Middle1.Checked)
            {
                if (comboBox1.Text == "Приглашение популярной поп-группы предпочтительнее проведения рекламной акции")
                {
                    value[0, 1] = 0.5;
                    value[1, 0] = 0.5;
                }
                else if (comboBox1.Text == "Приглашение популярной поп-группы предпочтительнее скидки каждому покупателю")
                {
                    value[0, 2] = 0.5;
                    value[2, 0] = 0.5;
                }
                else if (comboBox1.Text == "Приглашение популярной поп-группы предпочтительнее раздачи призов")
                {
                    value[0, 3] = 0.5;
                    value[3, 0] = 0.5;
                }
                else if (comboBox1.Text == "Приглашение популярной поп-группы предпочтительнее приглашения на открытие администрации города")
                {
                    value[0, 4] = 0.5;
                    value[4, 0] = 0.5;
                }
                else if (comboBox1.Text == "Приглашение популярной поп-группы предпочтительнее организации театрального произведения")
                {
                    value[0, 5] = 0.5;
                    value[5, 0] = 0.5;
                }
                else if (comboBox1.Text == "Приглашение популярной поп-группы предпочтительнее устройства лотереи")
                {
                    value[0, 6] = 0.5;
                    value[6, 0] = 0.5;
                }
            }
        }

        private void No2_CheckedChanged(object sender, EventArgs e)
        {
            if (No2.Checked)
            {
                if (comboBox2.Text == "Проведения рекламной акции предпочтительнее скидки каждому покупателю")
                {
                    value[1, 2] = 0;
                    value[2, 1] = 1;
                }
                else if (comboBox2.Text == "Проведения рекламной акции предпочтительнее раздачи призов")
                {
                    value[1, 3] = 0;
                    value[3, 1] = 1;
                }
                else if (comboBox2.Text == "Проведения рекламной акции предпочтительнее приглашения на открытие администрации города")
                {
                    value[1, 4] = 0;
                    value[4, 1] = 1;
                }
                else if (comboBox2.Text == "Проведения рекламной акции предпочтительнее организации театрального произведения")
                {
                    value[1, 5] = 0;
                    value[5, 1] = 1;
                }
                else if (comboBox2.Text == "Проведения рекламной акции предпочтительнее устройства лотереи")
                {
                    value[1, 6] = 0;
                    value[6, 1] = 1;
                }
            }
        }

        private void Middle2_CheckedChanged(object sender, EventArgs e)
        {
            if (Middle2.Checked)
            {
                if (comboBox2.Text == "Проведения рекламной акции предпочтительнее скидки каждому покупателю")
                {
                    value[1, 2] = 0.5;
                    value[2, 1] = 0.5;
                }
                else if (comboBox2.Text == "Проведения рекламной акции предпочтительнее раздачи призов")
                {
                    value[1, 3] = 0.5;
                    value[3, 1] = 0.5;
                }
                else if (comboBox2.Text == "Проведения рекламной акции предпочтительнее приглашения на открытие администрации города")
                {
                    value[1, 4] = 0.5;
                    value[4, 1] = 0.5;
                }
                else if (comboBox2.Text == "Проведения рекламной акции предпочтительнее организации театрального произведения")
                {
                    value[1, 5] = 0.5;
                    value[5, 1] = 0.5;
                }
                else if (comboBox2.Text == "Проведения рекламной акции предпочтительнее устройства лотереи")
                {
                    value[1, 6] = 0.5;
                    value[6, 1] = 0.5;
                }
            }
        }

        private void No3_CheckedChanged(object sender, EventArgs e)
        {
            if (No3.Checked)
            {
                if (comboBox3.Text == "Скидки каждому покупателю предпочтительнее раздачи призов")
                {
                    value[2, 3] = 0;
                    value[3, 2] = 1;
                }
                else if (comboBox3.Text == "Скидки каждому покупателю предпочтительнее приглашения на открытие администрации города")
                {
                    value[2, 4] = 0;
                    value[4, 2] = 1;
                }
                else if (comboBox3.Text == "Скидки каждому покупателю предпочтительнее организации театрального произведения")
                {
                    value[2, 5] = 0;
                    value[5, 2] = 1;
                }
                else if (comboBox3.Text == "Скидки каждому покупателю предпочтительнее устройства лотереи")
                {
                    value[2, 6] = 0;
                    value[6, 2] = 1;
                }
            }
        }

        private void Middle3_CheckedChanged(object sender, EventArgs e)
        {
            if (Middle3.Checked)
            {
                if (comboBox3.Text == "Скидки каждому покупателю предпочтительнее раздачи призов")
                {
                    value[2, 3] = 0.5;
                    value[3, 2] = 0.5;
                }
                else if (comboBox3.Text == "Скидки каждому покупателю предпочтительнее приглашения на открытие администрации города")
                {
                    value[2, 4] = 0.5;
                    value[4, 2] = 0.5;
                }
                else if (comboBox3.Text == "Скидки каждому покупателю предпочтительнее организации театрального произведения")
                {
                    value[2, 5] = 0.5;
                    value[5, 2] = 0.5;
                }
                else if (comboBox3.Text == "Скидки каждому покупателю предпочтительнее устройства лотереи")
                {
                    value[2, 6] = 0.5;
                    value[6, 2] = 0.5;
                }
            }
        }

        private void No4_CheckedChanged(object sender, EventArgs e)
        {
            if (No4.Checked)
            {
                if (comboBox4.Text == "Раздача призов предпочтительнее приглашения на открытие администрации города")
                {
                    value[3, 4] = 0;
                    value[4, 3] = 1;
                }
                else if (comboBox4.Text == "Раздача призов предпочтительнее организации театрального произведения")
                {
                    value[3, 5] = 0;
                    value[5, 3] = 1;
                }
                else if (comboBox4.Text == "Раздача призов предпочтительнее устройства лотереи")
                {
                    value[3, 6] = 0;
                    value[6, 3] = 1;
                }
            }
        }

        private void Middle4_CheckedChanged(object sender, EventArgs e)
        {
            if (Middle4.Checked)
            {
                if (comboBox4.Text == "Раздача призов предпочтительнее приглашения на открытие администрации города")
                {
                    value[3, 4] = 0.5;
                    value[4, 3] = 0.5;
                }
                else if (comboBox4.Text == "Раздача призов предпочтительнее организации театрального произведения")
                {
                    value[3, 5] = 0.5;
                    value[5, 3] = 0.5;
                }
                else if (comboBox4.Text == "Раздача призов предпочтительнее устройства лотереи")
                {
                    value[3, 6] = 0.5;
                    value[6, 3] = 0.5;
                }
            }
        }

        private void No5_CheckedChanged(object sender, EventArgs e)
        {
            if (No5.Checked)
            {
                if (comboBox5.Text == "Открытие администрации города предпочтительнее организации театрального произведения")
                {
                    value[4, 5] = 0;
                    value[5, 4] = 1;
                }
                else if (comboBox5.Text == "Открытие администрации города предпочтительнее устройства лотереи")
                {
                    value[4, 6] = 0;
                    value[6, 4] = 1;
                }
            }
        }

        private void Middle5_CheckedChanged(object sender, EventArgs e)
        {
            if (Middle5.Checked)
            {
                if (comboBox5.Text == "Открытие администрации города предпочтительнее организации театрального произведения")
                {
                    value[4, 5] = 0.5;
                    value[5, 4] = 0.5;
                }
                else if (comboBox5.Text == "Открытие администрации города предпочтительнее устройства лотереи")
                {
                    value[4, 6] = 0.5;
                    value[6, 4] = 0.5;
                }
            }
        }

        private void Yes2_CheckedChanged(object sender, EventArgs e)
        {
            if (Yes2.Checked)
            {
                if (comboBox2.Text == "Проведения рекламной акции предпочтительнее скидки каждому покупателю")
                {
                    value[1, 2] = 1;
                    value[2, 1] = 0;
                }
                else if (comboBox2.Text == "Проведения рекламной акции предпочтительнее раздачи призов")
                {
                    value[1, 3] = 1;
                    value[3, 1] = 0;
                }
                else if (comboBox2.Text == "Проведения рекламной акции предпочтительнее приглашения на открытие администрации города")
                {
                    value[1, 4] = 1;
                    value[4, 1] = 0;
                }
                else if (comboBox2.Text == "Проведения рекламной акции предпочтительнее организации театрального произведения")
                {
                    value[1, 5] = 1;
                    value[5, 1] = 0;
                }
                else if (comboBox2.Text == "Проведения рекламной акции предпочтительнее устройства лотереи")
                {
                    value[1, 6] = 1;
                    value[6, 1] = 0;
                }
            }

        }

        private void Yes3_CheckedChanged(object sender, EventArgs e)
        {
            if (Yes3.Checked)
            {
                if (comboBox3.Text == "Скидки каждому покупателю предпочтительнее раздачи призов")
                {
                    value[2, 3] = 1;
                    value[3, 2] = 0;
                }
                else if (comboBox3.Text == "Скидки каждому покупателю предпочтительнее приглашения на открытие администрации города")
                {
                    value[2, 4] = 1;
                    value[4, 2] = 0;
                }
                else if (comboBox3.Text == "Скидки каждому покупателю предпочтительнее организации театрального произведения")
                {
                    value[2, 5] = 1;
                    value[5, 2] = 0;
                }
                else if (comboBox3.Text == "Скидки каждому покупателю предпочтительнее устройства лотереи")
                {
                    value[2, 6] = 1;
                    value[6, 2] = 0;
                }
            }
        }

        private void Yes4_CheckedChanged(object sender, EventArgs e)
        {
            if (Yes4.Checked)
            {
                if (comboBox4.Text == "Раздача призов предпочтительнее приглашения на открытие администрации города")
                {
                    value[3, 4] = 1;
                    value[4, 3] = 0;
                }
                else if (comboBox4.Text == "Раздача призов предпочтительнее организации театрального произведения")
                {
                    value[3, 5] = 1;
                    value[5, 3] = 0;
                }
                else if (comboBox4.Text == "Раздача призов предпочтительнее устройства лотереи")
                {
                    value[3, 6] = 1;
                    value[6, 3] = 0;
                }
            }
        }

        private void Yes5_CheckedChanged(object sender, EventArgs e)
        {
            if (Yes5.Checked)
            {
                if (comboBox5.Text == "Открытие администрации города предпочтительнее организации театрального произведения")
                {
                    value[4, 5] = 1;
                    value[5, 4] = 0;
                }
                else if (comboBox5.Text == "Открытие администрации города предпочтительнее устройства лотереи")
                {
                    value[4, 6] = 1;
                    value[6, 4] = 0;
                }
            }
        }

        private void Yes6_CheckedChanged(object sender, EventArgs e)
        {
            if (Yes6.Checked)
            {
                if (comboBox6.Text == "Организация театрального произведения предпочтительнее устройства лотереи")
                {
                    value[5, 6] = 1;
                    value[6, 5] = 0;
                }
            }
        }

        private void No6_CheckedChanged(object sender, EventArgs e)
        {
            if (No6.Checked)
            {
                if (comboBox6.Text == "Организация театрального произведения предпочтительнее устройства лотереи")
                {
                    value[5, 6] = 0;
                    value[6, 5] = 1;
                }
            }
        }

        private void Middle6_CheckedChanged(object sender, EventArgs e)
        {
            if (Middle6.Checked)
            {
                if (comboBox6.Text == "Организация театрального произведения предпочтительнее устройства лотереи")
                {
                    value[5, 6] = 0.5;
                    value[6, 5] = 0.5;
                }
            }
        }

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
                L += i + "=" + c[i] + " ";
            }
            for (int j = 0; j < 7; j++)
            {
                v[j] = c[j] / r;
                K += j + "=" + v[j] + " ";
            }
            Choice docum1 = new Choice
            {

                V = K,
                R = r,
                C = L
            };
            await collection.InsertOneAsync(docum1);
        }

        private void result1_Click(object sender, EventArgs e)
        {
            Form d = new Results();
            d.Show();
            this.Hide();
        }
    }  
}

