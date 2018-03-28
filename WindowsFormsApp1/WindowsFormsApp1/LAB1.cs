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
    public partial class LAB1 : Form
    {
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

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
