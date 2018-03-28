using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.IO;
using System.Net;
using Firebase.Database;

namespace WindowsFormsApp1
{
   
    public partial class SignUp : Form
    {
      

        public SignUp()
        {
            InitializeComponent();
                
        }
        

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form b = new Login();
            b.Show();
            this.Hide();
        }

        private void TurnButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckRules.Checked == false || LoginButton_1.Text == "" || PasswordButton_1.Text == "" || EmailButton.Text == "")
            {
                MessageBox.Show("Проверьте введеные значения", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(new
                {
                    Email = EmailButton.Text,
                    Login = LoginButton_1.Text,
                    Password = PasswordButton_1.Text,

                });
                
            var request = WebRequest.CreateHttp("https://sysanal1-lautren.firebaseio.com/");
                request.Method = "POST";
                request.ContentType = "application/json";
                var buffer = Encoding.UTF8.GetBytes(json);
                request.ContentLength = buffer.Length;
                request.GetRequestStream().Write(buffer, 0, buffer.Length);
                var response = request.GetResponse();
                json = (new StreamReader(response.GetResponseStream())).ReadToEnd();


                this.Close();
                Form b = new Login();
                b.Show();
                MessageBox.Show("Вы успешно зарегистрированы!", "Выполнено", MessageBoxButtons.OK);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
       
        }
    }
}
