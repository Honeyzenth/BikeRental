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
    public partial class Form1 : Form


    {

       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = loginForm.sendtext;
            loginForm log = new loginForm();
            log.Show();
            log.Hide();
        }

        private void btnaddbiketoRent_Click(object sender, EventArgs e)
        {
            FillUpInfo add = new FillUpInfo();
            add.Show();
            this.Hide();

           
        }

        private void btnRentABike_Click(object sender, EventArgs e)
        {
            Purchase p = new Purchase();
            p.Show();
            Hide();
        }

        private void btnReturnBike_Click(object sender, EventArgs e)
        {
            ReturnBike ret = new ReturnBike();
            ret.Show();
            this.Hide();
            
        }

        private void btnDisplayReceipt_Click(object sender, EventArgs e)
        {
            DisplayReceipt dis = new DisplayReceipt();
            dis.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            loginForm l = new loginForm();
            l.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
