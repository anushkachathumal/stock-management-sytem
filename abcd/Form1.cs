using abcd.posclasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abcd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        addstock c = new addstock();



        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            c.IteamCode = textB2.Text;
            c.Category = combo1.Text;
            c.quantity = textB3.Text;
            c.TakenPrice = textB4.Text;
            c.SalessPrice = textB5.Text;
            c.Takendiscount = textB6.Text;
            c.salessDiscount = textB7.Text;

            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("Sucsessfully saved stock");
            }
            else
            {
                MessageBox.Show("invaild ,try again");
            }



        }
    }
}
