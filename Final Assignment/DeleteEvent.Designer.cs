
namespace Final_Assignment
{
    partial class DeleteEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteEvent));
            this.IdDeletelabel = new System.Windows.Forms.Label();
            this.EventIdtextBox = new System.Windows.Forms.TextBox();
            this.SearchDletebutton = new System.Windows.Forms.Button();
            this.Datelabel = new System.Windows.Forms.Label();
            this.CreateStorylabel = new System.Windows.Forms.Label();
            this.CreatePhotolabel = new System.Windows.Forms.Label();
            this.EventDetailsgroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteDatetextBox = new System.Windows.Forms.TextBox();
            this.DeleteStroytextBox = new System.Windows.Forms.TextBox();
            this.DeletepictureBox = new System.Windows.Forms.PictureBox();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.DeleteBackbutton = new System.Windows.Forms.Button();
            this.EventDetailsgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeletepictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IdDeletelabel
            // 
            this.IdDeletelabel.AutoSize = true;
            this.IdDeletelabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdDeletelabel.Location = new System.Drawing.Point(77, 50);
            this.IdDeletelabel.Name = "IdDeletelabel";
            this.IdDeletelabel.Size = new System.Drawing.Size(81, 19);
            this.IdDeletelabel.TabIndex = 0;
            this.IdDeletelabel.Text = "Event Id";
            // 
            // EventIdtextBox
            // 
            this.EventIdtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventIdtextBox.Location = new System.Drawing.Point(164, 50);
            this.EventIdtextBox.Name = "EventIdtextBox";
            this.EventIdtextBox.Size = new System.Drawing.Size(145, 22);
            this.EventIdtextBox.TabIndex = 1;
            // 
            // SearchDletebutton
            // 
            this.SearchDletebutton.BackColor = System.Drawing.Color.LightGray;
            this.SearchDletebutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchDletebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.SearchDletebutton.Location = new System.Drawing.Point(315, 43);
            this.SearchDletebutton.Name = "SearchDletebutton";
            this.SearchDletebutton.Size = new System.Drawing.Size(94, 32);
            this.SearchDletebutton.TabIndex = 2;
            this.SearchDletebutton.Text = "Search";
            this.SearchDletebutton.UseVisualStyleBackColor = false;
            this.SearchDletebutton.Click += new System.EventHandler(this.SearchDletebutton_Click);
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Datelabel.Location = new System.Drawing.Point(207, 146);
            this.Datelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(45, 19);
            this.Datelabel.TabIndex = 8;
            this.Datelabel.Text = "Date";
            // 
            // CreateStorylabel
            // 
            this.CreateStorylabel.AutoSize = true;
            this.CreateStorylabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateStorylabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateStorylabel.Location = new System.Drawing.Point(207, 60);
            this.CreateStorylabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CreateStorylabel.Name = "CreateStorylabel";
            this.CreateStorylabel.Size = new System.Drawing.Size(55, 19);
            this.CreateStorylabel.TabIndex = 7;
            this.CreateStorylabel.Text = "Story";
            // 
            // CreatePhotolabel
            // 
            this.CreatePhotolabel.AutoSize = true;
            this.CreatePhotolabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePhotolabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreatePhotolabel.Location = new System.Drawing.Point(7, 38);
            this.CreatePhotolabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CreatePhotolabel.Name = "CreatePhotolabel";
            this.CreatePhotolabel.Size = new System.Drawing.Size(59, 19);
            this.CreatePhotolabel.TabIndex = 6;
            this.CreatePhotolabel.Text = "Photo";
            // 
            // EventDetailsgroupBox
            // 
            this.EventDetailsgroupBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.EventDetailsgroupBox.Controls.Add(this.DeleteDatetextBox);
            this.EventDetailsgroupBox.Controls.Add(this.DeleteStroytextBox);
            this.EventDetailsgroupBox.Controls.Add(this.DeletepictureBox);
            this.EventDetailsgroupBox.Controls.Add(this.CreatePhotolabel);
            this.EventDetailsgroupBox.Controls.Add(this.Datelabel);
            this.EventDetailsgroupBox.Controls.Add(this.CreateStorylabel);
            this.EventDetailsgroupBox.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventDetailsgroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(132)))));
            this.EventDetailsgroupBox.Location = new System.Drawing.Point(12, 103);
            this.EventDetailsgroupBox.Name = "EventDetailsgroupBox";
            this.EventDetailsgroupBox.Size = new System.Drawing.Size(473, 274);
            this.EventDetailsgroupBox.TabIndex = 9;
            this.EventDetailsgroupBox.TabStop = false;
            this.EventDetailsgroupBox.Text = "Event Details";
            // 
            // DeleteDatetextBox
            // 
            this.DeleteDatetextBox.Location = new System.Drawing.Point(269, 146);
            this.DeleteDatetextBox.Name = "DeleteDatetextBox";
            this.DeleteDatetextBox.ReadOnly = true;
            this.DeleteDatetextBox.Size = new System.Drawing.Size(198, 23);
            this.DeleteDatetextBox.TabIndex = 11;
            // 
            // DeleteStroytextBox
            // 
            this.DeleteStroytextBox.Location = new System.Drawing.Point(269, 60);
            this.DeleteStroytextBox.Name = "DeleteStroytextBox";
            this.DeleteStroytextBox.ReadOnly = true;
            this.DeleteStroytextBox.Size = new System.Drawing.Size(198, 23);
            this.DeleteStroytextBox.TabIndex = 10;
            // 
            // DeletepictureBox
            // 
            this.DeletepictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DeletepictureBox.Image")));
            this.DeletepictureBox.Location = new System.Drawing.Point(11, 60);
            this.DeletepictureBox.Name = "DeletepictureBox";
            this.DeletepictureBox.Size = new System.Drawing.Size(189, 208);
            this.DeletepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeletepictureBox.TabIndex = 9;
            this.DeletepictureBox.TabStop = false;
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.LightGray;
            this.Deletebutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Deletebutton.Location = new System.Drawing.Point(174, 383);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(149, 32);
            this.Deletebutton.TabIndex = 10;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // DeleteBackbutton
            // 
            this.DeleteBackbutton.BackColor = System.Drawing.Color.LightGray;
            this.DeleteBackbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBackbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.DeleteBackbutton.Location = new System.Drawing.Point(412, 417);
            this.DeleteBackbutton.Name = "DeleteBackbutton";
            this.DeleteBackbutton.Size = new System.Drawing.Size(94, 32);
            this.DeleteBackbutton.TabIndex = 11;
            this.DeleteBackbutton.Text = "Back";
            this.DeleteBackbutton.UseVisualStyleBackColor = false;
            this.DeleteBackbutton.Click += new System.EventHandler(this.DeleteBackbutton_Click);
            // 
            // DeleteEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(510, 461);
            this.Controls.Add(this.DeleteBackbutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.EventDetailsgroupBox);
            this.Controls.Add(this.SearchDletebutton);
            this.Controls.Add(this.EventIdtextBox);
            this.Controls.Add(this.IdDeletelabel);
            this.Name = "DeleteEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Event";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeleteEvent_FormClosing);
            this.EventDetailsgroupBox.ResumeLayout(false);
            this.EventDetailsgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeletepictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdDeletelabel;
        private System.Windows.Forms.TextBox EventIdtextBox;
        private System.Windows.Forms.Button SearchDletebutton;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.Label CreateStorylabel;
        private System.Windows.Forms.Label CreatePhotolabel;
        private System.Windows.Forms.GroupBox EventDetailsgroupBox;
        private System.Windows.Forms.TextBox DeleteDatetextBox;
        private System.Windows.Forms.TextBox DeleteStroytextBox;
        private System.Windows.Forms.PictureBox DeletepictureBox;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button DeleteBackbutton;
    }
}