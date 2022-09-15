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
    public partial class booking : UserControl
    {
        public booking()
        {
            InitializeComponent();
        }
        string food;
        string price;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            food = "Ting tain";
            price = "2500";
            Addon adn = new Addon();
            adn.MyProperty = food;
            adn.Myprice = price;
            adn.Show();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            food = "mix mug";
            price = "5000";
            Addon adn = new Addon();
            adn.MyProperty = food;
            adn.Myprice = price;
            adn.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            food = "Chop chop";
            price = "1500";
            Addon adn = new Addon();
            adn.MyProperty = food;
            adn.Myprice = price;
            adn.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            food = "Vegetable Stew";
            price = "3500";
            Addon adn = new Addon();
            adn.MyProperty = food;
            adn.Myprice = price;
            adn.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            food = "tim chop";
            price = "6000";
            Addon adn = new Addon();
            adn.MyProperty = food;
            adn.Myprice = price;
            adn.Show();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            food = "Pizza";
            price = "5000";
            Addon adn = new Addon();
            adn.MyProperty = food;
            adn.Myprice = price;
            adn.Show();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            food = " Pizza Mio";
            price = "4500";
            Addon adn = new Addon();
            adn.MyProperty = food;
            adn.Myprice = price;
            adn.Show();
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            food = " Coco Cake";
            price = "8500";
            Addon adn = new Addon();
            adn.MyProperty = food;
            adn.Myprice = price;
            adn.Show();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            food = "Table Mix";
            price = "6500";
            Addon adn = new Addon();
            adn.MyProperty = food;
            adn.Myprice = price;
            adn.Show();
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            food = "Simple Cake";
            price = "2500";
            Addon adn = new Addon();
            adn.MyProperty = food;
            adn.Myprice = price;
            adn.Show();
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            food = "Burger";
            price = "3500";
            Addon adn = new Addon();
            adn.MyProperty = food;
            adn.Myprice = price;
            adn.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            food = "Red Stew";
            price = "3500";
            Addon adn = new Addon();
            adn.MyProperty = food;
            adn.Myprice = price;
            adn.Show();
        }
    }
}
