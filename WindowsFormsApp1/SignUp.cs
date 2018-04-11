using System;
using System.Windows.Forms;
using Firebase.Database;
using FireSharp.Config;
using FireSharp.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WindowsFormsApp1
{
   
    public partial class SignUp : Form
    {

       
        //protected const string BasePath = "https://sysanal1.firebaseio.com/";
        //protected const string FirebaseSecret = "fubr9j2Kany9KU3SHCIHBLm142anWCzvlBs1D977";
        
        public SignUp()
        {
            InitializeComponent();
                
        }

        public class People
        {
            public string email {set; get;}
            public string login { set; get; }
            public string password { set; get; }

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

        private async void button1_Click(object sender, EventArgs e)
        {
            if (CheckRules.Checked == false || LoginButton_1.Text == "" || PasswordButton_1.Text == "" || EmailButton.Text == "")
            {
                MessageBox.Show("Проверьте введеные значения", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                
                MongoClient client = new MongoClient("mongodb://localhost");
                var db = client.GetDatabase("SysAnal1");
                var collection = db.GetCollection<People>("users");

                People docum = new People
                {
                  
                    email = EmailButton.Text,
                    login = LoginButton_1.Text,
                    password = PasswordButton_1.Text
                };
                await collection.InsertOneAsync(docum);
                
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
//var json = Newtonsoft.Json.JsonConvert.SerializeObject(new
//{
//    Email = EmailButton.Text,
//    Login = LoginButton_1.Text,
//    Password = PasswordButton_1.Text,

//})

//var request = WebRequest.CreateHttp("https://sysanal1-lautren.firebaseio.com/");
//    request.Method = "POST";
//    request.ContentType = "application/json";
//    var buffer = Encoding.UTF8.GetBytes(json);
//    request.ContentLength = buffer.Length;
//    request.GetRequestStream().Write(buffer, 0, buffer.Length);
//    var response = request.GetResponse();
//    json = (new StreamReader(response.GetResponseStream())).ReadToEnd();