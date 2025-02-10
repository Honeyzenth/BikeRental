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
    public partial class adminManage : Form
    {
        public adminManage()
        {
            InitializeComponent();
        }

        private void manageInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageInfo man = new ManageInfo();
            man.Show();
            this.Hide();
        }

        private void manageStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stocks rent = new Stocks();
            rent.Show();
            this.Hide();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm log = new loginForm();
            log.Show();
            this.Hide();
        }

        private void manageRentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rentDetails r = new rentDetails();
            r.Show();
            this.Hide();
        }

        private void adminManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void adminManage_Load(object sender, EventArgs e)
        {

        }
    }
}
