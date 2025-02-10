using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeRental
{
    public partial class DisplayReceipt : Form
    {
        public DisplayReceipt()
        {
            InitializeComponent();
        }

        public void setValues(string id, string selectedike, string dailyrate, string bikeno, string subgtotal, string totalpayment, string cash, string change)
        {
            lblrentid.Text = id;
            lblselectedbike.Text = selectedike;
            lblDailyrate.Text = dailyrate;
            lblbikeno.Text = bikeno;
            lblSubtotal.Text = subgtotal;
            lbltotalpayment.Text = totalpayment;
            lblcash.Text = cash;
            lblchange.Text = change;
            
        }
        private void DisplayReceipt_Load(object sender, EventArgs e)
        {
            lblcust.Text = loginForm.sendtext;

        }

        private void DisplayReceipt_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
