
namespace Final_Assignment
{
    partial class MyPhotoDiary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPhotoDiary));
            this.eventdataGridView = new System.Windows.Forms.DataGridView();
            this.Eventslabel = new System.Windows.Forms.Label();
            this.ShowpictureBox = new System.Windows.Forms.PictureBox();
            this.Storylabel = new System.Windows.Forms.Label();
            this.Photolabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.LogOutbutton = new System.Windows.Forms.Button();
            this.CreateEventButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.eventdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowpictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventdataGridView
            // 
            this.eventdataGridView.AllowUserToAddRows = false;
            this.eventdataGridView.AllowUserToDeleteRows = false;
            this.eventdataGridView.AllowUserToResizeColumns = false;
            this.eventdataGridView.AllowUserToResizeRows = false;
            this.eventdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.eventdataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.eventdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventdataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.eventdataGridView.Location = new System.Drawing.Point(10, 25);
            this.eventdataGridView.Name = "eventdataGridView";
            this.eventdataGridView.ReadOnly = true;
            this.eventdataGridView.Size = new System.Drawing.Size(1001, 260);
            this.eventdataGridView.TabIndex = 0;
            this.eventdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventdataGridView_CellClick);
            // 
            // Eventslabel
            // 
            this.Eventslabel.AutoSize = true;
            this.Eventslabel.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eventslabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Eventslabel.Location = new System.Drawing.Point(6, 0);
            this.Eventslabel.Name = "Eventslabel";
            this.Eventslabel.Size = new System.Drawing.Size(78, 23);
            this.Eventslabel.TabIndex = 1;
            this.Eventslabel.Text = "Events";
            // 
            // ShowpictureBox
            // 
            this.ShowpictureBox.BackColor = System.Drawing.Color.LightGray;
            this.ShowpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ShowpictureBox.Image")));
            this.ShowpictureBox.Location = new System.Drawing.Point(10, 42);
            this.ShowpictureBox.Name = "ShowpictureBox";
            this.ShowpictureBox.Size = new System.Drawing.Size(612, 323);
            this.ShowpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowpictureBox.TabIndex = 2;
            this.ShowpictureBox.TabStop = false;
            // 
            // Storylabel
            // 
            this.Storylabel.AutoSize = true;
            this.Storylabel.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Storylabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Storylabel.Location = new System.Drawing.Point(14, 42);
            this.Storylabel.Name = "Storylabel";
            this.Storylabel.Size = new System.Drawing.Size(140, 23);
            this.Storylabel.TabIndex = 3;
            this.Storylabel.Text = "Your Stories ";
            // 
            // Photolabel
            // 
            this.Photolabel.AutoSize = true;
            this.Photolabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Photolabel.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Photolabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Photolabel.Location = new System.Drawing.Point(6, 9);
            this.Photolabel.Name = "Photolabel";
            this.Photolabel.Size = new System.Drawing.Size(69, 23);
            this.Photolabel.TabIndex = 5;
            this.Photolabel.Text = "Photo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Updatebutton);
            this.panel1.Controls.Add(this.LogOutbutton);
            this.panel1.Controls.Add(this.CreateEventButton);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 659);
            this.panel1.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(9, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 80);
            this.button2.TabIndex = 15;
            this.button2.Text = "Delete Event";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.Color.LightGray;
            this.Updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.Location = new System.Drawing.Point(9, 285);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(172, 80);
            this.Updatebutton.TabIndex = 14;
            this.Updatebutton.Text = "Update Event";
            this.Updatebutton.UseVisualStyleBackColor = false;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // LogOutbutton
            // 
            this.LogOutbutton.BackColor = System.Drawing.Color.LightGray;
            this.LogOutbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutbutton.Location = new System.Drawing.Point(9, 507);
            this.LogOutbutton.Name = "LogOutbutton";
            this.LogOutbutton.Size = new System.Drawing.Size(172, 80);
            this.LogOutbutton.TabIndex = 13;
            this.LogOutbutton.Text = "Log Out";
            this.LogOutbutton.UseVisualStyleBackColor = false;
            this.LogOutbutton.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // CreateEventButton
            // 
            this.CreateEventButton.BackColor = System.Drawing.Color.LightGray;
            this.CreateEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateEventButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateEventButton.Location = new System.Drawing.Point(9, 174);
            this.CreateEventButton.Name = "CreateEventButton";
            this.CreateEventButton.Size = new System.Drawing.Size(172, 76);
            this.CreateEventButton.TabIndex = 12;
            this.CreateEventButton.Text = "Create Event";
            this.CreateEventButton.UseVisualStyleBackColor = false;
            this.CreateEventButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(184, 116);
            this.panel4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label3.Location = new System.Drawing.Point(105, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 33);
            this.label3.TabIndex = 14;
            this.label3.Text = "Diary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(38, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Photo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "My";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.eventdataGridView);
            this.panel2.Controls.Add(this.Eventslabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(184, 371);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 288);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Photolabel);
            this.panel3.Controls.Add(this.ShowpictureBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(184, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 371);
            this.panel3.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.Storylabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(798, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(397, 371);
            this.panel5.TabIndex = 15;
            // 
            // MyPhotoDiary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1195, 659);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MyPhotoDiary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Photo Diary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MyPhotoDiary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowpictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView eventdataGridView;
        private System.Windows.Forms.Label Eventslabel;
        private System.Windows.Forms.PictureBox ShowpictureBox;
        private System.Windows.Forms.Label Storylabel;
        private System.Windows.Forms.Label Photolabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CreateEventButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button LogOutbutton;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button button2;
    }
}

