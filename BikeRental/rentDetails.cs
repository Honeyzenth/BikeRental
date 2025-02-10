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
    public partial class rentDetails : Form
    {
        public rentDetails()
        {
            InitializeComponent();
        }
        string sql = "";

        private void rentDetails_Load(object sender, EventArgs e)
        {
            //sql = "Select * from Rent_Details";
            //DBhelper.DBhelper.fill(sql, dgvdetails);
            sql = "Select * from Sales_Master";
            DBhelper.DBhelper.fill(sql, dgvSalesMaster);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminManage add = new adminManage();
            add.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT * FROM Sales_Master WHERE CustomerName Like '%" + txtSearch.Text + "%'";
                Connection.Connection.DB();
                //DBhelper.DBhelper.fill(sql, dgvdetails);
                DBhelper.DBhelper.fill(sql, dgvSalesMaster);

                Connection.Connection.conn.Close();

            }
            catch (Exception ex)
            {
                Connection.Connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    

        private void rentDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RentReport report = new RentReport();
            report.Show();
        }
    }
}
