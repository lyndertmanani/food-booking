using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BookingSysApp
{
    public partial class Sign : Form
    {
        public Sign()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=bookingsys");
        private void loginlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login lgn = new login();
            this.Hide();
            lgn.Show();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            try
            {

                MySqlCommand cmd = new MySqlCommand("select username from handles where username='" + usernametxt.Text + "'", connection);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("user already exist in the  server\nPlease add a different username");
                }
                else
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO handles VALUES ('" + "" + "', '" + firstnametxt.Text + "','" + surnametext.Text + "','" + usernametxt.Text + "','" + addresstxt.Text + "','" + celltxt.Text + "','" + passwordtxt.Text + "')";
                    command.ExecuteNonQuery();

                    MessageBox.Show("You have created your account successfully.\nNow you can login", "Registered successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    login lgin = new login();
                    this.Hide();
                    lgin.Show();
                    firstnametxt.Clear();
                    surnametext.Clear();
                    usernametxt.Clear();
                    addresstxt.Clear();
                    celltxt.Clear();
                    passwordtxt.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
