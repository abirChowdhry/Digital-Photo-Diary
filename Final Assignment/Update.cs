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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void SearchDletebutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();

            string sql = "Select * from events where eventid = '" + EventIdtextBox.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                // MemoryStream ms = new MemoryStream((byte[])reader["Photo"]);
                UpdatepictureBox.Image = GetPhoto((byte[])reader["photo"]);
                UpdateStroytextBox.Text = reader["story"].ToString();
                UploaddateTimePicker.Text = reader["Date"].ToString();
            }

            else
            {
                UpdateStroytextBox.Text = UploaddateTimePicker.Text = "";
                MessageBox.Show("Event Not Found!", "Error");
            }

            connection.Close();
        }

        private Image GetPhoto(byte[] value)
        {
            MemoryStream memoryStream = new MemoryStream(value);
            return Image.FromStream(memoryStream);
        }

        private void Update_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (UpdatepictureBox.Image == null) { MessageBox.Show("There's No Photo!", "Error"); }
            else if (UpdateStroytextBox.Text == "") { MessageBox.Show("Story Box Can't Be Empty!", "Error"); }
            else if (UploaddateTimePicker.Checked == false) { MessageBox.Show("Upload Date Can't Be Empty!", "Error"); }
            else if (UpdatedateTimePicker.Checked == false) { MessageBox.Show("Update Date Must Be Seleted!", "Error"); }
            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection.Open();

                string sql = "Update events set date = @date, story = @story, photo = @photo, lastModified = @moddate where eventid = '"+EventIdtextBox.Text+"'";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("photo", ConvertImageToByte(UpdatepictureBox.Image));
                command.Parameters.AddWithValue("date", UploaddateTimePicker.Text);
                command.Parameters.AddWithValue("story", UpdateStroytextBox.Text);
                command.Parameters.AddWithValue("moddate", UpdatedateTimePicker.Text);
                
                int flag = command.ExecuteNonQuery();

                if (flag == 0)
                {
                    MessageBox.Show("Event Not Updated!", "Error");
                }

                else 
                {
                    MessageBox.Show("Event Updated", "Successful");
                    MyPhotoDiary myPhotoDiary = new MyPhotoDiary();
                    myPhotoDiary.Show();
                    this.Hide();
                }
            }
        }

        private byte[] ConvertImageToByte(Image reciecve)
        {
            MemoryStream memoryStream = new MemoryStream();
            reciecve.Save(memoryStream, reciecve.RawFormat);
            byte[] img = memoryStream.GetBuffer();
            memoryStream.Close();
            return img;
        }

        private void Browsebutton_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Photo";
            openFileDialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //UpdatepictureBox.Image = new Bitmap(openFileDialog.FileName);
                string piclocation = openFileDialog.FileName.ToString();
                UpdatepictureBox.ImageLocation = piclocation;
            }
        }

        private void updateBackbutton_Click(object sender, EventArgs e)
        {
            MyPhotoDiary myPhotoDiary = new MyPhotoDiary();
            myPhotoDiary.Show();
            this.Hide();
        }
    }
}
