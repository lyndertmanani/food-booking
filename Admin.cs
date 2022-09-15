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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            signupA SgnA = new signupA();
            AdControl(SgnA);
        }
        MySqlConnection connect = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=bookingsys");
        private void AdControl(UserControl usercontrol)
        {
            Ahold.Controls.Clear();
            Ahold.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            string Tag = "SELECT * FROM admin WHERE Username = '" + Adminlogins.aName + "'";
            MySqlDataAdapter data = new MySqlDataAdapter(Tag, connect);
            DataTable table = new DataTable();
            data.Fill(table);
            if (table.Rows.Count == 1)
            {
                usernamel.Text = Adminlogins.aName;
            }

        }
 
        private void button2_Click(object sender, EventArgs e)
        {
            Bookings bbk = new Bookings();
            AdControl(bbk);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            signupA SgnA = new signupA();
            AdControl(SgnA);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Adminlogins er = new Adminlogins();
            er.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Abooking abk = new Abooking();
            AdControl(abk);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
