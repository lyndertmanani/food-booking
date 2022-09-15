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
    public partial class Adminlogins : Form
    {
        public Adminlogins()
        {
            InitializeComponent();
        }
        public static string aName;

        private void Signlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign sg = new Sign();
            this.Hide();
            sg.Show();
        }

        private void Adminlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login lg = new login();
            this.Hide();
            lg.Show();
        }

        private void loginadmin_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=bookingsys";
            MySqlConnection connection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand command = new MySqlCommand();

            try
            {

                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Admin WHERE Username = '" + admintxt.Text + "' and Password = '" + adminpasstxt.Text + "'";
                MySqlDataReader rd = command.ExecuteReader();
                aName = admintxt.Text;
                int count = 0;
                while (rd.Read())
                {
                    count = count + 1;

                }
                if (count == 1)
                {
                    Admin mn = new Admin();
                    this.Hide();
                    mn.Show();

                }
                else if (admintxt.Text == "" || adminpasstxt.Text == "")
                {
                    MessageBox.Show("Unable to Login.. the text fields cannot be left empty", "Error on Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(" Please check your login credentials user is not authorized", "Error on Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();
            }
            catch (Exception ex)
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
