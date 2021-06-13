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
    public partial class MyPhotoDiary : Form
    {
        public MyPhotoDiary()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateEvent createEvent = new CreateEvent();
            createEvent.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteEvent deleteEvent = new DeleteEvent();
            deleteEvent.Show();
            this.Hide();
        }

        private void MyPhotoDiary_Load(object sender, EventArgs e)
        { 
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM events";
            SqlCommand command = new SqlCommand(sql,connection);
            SqlDataReader reader = command.ExecuteReader();
            
            List<Events> events = new List<Events>();

            while (reader.Read()) 
            {
                Events events1 = new Events();

                events1.Date = reader["date"].ToString();
                events1.Story = reader["story"].ToString();
                events1.Event_Id = Convert.ToInt32(reader["eventid"]);
                events1.Image = (byte[])reader["photo"];
                events1.Last_Modified = reader["lastModified"].ToString();

                events.Add(events1);
            }
         
            eventdataGridView.DataSource = events;
            connection.Close();
        }

        private void eventdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM events";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            //byte[] img = null;
            if (reader.Read())
            {
                Storylabel.Text = eventdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                ShowpictureBox.Image = GetPhoto((byte[])eventdataGridView.Rows[e.RowIndex].Cells[3].Value);
            }
            //ShowpictureBox.Image = GetPhoto((byte[])eventdataGridView.Rows[e.RowIndex].Cells[]);
            //ShowpictureBox.Image = GetPhoto((byte[])reader["photo"]);
        }

        private Image GetPhoto(byte[] value)
        {
            MemoryStream memoryStream = new MemoryStream(value);
            return Image.FromStream(memoryStream);
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.Show();
            this.Hide();
        }

    }
}
