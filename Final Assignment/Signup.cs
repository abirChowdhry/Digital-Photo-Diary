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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signupbackbutton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Signingupbutton_Click(object sender, EventArgs e)
        {

            if (SignupUsernametextBox.Text == "") { MessageBox.Show("Usename Can't Be Empty", "Error"); }
            else if (SignupPasstextBox.Text == "") { MessageBox.Show("Password Can't Be Empty", "Error"); }
            else if (SignupConfirmPasstextBox.Text == "") { MessageBox.Show("Confirm Password Can't Be Empty", "Error"); }
            else if (SignupPasstextBox.Text != SignupConfirmPasstextBox.Text) { MessageBox.Show("Password and Confirm Password Doesn't Match", "Error"); }

            else 
            {

                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection.Open();
                string sql = "Insert into users(username, password) values('" + SignupUsernametextBox.Text + "','" + SignupPasstextBox.Text + "') ";
                SqlCommand command = new SqlCommand(sql, connection);
                int flag = command.ExecuteNonQuery();
                if (flag == 1)
                {
                    connection.Close();
                    MessageBox.Show("Account Created", "Successful");
                }
                else if (flag == 0)
                {
                    connection.Close();
                    MessageBox.Show("Account Can't Be Created!", "Error");
                }
                Login login = new Login();
                login.Show();
                this.Hide();

            }
        }
    }
}
