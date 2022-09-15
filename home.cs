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
    public partial class home : UserControl
    {
        public home()
        {
            InitializeComponent();

        }

        string food;
        string price;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            food = "mix mug";
            price = "2500";
            Addon adn = new Addon();
            adn.MyProperty = food;
            adn.Myprice = price;
            adn.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            food = "Chiken Wings";
            price = "3500";
            Addon adn = new Addon();
            adn.MyProperty = food;
            adn.Myprice = price;
            adn.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            food = "BBQ Full Steak";
            price = "4500";
            Addon adn = new Addon();
            adn.MyProperty = food;
            adn.Myprice = price;
            adn.Show();

        }
    }
}
