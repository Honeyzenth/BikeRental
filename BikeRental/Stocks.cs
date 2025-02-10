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
    public partial class Stocks : Form
    {
        public Stocks()
        {
            InitializeComponent();
        }

        private void RentABike_Load(object sender, EventArgs e)
        {
            sql = "SELECT * from Stocks";
            DBhelper.DBhelper.fill(sql, dataGridView1);
            GetMaxinfoNo.GetData.getMaxItem1();
            txtRentID.Text = GetMaxinfoNo.GlobalDeclaration.itemNumber.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminManage ma = new adminManage();
            ma.Show();
            this.Hide();
        }

        private void CbSelectBike_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbSelectBike.Text == "RoadBike")
            {
                txtDailyRate.Text = "80";
                pbBikes.ImageLocation = @"C:\Users\sheil\source\repos\BikeRental\BikeRental\bin\Debug\RoadBike.png";

            }
            else if (CbSelectBike.Text == "MountainBike")
            {
                txtDailyRate.Text = "70";
                pbBikes.ImageLocation = @"C:\Users\sheil\source\repos\BikeRental\BikeRental\bin\Debug\MountainBike.png";
            }
            else if (CbSelectBike.Text == "AdventureBike")
            {
                txtDailyRate.Text = "75";
                pbBikes.ImageLocation = @"C:\Users\sheil\source\repos\BikeRental\BikeRental\bin\Debug\AdventureBike.png";

            }
            else if (CbSelectBike.Text == "ClassicBike")
            {
                txtDailyRate.Text = "30";
                pbBikes.ImageLocation = @"C:\Users\sheil\source\repos\BikeRental\BikeRental\bin\Debug\ClassicBike.png";

            }
            else if (CbSelectBike.Text == "ElectricBike")
            {
                txtDailyRate.Text = "100";
                pbBikes.ImageLocation = @"C:\Users\sheil\source\repos\BikeRental\BikeRental\bin\Debug\ElectricBike.png";

            }
            else if (CbSelectBike.Text == "FoldingBike")
            {
                txtDailyRate.Text = "20";
                pbBikes.ImageLocation = @"C:\Users\sheil\source\repos\BikeRental\BikeRental\bin\Debug\FoldingBike.png";

            }
            else if (CbSelectBike.Text == "HybridBike")
            {
                txtDailyRate.Text = "35";
                pbBikes.ImageLocation = @"C:\Users\sheil\source\repos\BikeRental\BikeRental\bin\Debug\HybridBike.png";

            }
        }
        

        public void clear()
            {
           // txtRentID.Clear();
            CbSelectBike.Text = "";
            txtDailyRate.Clear();
            txtStock.Clear();
            

            }
        string sql;
        private void btnrent_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "INSERT INTO Stocks(itemCode, Bikes, dailyrate, stocks)"
                       + "values('" + txtRentID.Text + "'," + " '"
                       + CbSelectBike.Text + "'," + " '"
                       + txtDailyRate.Text + "'," + " '"
                       + txtStock.Text  +"')";
                DBhelper.DBhelper.ModifyRecord(sql);
                MessageBox.Show("Stocks has been added...", "Save new Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RentABike_Load(sender, e);
                clear();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRentID.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            CbSelectBike.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            txtDailyRate.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            txtStock.Text = dataGridView1[3, e.RowIndex].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to delete this record? ",
               "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                sql = "Delete * from Stocks where itemCode =" + txtRentID.Text + "";
                DBhelper.DBhelper.ModifyRecord(sql);
                RentABike_Load(sender, e);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sql = "UPDATE Stocks SET Bikes = '" + CbSelectBike.Text
               + "', DailyRate = '" + txtDailyRate.Text 
               + "', stocks  = '" + txtStock.Text
               + "' WHERE itemCode = " + txtRentID.Text + "";


            DBhelper.DBhelper.ModifyRecord(sql);
            MessageBox.Show("Data has been updated...", "Updated Stocks", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RentABike_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RentABike_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
