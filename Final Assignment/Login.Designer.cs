
namespace Final_Assignment
{
    partial class Login
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
            this.NewAccountlabel = new System.Windows.Forms.Label();
            this.Signupbutton = new System.Windows.Forms.Button();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.PasstextBox = new System.Windows.Forms.TextBox();
            this.UsernametextBox = new System.Windows.Forms.TextBox();
            this.Passlabel = new System.Windows.Forms.Label();
            this.Usenamelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewAccountlabel
            // 
            this.NewAccountlabel.AutoSize = true;
            this.NewAccountlabel.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewAccountlabel.Location = new System.Drawing.Point(115, 202);
            this.NewAccountlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NewAccountlabel.Name = "NewAccountlabel";
            this.NewAccountlabel.Size = new System.Drawing.Size(272, 16);
            this.NewAccountlabel.TabIndex = 13;
            this.NewAccountlabel.Text = "Don\'t have an account? Create  one...Signup now";
            // 
            // Signupbutton
            // 
            this.Signupbutton.BackColor = System.Drawing.Color.LightGray;
            this.Signupbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signupbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Signupbutton.Location = new System.Drawing.Point(256, 247);
            this.Signupbutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Signupbutton.Name = "Signupbutton";
            this.Signupbutton.Size = new System.Drawing.Size(109, 34);
            this.Signupbutton.TabIndex = 12;
            this.Signupbutton.Text = "Signup";
            this.Signupbutton.UseVisualStyleBackColor = false;
            this.Signupbutton.Click += new System.EventHandler(this.Signupbutton_Click);
            // 
            // Loginbutton
            // 
            this.Loginbutton.BackColor = System.Drawing.Color.LightGray;
            this.Loginbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Loginbutton.Location = new System.Drawing.Point(119, 247);
            this.Loginbutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(106, 34);
            this.Loginbutton.TabIndex = 11;
            this.Loginbutton.Text = "Login";
            this.Loginbutton.UseVisualStyleBackColor = false;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // PasstextBox
            // 
            this.PasstextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.PasstextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasstextBox.Location = new System.Drawing.Point(234, 139);
            this.PasstextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PasstextBox.Name = "PasstextBox";
            this.PasstextBox.PasswordChar = '*';
            this.PasstextBox.Size = new System.Drawing.Size(133, 23);
            this.PasstextBox.TabIndex = 10;
            // 
            // UsernametextBox
            // 
            this.UsernametextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.UsernametextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernametextBox.Location = new System.Drawing.Point(234, 85);
            this.UsernametextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UsernametextBox.Name = "UsernametextBox";
            this.UsernametextBox.Size = new System.Drawing.Size(133, 23);
            this.UsernametextBox.TabIndex = 9;
            // 
            // Passlabel
            // 
            this.Passlabel.AutoSize = true;
            this.Passlabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passlabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Passlabel.Location = new System.Drawing.Point(115, 138);
            this.Passlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Passlabel.Name = "Passlabel";
            this.Passlabel.Size = new System.Drawing.Size(90, 19);
            this.Passlabel.TabIndex = 8;
            this.Passlabel.Text = "Password";
            // 
            // Usenamelabel
            // 
            this.Usenamelabel.AutoSize = true;
            this.Usenamelabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usenamelabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Usenamelabel.Location = new System.Drawing.Point(115, 82);
            this.Usenamelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Usenamelabel.Name = "Usenamelabel";
            this.Usenamelabel.Size = new System.Drawing.Size(92, 19);
            this.Usenamelabel.TabIndex = 7;
            this.Usenamelabel.Text = "Username";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(474, 364);
            this.Controls.Add(this.NewAccountlabel);
            this.Controls.Add(this.Signupbutton);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.PasstextBox);
            this.Controls.Add(this.UsernametextBox);
            this.Controls.Add(this.Passlabel);
            this.Controls.Add(this.Usenamelabel);
            this.Font = new System.Drawing.Font("Century Schoolbook", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewAccountlabel;
        private System.Windows.Forms.Button Signupbutton;
        private System.Windows.Forms.Button Loginbutton;
        public System.Windows.Forms.TextBox PasstextBox;
        public System.Windows.Forms.TextBox UsernametextBox;
        private System.Windows.Forms.Label Passlabel;
        private System.Windows.Forms.Label Usenamelabel;
    }
}