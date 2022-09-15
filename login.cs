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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }


        public static string uName;
        private void Signlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign sg = new Sign();
            this.Hide();
            sg.Show();
        }

        private void Admintoplink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Adminlogins Adl = new Adminlogins();
            this.Hide();
           Adl.Show();
        }

        private void loginsubmitbtn_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=bookingsys";
            MySqlConnection connection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand command = new MySqlCommand();

            try
            {

                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM handles WHERE Username = '" + usernameltxt.Text + "' and Password = '" + passwordltxt.Text + "'";
                MySqlDataReader rd = command.ExecuteReader();
                uName = usernameltxt.Text;
                int count = 0;
                while (rd.Read())
                {
                    count = count + 1;

                }
                if (count == 1)
                {
                    main mn = new main();
                    this.Hide();
                    mn.Show();

                }
                else if (usernameltxt.Text == "" || passwordltxt.Text == "")
                {
                    MessageBox.Show("Unable to Login.. the text fields cannot be left empty", "Error on Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Unable to Login.. Please check your login credentials", "Error on Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
