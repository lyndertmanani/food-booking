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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            home hm = new home();
            AdUserControl(hm);
        }
        MySqlConnection connect = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=bookingsys");
        private void main_Load(object sender, EventArgs e)
        {
            string Tag = "SELECT * FROM handles WHERE Username = '" + login.uName + "'";
            MySqlDataAdapter data = new MySqlDataAdapter(Tag, connect);
            DataTable table = new DataTable();
            data.Fill(table);
            if (table.Rows.Count == 1)
            {
                usernamel.Text = login.uName;
            }

        }

        private void AdUserControl(UserControl usercontrol)
        {
            holder.Controls.Clear();
            holder.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            home hm = new home();
            AdUserControl(hm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            booking bk = new booking();
            AdUserControl(bk);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            history hsty = new history();
            AdUserControl(hsty);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            account Acc = new account();
            AdUserControl(Acc);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            login lg = new login();
            this.Hide();
            lg.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
