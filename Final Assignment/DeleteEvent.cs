using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Assignment
{
    public partial class DeleteEvent : Form
    {
        public DeleteEvent()
        {
            InitializeComponent();
        }

        private void DeleteEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SearchDletebutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();

            string sql = "Select * from events where eventid = '"+EventIdtextBox.Text+"'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
               // MemoryStream ms = new MemoryStream((byte[])reader["Photo"]);
                DeletepictureBox.Image = GetPhoto((byte[])reader["photo"]);
                DeleteStroytextBox.Text = reader["story"].ToString();
                DeleteDatetextBox.Text = reader["Date"].ToString();
            }

            else 
            {
                DeleteDatetextBox.Text = DeleteDatetextBox.Text = "";
                MessageBox.Show("Event Not Found!", "Error");
            }

            connection.Close();
        }

       private Image GetPhoto(byte[] value)
        {
            MemoryStream memoryStream = new MemoryStream(value);
            return Image.FromStream(memoryStream);
        }
       
        private void DeleteBackbutton_Click(object sender, EventArgs e)
        {

            MyPhotoDiary myPhotoDiary = new MyPhotoDiary();
            myPhotoDiary.Show();
            this.Hide();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();

            string sql = "delete from events where eventid = '"+EventIdtextBox.Text+"'";
            SqlCommand command = new SqlCommand(sql, connection);
            int flag = command.ExecuteNonQuery();

            if (flag == 0)
            {
                MessageBox.Show("Event Not Deleted!", "Error");
            }
            else 
            {
                MessageBox.Show("Event Deleted", "Successful");
                MyPhotoDiary myPhotoDiary = new MyPhotoDiary();
                myPhotoDiary.Show();
                this.Hide();
            }

        }
    }
}
