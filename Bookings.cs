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
    public partial class Bookings : UserControl
    {
        public Bookings()
        {
            InitializeComponent();
        }
        MySqlConnection connect = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=bookingsys;convert Zero Datetime=True");

        private void Bookings_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter M = new MySqlDataAdapter("SELECT id,holder,date,address,total_price FROM bookings ", connect);
            DataTable eTable = new DataTable();
            M.Fill(eTable);
            dataGridView1.DataSource = eTable;
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            try
            {

                MySqlCommand cmd = new MySqlCommand("select Date,id from bookings where date='" + newD.Text + "' AND id ='" + oldtxtid.Text + "'", connect);
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
                    command.CommandText = "Update bookings  set Date =  '" + newD.Text + "' WHERE id = '" + oldtxtid.Text + "'";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Update has been made succesfully");
                    oldtxtid.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MySqlDataAdapter M = new MySqlDataAdapter("SELECT id,holder,date,address,total_price FROM bookings ", connect);
            DataTable eTable = new DataTable();
            M.Fill(eTable);
            dataGridView1.DataSource = eTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            try
            {

                connect.Open();
                command.Connection = connect;
                command.CommandText = "DELETE FROM Bookings WHERE ID = '" + ClientiD.Text + "'";
                command.ExecuteNonQuery();
                ClientiD.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            MySqlDataAdapter M = new MySqlDataAdapter("SELECT id,holder,date,address,total_price FROM bookings ", connect);
            DataTable eTable = new DataTable();
            M.Fill(eTable);
            dataGridView1.DataSource = eTable;
        }
    }
}
