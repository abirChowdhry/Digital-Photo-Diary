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
    public partial class CreateEvent : Form
    {
        public CreateEvent()
        {
            InitializeComponent();
        }

        private void CreateEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Browsebutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Photo";
            openFileDialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CreatepictureBox.Image = Image.FromFile(openFileDialog.FileName);
                //string piclocation = openFileDialog.FileName.ToString();
                //CreatepictureBox.ImageLocation = piclocation;
            }

        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            MyPhotoDiary myPhotoDiary = new MyPhotoDiary();
            myPhotoDiary.Show();
            this.Hide();
        }

       /* public byte[] SavePhoto(Image img) 
        {
            //img = Image.FromFile(CreatepictureBox.ImageLocation);
           // ImageConverter imageConverter = new ImageConverter();
            //byte[] xByte = (byte[])imageConverter.ConvertTo(img, typeof(byte[]));
            //return xByte;
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //return ms.ToArray();
        }*/

        private void Createbutton_Click(object sender, EventArgs e)
        {
            if (CreatepictureBox.Image == null) { MessageBox.Show("You Haven't Entered Any Photo!", "Error"); }
            else if (StorytextBox.Text == "") { MessageBox.Show("You Haven't Entered Any Story of the Photo!", "Error"); }
            else if (dateTimePicker1.Checked == false) { MessageBox.Show("You Haven't Entered The Date!", "Error"); }
            else 
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection.Open();

                //int id = Convert.ToInt32("select id from users where where username = '" + UsernametextBox.Text + "' and password = '" + PasstextBox.Text + "'");
                string sql = "Insert into Events(Date,story,photo,userid,LastModified) values('"+dateTimePicker1.Text+"','"+StorytextBox.Text+"',@photo,'"+1+"','"+null+"') ";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("photo", ConvertImageToByte(CreatepictureBox.Image));

                int flag = command.ExecuteNonQuery();
                if (flag == 1)
                {
                    connection.Close();
                    MessageBox.Show("Event Created", "Successful");
                }
                else if (flag == 0)
                {
                    connection.Close();
                    MessageBox.Show("Event Can't Be Created!", "Error");
                }
                MyPhotoDiary myPhotoDiary = new MyPhotoDiary();
                myPhotoDiary.Show();
                this.Hide();
            }
        }

        private byte[] ConvertImageToByte(Image reciecve)
        {
            MemoryStream memoryStream = new MemoryStream();
            reciecve.Save(memoryStream, reciecve.RawFormat);
            byte[] img = memoryStream.GetBuffer();
            memoryStream.Close();
            return img;
            
            //CreatepictureBox.Image.Save(memoryStream, CreatepictureBox.Image.RawFormat);
           // return memoryStream.GetBuffer();

            //byte[] img = null;
           //FileStream fs = new FileStream(piclocatio); 
        }
    }
}
