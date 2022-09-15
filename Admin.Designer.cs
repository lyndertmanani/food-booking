namespace BookingSysApp
{
    partial class Admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernamel = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Ahold = new System.Windows.Forms.Panel();
            this.abooking1 = new BookingSysApp.Abooking();
            this.bookings2 = new BookingSysApp.Bookings();
            this.signupA1 = new BookingSysApp.signupA();
            this.bookings1 = new BookingSysApp.Bookings();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Ahold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.usernamel);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 35);
            this.panel1.TabIndex = 1;
            // 
            // usernamel
            // 
            this.usernamel.AutoSize = true;
            this.usernamel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.usernamel.Location = new System.Drawing.Point(547, 9);
            this.usernamel.Name = "usernamel";
            this.usernamel.Size = new System.Drawing.Size(91, 19);
            this.usernamel.TabIndex = 1;
            this.usernamel.Text = "Username ";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Location = new System.Drawing.Point(676, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 34);
            this.button5.TabIndex = 1;
            this.button5.Text = "Log out";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(228, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 34);
            this.button3.TabIndex = 1;
            this.button3.Text = "book";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Location = new System.Drawing.Point(321, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 34);
            this.button4.TabIndex = 1;
            this.button4.Text = "Sign up";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(96, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Booking Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ahold
            // 
            this.Ahold.Controls.Add(this.abooking1);
            this.Ahold.Controls.Add(this.bookings2);
            this.Ahold.Controls.Add(this.signupA1);
            this.Ahold.Controls.Add(this.bookings1);
            this.Ahold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ahold.Location = new System.Drawing.Point(0, 35);
            this.Ahold.Name = "Ahold";
            this.Ahold.Size = new System.Drawing.Size(805, 434);
            this.Ahold.TabIndex = 2;
            // 
            // abooking1
            // 
            this.abooking1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.abooking1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abooking1.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.abooking1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.abooking1.Location = new System.Drawing.Point(0, 0);
            this.abooking1.Margin = new System.Windows.Forms.Padding(5);
            this.abooking1.Name = "abooking1";
            this.abooking1.Size = new System.Drawing.Size(805, 434);
            this.abooking1.TabIndex = 4;
            // 
            // bookings2
            // 
            this.bookings2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.bookings2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookings2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookings2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bookings2.Location = new System.Drawing.Point(0, 0);
            this.bookings2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bookings2.Name = "bookings2";
            this.bookings2.Size = new System.Drawing.Size(805, 434);
            this.bookings2.TabIndex = 3;
            // 
            // signupA1
            // 
            this.signupA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.signupA1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signupA1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.signupA1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.signupA1.Location = new System.Drawing.Point(0, 0);
            this.signupA1.Margin = new System.Windows.Forms.Padding(4);
            this.signupA1.Name = "signupA1";
            this.signupA1.Size = new System.Drawing.Size(805, 434);
            this.signupA1.TabIndex = 2;
            // 
            // bookings1
            // 
            this.bookings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.bookings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookings1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookings1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bookings1.Location = new System.Drawing.Point(0, 0);
            this.bookings1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bookings1.Name = "bookings1";
            this.bookings1.Size = new System.Drawing.Size(805, 434);
            this.bookings1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookingSysApp.Properties.Resources._01logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::BookingSysApp.Properties.Resources.icons8_sphere_25px;
            this.button1.Location = new System.Drawing.Point(742, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(805, 469);
            this.Controls.Add(this.Ahold);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Ahold.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label usernamel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel Ahold;
     
        private Bookings bookings1;
        private System.Windows.Forms.Button button3;
        private signupA signupA1;
        private Bookings bookings2;
        private Abooking abooking1;
        private System.Windows.Forms.Button button1;
    }
}