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
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }
        public string sql = "";
        private void RentABike_Load(object sender, EventArgs e)
        {
            lblname.Text = loginForm.sendtext;
            sql = "SELECT * from Stocks";
            DBhelper.DBhelper.fill(sql, dataGridView1);
            GetMaxinfoNo.GetData.getMaxItem1();
            txtRentID.Text = GetMaxinfoNo.GlobalDeclaration.BIKENO.ToString();  
        }

       
        public void getsum()
        {
            double sum = 0;
            for (int i = 0; i < dgvPurchase.RowCount - 1; i++)
            {
                sum += Convert.ToDouble(dgvPurchase.Rows[i].Cells[4].Value);
            }
            txtTotalPayment.Text = sum.ToString("N2");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
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
            
            

            }
 

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRentID.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            CbSelectBike.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            txtDailyRate.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            txtStock.Text = dataGridView1[3, e.RowIndex].Value.ToString();

        }      

        private void dgvPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRentID.Text = dgvPurchase[0, e.RowIndex].Value.ToString();
            CbSelectBike.Text = dgvPurchase[1, e.RowIndex].Value.ToString();
            txtDailyRate.Text = dgvPurchase[2, e.RowIndex].Value.ToString();
            txtBikeNo.Text = dgvPurchase[3, e.RowIndex].Value.ToString();
            txtSubtotal.Text = dgvPurchase[4, e.RowIndex].Value.ToString();
            

            txtTotalPayment.Text = subtotal.ToString("N2");
            txtBikeNo.Select();
        }
        double subtotal;
        private void btnTotal_Click(object sender, EventArgs e)
        {
            getsum();
           
        }

        private void dgvPurchase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPurchase.Columns[e.ColumnIndex].Name == "cancel" && e.RowIndex >= 0)
            {
                dgvPurchase.Rows.Remove(dgvPurchase.Rows[e.RowIndex]);
                getsum();
            }
        }

        private void btnSubtotal_Click(object sender, EventArgs e)
        {
            double bikeno = 1;

            if (txtBikeNo.Text != "")
            {
                bikeno = Convert.ToDouble(txtBikeNo.Text);
            }

            double dailyrate = Convert.ToDouble(txtDailyRate.Text);
            double stocks = Convert.ToDouble(txtStock.Text);
            txtBikeNo.Text = bikeno.ToString();
            try
            {
                if (bikeno > stocks)
                {

                    MessageBox.Show("Bike number is more than available in stocks", "Stocks Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    subtotal = bikeno * dailyrate;
                    txtSubtotal.Text = subtotal.ToString("N2");
                    dgvPurchase.Rows.Add(txtRentID.Text, CbSelectBike.Text, txtDailyRate.Text, bikeno, txtSubtotal.Text);
                }
            }
            catch
            {
                MessageBox.Show("Please Select Rent", "Select Bikes", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }


        private void btnRent3_Click(object sender, EventArgs e)
        {
            try
            {
                var Cash = txtCash.Text;
                double cashresult;
                double.TryParse(Cash, out cashresult);

                var total = txtTotalPayment.Text;
                double totalresult;
                double.TryParse(total, out totalresult);
                if (totalresult > cashresult)

                {
                    MessageBox.Show("Please Enter Enough Amount!! ");
                }
                else {
                    txtChange.Text = (cashresult - totalresult).ToString("N2");
                    GetMaxinfoNo.GetData.getMaxORNO();
                    String RentNo = GetMaxinfoNo.GlobalDeclaration.BIKENO.ToString();

                    //sales master
                    string name2 = Convert.ToString(lblname.Text);
                    sql = "Insert into Sales_Master values ('" + RentNo + "', '" + DateTime.Now.ToShortDateString() + "', '"+name2 + "')";
                    DBhelper.DBhelper.ModifyRecord(sql);
                    

                    for (int i = 0; i < dgvPurchase.Rows.Count - 1; i++)
                    {
                         string itemNumber = dgvPurchase.Rows[i].Cells[0].Value.ToString();
                        string bikes = dgvPurchase.Rows[i].Cells[1].Value.ToString();
                        string dailyrate = dgvPurchase.Rows[i].Cells[2].Value.ToString();
                        string BikeNo = dgvPurchase.Rows[i].Cells[3].Value.ToString();
                        string total1 = dgvPurchase.Rows[i].Cells[4].Value.ToString();
                         
                        
                        sql = "Insert into Rent_Details values ('" + RentNo + "', '" + bikes +"', '"+ dailyrate + "' , '"+ BikeNo + "' , '"+ total1 + "','" + name2 + "')";
                        DBhelper.DBhelper.ModifyRecord(sql);

                        sql = "Update Stocks set stocks = stocks- '" + BikeNo + "'" + "Where Bikes  = '" + bikes + "'";
                        DBhelper.DBhelper.ModifyRecord(sql);

                    }

                    MessageBox.Show("Succesfull Payment...", "Sales_Master", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("You can View the receipt now...", "Updated Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            catch 
            { 
            
            }
        }

        private void btnDisplayReceipt_Click(object sender, EventArgs e)
        {
            DisplayReceipt d = new DisplayReceipt();
            
            string bike = "";
            string dailyrate = "";
            string bikeNo = "";
            string Subtotal = "";
            
              
            for (int i = 0; i<dgvPurchase.Rows.Count - 1; i++)
            {
                string a = dgvPurchase.Rows[i].Cells[1].Value.ToString();
                string b = dgvPurchase.Rows[i].Cells[2].Value.ToString();
                string c = dgvPurchase.Rows[i].Cells[3].Value.ToString();
                string et = dgvPurchase.Rows[i].Cells[4].Value.ToString();
                bike += a + "\n";
                dailyrate += b + "\n";
                bikeNo += c + "\n";
                Subtotal += et + "\n";
            }
            d.setValues(txtRentID.Text, bike, dailyrate, bikeNo, Subtotal, txtTotalPayment.Text, txtCash.Text, txtChange.Text);
            d.Show();
            
        }

        private void Purchase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
