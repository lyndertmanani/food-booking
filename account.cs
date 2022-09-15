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
    public partial class account : UserControl
    {
        public account()
        {
            InitializeComponent();
        }
        MySqlConnection connect = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=bookingsys");

        private void account_Load(object sender, EventArgs e)
        {
            username.Text = login.uName;

            MySqlCommand command = connect.CreateCommand();
            command.CommandText = "SELECT * FROM handles WHERE Username = '" + login.uName + "'";
            MySqlDataReader myReader;

            try
            {
                connect.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    username.Text = login.uName;
                    firstname.Text = myReader["firstname"].ToString();
                    surname.Text = myReader["surname"].ToString();
                    address.Text = myReader["address"].ToString();
                    phone.Text = myReader["phone"].ToString();
                    password.Text = myReader["password"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
        }
    }
}
