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
    public partial class history : UserControl
    {
        public history()
        {
            InitializeComponent();
        }
        MySqlConnection connect = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=bookingsys;convert Zero Datetime=True");
        private void history_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter My = new MySqlDataAdapter("SELECT * FROM bookings WHERE holder = '" + login.uName + "'", connect);
            DataTable dTable = new DataTable();
            My.Fill(dTable);
            dataGridView1.DataSource = dTable;
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            try
            {

                MySqlCommand cmd = new MySqlCommand("select Date from bookings where date='" + newD.Text + "'", connect);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Dear customer you already have a session on that day\nPlease book a different day thank you");
                }
                else
                {
                    connect.Open();
                    command.Connection = connect;
                    command.CommandText = "Update bookings  set Date =  '" + newD.Text + "' WHERE Date = '" + oldtxt.Text + "'";
                    command.ExecuteNonQuery();
                    oldtxt.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MySqlDataAdapter My = new MySqlDataAdapter("SELECT * FROM bookings WHERE holder = '" + login.uName + "'", connect);
            DataTable dTable = new DataTable();
            My.Fill(dTable);
            dataGridView1.DataSource = dTable;
        }
    }
}
