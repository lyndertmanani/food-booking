using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSysApp
{
    public partial class congratulation : Form
    {
        public congratulation()
        {
            InitializeComponent();
        }
        public string MyPropertys { get; set; }
        public string MyPrices { get; set; }
        public string MyMember { get; set; }
        public string MyDate { get; set; }
        public string MyAddress { get; set; }
        public string Mytotal { get; set; }
        private void congratulation_Load(object sender, EventArgs e)
        {
            product.Text = MyPropertys;
            member.Text = MyMember;
            Date.Text = MyDate;
            Address.Text = MyAddress;
            total.Text = Mytotal;

        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
