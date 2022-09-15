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
    public partial class Addon : Form
    {
        public Addon()
        {
            InitializeComponent();
        }
        public string MyProperty { get; set; }
        public string Myprice { get; set; }
        string MyAddress;
        string Myprices;
        string MyMember;
        string MyDate;
        string Mytotal;
        string MyPropertys;
        // string refesher;

        MySqlConnection connect = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=bookingsys");
        private void loginlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        private void Addon_Load(object sender, EventArgs e)
        {
            MyMember= login.uName;
            MyPropertys = MyProperty;
            MyDate = DateB.Text;
            productl.Text = MyProperty;
            Myprices = Myprice;
            price.Text = Myprice;
            //Print from the database 
            MySqlCommand command = connect.CreateCommand();
            command.CommandText = "SELECT * FROM handles WHERE Username = '" + login.uName + "'";
            MySqlDataReader myReader;

            try
            {
                connect.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    Address.Text = myReader["Address"].ToString();
                    MyAddress = myReader["Address"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
             
            int pirceC = Convert.ToInt32(Myprice);
            int members = Convert.ToInt32(MemberBar.Value);
            int total = pirceC * members;
            totall.Text = total.ToString();
            Mytotal  = totall.Text;


        }

        private void signupbtn_Click(object sender, EventArgs e)
        { 

            MySqlCommand command = new MySqlCommand();
            try
            {

                MySqlCommand cmd = new MySqlCommand("select * from bookings where date='" + DateB.Text + "' AND holder ='" + login.uName+ "'", connect);
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
                    command.CommandText = "INSERT INTO bookings VALUES ('" + "" + "', '" + login.uName + "','" +MyProperty + "','" + Myprice + "','" + DateB.Text + "','" + MyAddress + "','" + Mytotal  + "')";
                    command.ExecuteNonQuery();

                   congratulation con = new congratulation();
                    con.MyPropertys = MyPropertys;
                    con.MyPrices = Myprice;
                    con.MyMember = MyMember;
                    con.MyDate = MyDate;
                    con.MyAddress = MyAddress;
                    con.Mytotal = Mytotal;
                    this.Hide();
                    con.Show();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MemberBar_ValueChanged(object sender, EventArgs e)
        {
            int pirceC = Convert.ToInt32(Myprice);
            int members = Convert.ToInt32(MemberBar.Value);
            int total = pirceC * members;
            totall.Text = total.ToString();
            Mytotal = totall.Text;

            totall.Update();
            totall.Refresh();
            
        }

        private void MemberBar_Click(object sender, EventArgs e)
        {
             
            totall.Update();
            totall.Refresh();
        }
    }
}
