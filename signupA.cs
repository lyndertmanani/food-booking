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
    public partial class signupA : UserControl
    {
        public signupA()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=bookingsys");
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
                    MessageBox.Show("User already exist in the  server\nPlease add a different username");
                }
                else
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO handles VALUES ('" + "" + "', '" + firstnametxt.Text + "','" + surnametext.Text + "','" + usernametxt.Text + "','" + addresstxt.Text + "','" + celltxt.Text + "','" + passwordtxt.Text + "')";
                    command.ExecuteNonQuery();

                    MessageBox.Show("The account has been created successfully.\nThe user can now success the account", "Registered successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
                    firstnametxt.Clear();
                    surnametext.Clear();
                    usernametxt.Clear();
                    addresstxt.Clear();
                    celltxt.Clear();
                    passwordtxt.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand command1 = new MySqlCommand();
            try
            {

                MySqlCommand cmd = new MySqlCommand("select username from admin where username='" + usernametxt.Text + "'", connection);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Admin already exist in the server\nPlease add a different username");
                }
                else
                {
                    connection.Open();
                    command1.Connection = connection;
                    command1.CommandText = "INSERT INTO admin VALUES ('" + "" + "', '" + Admin.Text + "','" + passwordadmin.Text + "')";
                    command1.ExecuteNonQuery();

                    MessageBox.Show("The Admin has been added successfully.\nThe admin can now success the  control panel", "Added successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Admin.Clear();
                    passwordadmin.Clear();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
