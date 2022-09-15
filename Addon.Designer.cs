namespace BookingSysApp
{
    partial class Addon
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MemberBar = new System.Windows.Forms.NumericUpDown();
            this.productl = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.DateB = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.signupbtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.loginlink = new System.Windows.Forms.LinkLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.totall = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookingSysApp.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(109, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BookingSysApp.Properties.Resources._02logo;
            this.pictureBox2.Location = new System.Drawing.Point(297, 396);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label3.Location = new System.Drawing.Point(85, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 56;
            this.label3.Text = "Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label2.Location = new System.Drawing.Point(74, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 54;
            this.label2.Text = "Members :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label1.Location = new System.Drawing.Point(86, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 57;
            this.label1.Text = "Product :";
            // 
            // MemberBar
            // 
            this.MemberBar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MemberBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MemberBar.ForeColor = System.Drawing.Color.Gray;
            this.MemberBar.Location = new System.Drawing.Point(172, 183);
            this.MemberBar.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.MemberBar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MemberBar.Name = "MemberBar";
            this.MemberBar.Size = new System.Drawing.Size(110, 22);
            this.MemberBar.TabIndex = 68;
            this.MemberBar.Tag = "number of member";
            this.MemberBar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MemberBar.ValueChanged += new System.EventHandler(this.MemberBar_ValueChanged);
            this.MemberBar.Click += new System.EventHandler(this.MemberBar_Click);
            // 
            // productl
            // 
            this.productl.AutoSize = true;
            this.productl.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.productl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.productl.Location = new System.Drawing.Point(172, 121);
            this.productl.Name = "productl";
            this.productl.Size = new System.Drawing.Size(110, 21);
            this.productl.TabIndex = 53;
            this.productl.Text = "Display here";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.Address.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Address.Location = new System.Drawing.Point(172, 253);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(110, 21);
            this.Address.TabIndex = 53;
            this.Address.Text = "Display here";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label5.Location = new System.Drawing.Point(112, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 56;
            this.label5.Text = "Price :";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.price.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.price.Location = new System.Drawing.Point(172, 150);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(110, 21);
            this.price.TabIndex = 53;
            this.price.Text = "Display here";
            // 
            // DateB
            // 
            this.DateB.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DateB.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DateB.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.DateB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateB.Location = new System.Drawing.Point(172, 220);
            this.DateB.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.DateB.MinDate = new System.DateTime(2022, 5, 1, 0, 0, 0, 0);
            this.DateB.Name = "DateB";
            this.DateB.Size = new System.Drawing.Size(110, 23);
            this.DateB.TabIndex = 69;
            this.DateB.Value = new System.DateTime(2022, 5, 17, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label8.Location = new System.Drawing.Point(109, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 21);
            this.label8.TabIndex = 56;
            this.label8.Text = "Date :";
            // 
            // signupbtn
            // 
            this.signupbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.signupbtn.FlatAppearance.BorderSize = 0;
            this.signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupbtn.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.signupbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.signupbtn.Location = new System.Drawing.Point(140, 334);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(103, 29);
            this.signupbtn.TabIndex = 70;
            this.signupbtn.Text = "Book  ";
            this.signupbtn.UseVisualStyleBackColor = false;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label9.Location = new System.Drawing.Point(72, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 73;
            this.label9.Text = "I would like to ";
            // 
            // loginlink
            // 
            this.loginlink.AutoSize = true;
            this.loginlink.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.loginlink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.loginlink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginlink.Location = new System.Drawing.Point(160, 385);
            this.loginlink.Name = "loginlink";
            this.loginlink.Size = new System.Drawing.Size(122, 17);
            this.loginlink.TabIndex = 72;
            this.loginlink.TabStop = true;
            this.loginlink.Text = "cancel the process";
            this.loginlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginlink_LinkClicked);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Location = new System.Drawing.Point(64, 405);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(220, 1);
            this.panel6.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label6.Location = new System.Drawing.Point(66, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 21);
            this.label6.TabIndex = 56;
            this.label6.Text = "Total Price :";
            // 
            // totall
            // 
            this.totall.AutoSize = true;
            this.totall.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.totall.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.totall.Location = new System.Drawing.Point(172, 286);
            this.totall.Name = "totall";
            this.totall.Size = new System.Drawing.Size(110, 21);
            this.totall.TabIndex = 53;
            this.totall.Text = "Display here";
            // 
            // Addon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 439);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.loginlink);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.DateB);
            this.Controls.Add(this.MemberBar);
            this.Controls.Add(this.totall);
            this.Controls.Add(this.price);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.productl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Addon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Addon";
            this.Load += new System.EventHandler(this.Addon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown MemberBar;
        private System.Windows.Forms.Label productl;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.DateTimePicker DateB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button signupbtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel loginlink;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totall;
    }
}