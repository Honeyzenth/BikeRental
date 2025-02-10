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
    public partial class ReturnBike : Form
    {
        public ReturnBike()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                
                sql = "Update Stocks set stocks = stocks+ '" + txtBikeNo.Text + "'" + "Where bikes  = '" + txtBike.Text + "'";
                DBhelper.DBhelper.ModifyRecord(sql);

                sql = "DELETE * FROM [Rent_Details] WHERE [bikes] = '" + txtBike.Text + "'";
                DBhelper.DBhelper.ModifyRecord(sql);
                   
                

                

                MessageBox.Show("Thank you for returning the Bike!", "Bike Return", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Bike Was Return As Stocks", "Bike Return", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ReturnBike_Load(sender, e);
            }
            catch(Exception ex)
            {MessageBox.Show(ex.Message);}
            }
        string sql;
        private void ReturnBike_Load(object sender, EventArgs e)

        { 
            lblRenterName.Text = loginForm.sendtext;
            sql = "Select * from Rent_Details WHERE CustomerName = '" + lblRenterName.Text + "'";
            DBhelper.DBhelper.fill(sql, dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                txtItemNo.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                txtBike.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                txtDailyRate.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                txtBikeNo.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                txtTotalPayment.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            }
            catch (Exception) { }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void ReturnBike_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}

