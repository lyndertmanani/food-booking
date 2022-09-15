namespace BookingSysApp
{
    partial class Abooking
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signupbtn = new System.Windows.Forms.Button();
            this.DateB = new System.Windows.Forms.DateTimePicker();
            this.MemberBar = new System.Windows.Forms.NumericUpDown();
            this.totall = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.Producttxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Clienttxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookingSysApp.Properties.Resources.logoaz;
            this.pictureBox1.Location = new System.Drawing.Point(495, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // signupbtn
            // 
            this.signupbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.signupbtn.FlatAppearance.BorderSize = 0;
            this.signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupbtn.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.signupbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.signupbtn.Location = new System.Drawing.Point(172, 323);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(103, 29);
            this.signupbtn.TabIndex = 83;
            this.signupbtn.Text = "Book  ";
            this.signupbtn.UseVisualStyleBackColor = false;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // DateB
            // 
            this.DateB.CalendarForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DateB.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.DateB.CalendarTitleBackColor = System.Drawing.Color.DarkSlateGray;
            this.DateB.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DateB.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.DateB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateB.Location = new System.Drawing.Point(173, 234);
            this.DateB.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.DateB.MinDate = new System.DateTime(2022, 5, 1, 0, 0, 0, 0);
            this.DateB.Name = "DateB";
            this.DateB.Size = new System.Drawing.Size(142, 23);
            this.DateB.TabIndex = 82;
            this.DateB.Value = new System.DateTime(2022, 5, 17, 0, 0, 0, 0);
            // 
            // MemberBar
            // 
            this.MemberBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.MemberBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MemberBar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MemberBar.Location = new System.Drawing.Point(173, 197);
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
            this.MemberBar.Size = new System.Drawing.Size(142, 20);
            this.MemberBar.TabIndex = 81;
            this.MemberBar.Tag = "number of member";
            this.MemberBar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MemberBar.ValueChanged += new System.EventHandler(this.MemberBar_ValueChanged);
            // 
            // totall
            // 
            this.totall.AutoSize = true;
            this.totall.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.totall.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.totall.Location = new System.Drawing.Point(173, 265);
            this.totall.Name = "totall";
            this.totall.Size = new System.Drawing.Size(51, 21);
            this.totall.TabIndex = 71;
            this.totall.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label6.Location = new System.Drawing.Point(63, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 21);
            this.label6.TabIndex = 76;
            this.label6.Text = "Total Price :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label5.Location = new System.Drawing.Point(109, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 77;
            this.label5.Text = "Price :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label8.Location = new System.Drawing.Point(106, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 21);
            this.label8.TabIndex = 78;
            this.label8.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label3.Location = new System.Drawing.Point(100, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 79;
            this.label3.Text = "Client :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label2.Location = new System.Drawing.Point(71, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 75;
            this.label2.Text = "Members :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label1.Location = new System.Drawing.Point(83, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 80;
            this.label1.Text = "Product :";
            // 
            // pricetxt
            // 
            this.pricetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pricetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pricetxt.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.pricetxt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pricetxt.Location = new System.Drawing.Point(173, 169);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(142, 17);
            this.pricetxt.TabIndex = 103;
            // 
            // Producttxt
            // 
            this.Producttxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Producttxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Producttxt.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.Producttxt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Producttxt.Location = new System.Drawing.Point(173, 135);
            this.Producttxt.Name = "Producttxt";
            this.Producttxt.Size = new System.Drawing.Size(142, 17);
            this.Producttxt.TabIndex = 104;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(173, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 1);
            this.panel2.TabIndex = 101;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(173, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 1);
            this.panel1.TabIndex = 102;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(172, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(142, 1);
            this.panel3.TabIndex = 102;
            // 
            // Clienttxt
            // 
            this.Clienttxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Clienttxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Clienttxt.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.Clienttxt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Clienttxt.Location = new System.Drawing.Point(172, 105);
            this.Clienttxt.Name = "Clienttxt";
            this.Clienttxt.Size = new System.Drawing.Size(142, 17);
            this.Clienttxt.TabIndex = 104;
            // 
            // Abooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.Clienttxt);
            this.Controls.Add(this.Producttxt);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.DateB);
            this.Controls.Add(this.MemberBar);
            this.Controls.Add(this.totall);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Abooking";
            this.Size = new System.Drawing.Size(805, 434);
            this.Load += new System.EventHandler(this.Abooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button signupbtn;
        private System.Windows.Forms.DateTimePicker DateB;
        private System.Windows.Forms.NumericUpDown MemberBar;
        private System.Windows.Forms.Label totall;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.TextBox Producttxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Clienttxt;
    }
}
