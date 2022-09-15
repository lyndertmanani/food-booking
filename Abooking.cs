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
    public partial class Abooking : UserControl
    {
        public Abooking()
        {
            InitializeComponent();
        }

        String Mytotal;
        string Myaddress;

        MySqlConnection connect = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=bookingsys");

        private void signupbtn_Click(object sender, EventArgs e)
        {
            Myaddress = "N/A";
            MySqlCommand command = new MySqlCommand();
            try
            {

                MySqlCommand cmd = new MySqlCommand("select Date,holder from bookings where date='" + DateB.Text + "' AND Holder='" + Clienttxt.Text + "'", connect);
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
                    command.CommandText = "INSERT INTO bookings VALUES ('" + "" + "', '" + Clienttxt.Text  + "','" + Producttxt.Text + "','" + pricetxt.Text + "','" + DateB.Text + "','" + Myaddress + "','" + Mytotal + "')";
                    command.ExecuteNonQuery();

                    congratulation con = new congratulation();
                    con.MyPropertys = Clienttxt.Text;
                    con.MyPrices = Producttxt.Text;
                    con.MyMember = MemberBar.Text;
                    con.MyDate = DateB.Text;
                    con.Mytotal = Mytotal;
                    con.MyAddress = Myaddress;
                    con.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Clienttxt.Clear();
            Producttxt.Clear();
            totall.Text = "your total price will disply here";

        }

        private void MemberBar_ValueChanged(object sender, EventArgs e)
        {
            

            int pirceC = Convert.ToInt32(pricetxt.Text);
            int members = Convert.ToInt32(MemberBar.Value);
            int total = pirceC * members;
            totall.Text = total.ToString();
            Mytotal = totall.Text;

            totall.Update();
            totall.Refresh();
        }

        private void Abooking_Load(object sender, EventArgs e)
        {
            
             
        }
    }
}
