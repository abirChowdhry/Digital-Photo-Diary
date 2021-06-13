using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Assignment
{
    public partial class Login : Form
    {
        Events events = new Events(); 
        public Login()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {

            if (UsernametextBox.Text == "") { MessageBox.Show("Username Can't Be Empty", "Error"); }
            else if (PasstextBox.Text == "") { MessageBox.Show("Password Can't Be Empty", "Error"); }
            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection.Open();
                string sql = "Select * from Users where username = '" + UsernametextBox.Text + "' and password = '" + PasstextBox.Text + "'";
                //string sql2 = "select id from users where username = '" + UsernametextBox.Text + "' and password = '" + PasstextBox.Text + "'";


                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    MyPhotoDiary myPhotoDiary = new MyPhotoDiary();
                    myPhotoDiary.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("No User Found", "Error!");
                }
            }

        }

        private void Signupbutton_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
