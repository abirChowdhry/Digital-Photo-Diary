
namespace Final_Assignment
{
    partial class CreateEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEvent));
            this.CreatePhotolabel = new System.Windows.Forms.Label();
            this.CreatepictureBox = new System.Windows.Forms.PictureBox();
            this.Browsebutton = new System.Windows.Forms.Button();
            this.CreateStorylabel = new System.Windows.Forms.Label();
            this.StorytextBox = new System.Windows.Forms.TextBox();
            this.Datelabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Createbutton = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CreatepictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CreatePhotolabel
            // 
            this.CreatePhotolabel.AutoSize = true;
            this.CreatePhotolabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePhotolabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreatePhotolabel.Location = new System.Drawing.Point(109, 102);
            this.CreatePhotolabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CreatePhotolabel.Name = "CreatePhotolabel";
            this.CreatePhotolabel.Size = new System.Drawing.Size(59, 19);
            this.CreatePhotolabel.TabIndex = 0;
            this.CreatePhotolabel.Text = "Photo";
            // 
            // CreatepictureBox
            // 
            this.CreatepictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CreatepictureBox.Image")));
            this.CreatepictureBox.Location = new System.Drawing.Point(253, 44);
            this.CreatepictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.CreatepictureBox.Name = "CreatepictureBox";
            this.CreatepictureBox.Size = new System.Drawing.Size(189, 123);
            this.CreatepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CreatepictureBox.TabIndex = 1;
            this.CreatepictureBox.TabStop = false;
            // 
            // Browsebutton
            // 
            this.Browsebutton.BackColor = System.Drawing.Color.LightGray;
            this.Browsebutton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browsebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Browsebutton.Location = new System.Drawing.Point(449, 136);
            this.Browsebutton.Margin = new System.Windows.Forms.Padding(4);
            this.Browsebutton.Name = "Browsebutton";
            this.Browsebutton.Size = new System.Drawing.Size(99, 32);
            this.Browsebutton.TabIndex = 2;
            this.Browsebutton.Text = "Browse ";
            this.Browsebutton.UseVisualStyleBackColor = false;
            this.Browsebutton.Click += new System.EventHandler(this.Browsebutton_Click);
            // 
            // CreateStorylabel
            // 
            this.CreateStorylabel.AutoSize = true;
            this.CreateStorylabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateStorylabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateStorylabel.Location = new System.Drawing.Point(109, 225);
            this.CreateStorylabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CreateStorylabel.Name = "CreateStorylabel";
            this.CreateStorylabel.Size = new System.Drawing.Size(55, 19);
            this.CreateStorylabel.TabIndex = 3;
            this.CreateStorylabel.Text = "Story";
            // 
            // StorytextBox
            // 
            this.StorytextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.StorytextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StorytextBox.Location = new System.Drawing.Point(253, 229);
            this.StorytextBox.Margin = new System.Windows.Forms.Padding(4);
            this.StorytextBox.Name = "StorytextBox";
            this.StorytextBox.Size = new System.Drawing.Size(229, 23);
            this.StorytextBox.TabIndex = 4;
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Datelabel.Location = new System.Drawing.Point(109, 316);
            this.Datelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(45, 19);
            this.Datelabel.TabIndex = 5;
            this.Datelabel.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.MenuBar;
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(253, 316);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 23);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // Createbutton
            // 
            this.Createbutton.BackColor = System.Drawing.Color.LightGray;
            this.Createbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Createbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Createbutton.Location = new System.Drawing.Point(266, 391);
            this.Createbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Createbutton.Name = "Createbutton";
            this.Createbutton.Size = new System.Drawing.Size(199, 33);
            this.Createbutton.TabIndex = 7;
            this.Createbutton.Text = "Create";
            this.Createbutton.UseVisualStyleBackColor = false;
            this.Createbutton.Click += new System.EventHandler(this.Createbutton_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.BackColor = System.Drawing.Color.LightGray;
            this.Backbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Backbutton.Location = new System.Drawing.Point(581, 443);
            this.Backbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(120, 36);
            this.Backbutton.TabIndex = 8;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = false;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // CreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(720, 504);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.Createbutton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.StorytextBox);
            this.Controls.Add(this.CreateStorylabel);
            this.Controls.Add(this.Browsebutton);
            this.Controls.Add(this.CreatepictureBox);
            this.Controls.Add(this.CreatePhotolabel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Event";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateEvent_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.CreatepictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreatePhotolabel;
        private System.Windows.Forms.PictureBox CreatepictureBox;
        private System.Windows.Forms.Button Browsebutton;
        private System.Windows.Forms.Label CreateStorylabel;
        private System.Windows.Forms.TextBox StorytextBox;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Createbutton;
        private System.Windows.Forms.Button Backbutton;
    }
}