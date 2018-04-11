using System;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
namespace WindowsFormsApp1
{
    public partial class Login : Form
    {

        public class People
        {
            ObjectId id { set; get; }
            public string email { set; get; }
            public string login { set; get; }
            public string password { set; get; }

        }
        public Login()
        {
            InitializeComponent();
        }

        private void TurnButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
     
        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            var db = client.GetDatabase("SysAnal1");
            var collection = db.GetCollection<People>("users");
            var filter1 = Builders<People>.Filter.Eq("login", LoginBox.Text);
            var result = collection.Find(filter1).ToListAsync();


            if (LoginBox.Text == "" || PasswordBox.Text == "")
            //if (result == null)
            {
                MessageBox.Show("Invalid login or password", "Error", MessageBoxButtons.OK);
            }
            else 
            {
                Form a = new Form1();
                a.Show();
                this.Hide();

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form signup = new SignUp();
            signup.Show();
            this.Hide();

        }
    }
}
