namespace BookingSysApp
{
    partial class Adminlogins
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
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.loginAdminlink = new System.Windows.Forms.LinkLabel();
            this.Signlink = new System.Windows.Forms.LinkLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginadmin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adminpasstxt = new System.Windows.Forms.TextBox();
            this.admintxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel3.Location = new System.Drawing.Point(323, 488);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(48, 21);
            this.linkLabel3.TabIndex = 46;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Help";
            // 
            // loginAdminlink
            // 
            this.loginAdminlink.AutoSize = true;
            this.loginAdminlink.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.loginAdminlink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.loginAdminlink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginAdminlink.Location = new System.Drawing.Point(195, 488);
            this.loginAdminlink.Name = "loginAdminlink";
            this.loginAdminlink.Size = new System.Drawing.Size(53, 21);
            this.loginAdminlink.TabIndex = 47;
            this.loginAdminlink.TabStop = true;
            this.loginAdminlink.Text = "Login";
            this.loginAdminlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Adminlink_LinkClicked);
            // 
            // Signlink
            // 
            this.Signlink.AutoSize = true;
            this.Signlink.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.Signlink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Signlink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Signlink.Location = new System.Drawing.Point(50, 488);
            this.Signlink.Name = "Signlink";
            this.Signlink.Size = new System.Drawing.Size(69, 21);
            this.Signlink.TabIndex = 48;
            this.Signlink.TabStop = true;
            this.Signlink.Text = "Sign up";
            this.Signlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Signlink_LinkClicked);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Location = new System.Drawing.Point(113, 464);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(220, 1);
            this.panel6.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel2.Location = new System.Drawing.Point(149, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 2);
            this.panel2.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Location = new System.Drawing.Point(149, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 2);
            this.panel1.TabIndex = 43;
            // 
            // loginadmin
            // 
            this.loginadmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.loginadmin.FlatAppearance.BorderSize = 0;
            this.loginadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginadmin.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.loginadmin.ForeColor = System.Drawing.SystemColors.Control;
            this.loginadmin.Location = new System.Drawing.Point(172, 354);
            this.loginadmin.Name = "loginadmin";
            this.loginadmin.Size = new System.Drawing.Size(118, 37);
            this.loginadmin.TabIndex = 40;
            this.loginadmin.Text = "Check in";
            this.loginadmin.UseVisualStyleBackColor = false;
            this.loginadmin.Click += new System.EventHandler(this.loginadmin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label2.Location = new System.Drawing.Point(56, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label1.Location = new System.Drawing.Point(83, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 39;
            this.label1.Text = "Admin :";
            // 
            // adminpasstxt
            // 
            this.adminpasstxt.BackColor = System.Drawing.SystemColors.Control;
            this.adminpasstxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminpasstxt.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.adminpasstxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.adminpasstxt.Location = new System.Drawing.Point(151, 268);
            this.adminpasstxt.Name = "adminpasstxt";
            this.adminpasstxt.Size = new System.Drawing.Size(220, 17);
            this.adminpasstxt.TabIndex = 44;
            // 
            // admintxt
            // 
            this.admintxt.BackColor = System.Drawing.SystemColors.Control;
            this.admintxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.admintxt.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.admintxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.admintxt.Location = new System.Drawing.Point(151, 228);
            this.admintxt.Name = "admintxt";
            this.admintxt.Size = new System.Drawing.Size(220, 17);
            this.admintxt.TabIndex = 45;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookingSysApp.Properties.Resources._02logo;
            this.pictureBox1.Location = new System.Drawing.Point(87, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::BookingSysApp.Properties.Resources.icons8_sphere_10px;
            this.button1.Location = new System.Drawing.Point(383, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 37);
            this.button1.TabIndex = 52;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Adminlogins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adminpasstxt);
            this.Controls.Add(this.admintxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.loginAdminlink);
            this.Controls.Add(this.Signlink);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginadmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Adminlogins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adminlogins";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel loginAdminlink;
        private System.Windows.Forms.LinkLabel Signlink;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loginadmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminpasstxt;
        private System.Windows.Forms.TextBox admintxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}