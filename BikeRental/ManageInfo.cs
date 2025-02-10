using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace BikeRental
{
    public partial class ManageInfo : Form

    {

        string Sql;
        int age;
        public ManageInfo()
        {
            InitializeComponent();
        }
        
        private void AddBiketoRent_Load(object sender, EventArgs e)
        {
            Sql = "SELECT * from CustomerInfo";
            DBhelper.DBhelper.fill(Sql, dgvStock);
            GetMaxinfoNo.GetData.getMaxItem();
            txtBoxCustomerID.Text = GetMaxinfoNo.GlobalDeclaration.CustomerItemcode.ToString();
        }

        



        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminManage admin = new adminManage();
            admin.Show();
            this.Hide();
        }
        public void clearfields()
        {
            txtBoxCustomerID.Clear();
            txtBoxCustomerName.Clear();
            txtBoxAddress.Clear();
            txtBoxEmail.Clear();
            txtBoxAddress.Clear();
            txtBoxNumber.Clear();
            bRentalDate.Text = DateTime.Now.ToShortDateString();
            txtBoxAge.Clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                age = Convert.ToInt32(txtBoxAge.Text);

                if (age >= 18)
                {

                    Sql = "INSERT INTO CustomerInfo(CustomerID, Customername, Address, Email, PhoneNumber, RentalDate, Datemodified, Age)"
                  + "values('" + txtBoxCustomerID.Text + "'," + " '"

                  + txtBoxCustomerName.Text + "'," + " '"
                  + txtBoxAddress.Text + "'," + " '"
                  + txtBoxEmail.Text + "'," + " '"
                  + txtBoxNumber.Text + "'," + " '"
                  + bRentalDate.Value.Date + "'," + " '"
                  + DateTime.Now.ToShortDateString() + "'," + " '"
                  + txtBoxAge.Text + "')";
                    DBhelper.DBhelper.ModifyRecord(Sql);
                    MessageBox.Show("Data has been added...", "Save new Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     AddBiketoRent_Load(sender, e);
                clearfields();
                }
                else
                {
                    MessageBox.Show("Invalid Under Age...","Under Age",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtBoxCustomerID.Text = dgvStock[0, e.RowIndex].Value.ToString();
                txtBoxCustomerName.Text = dgvStock[1, e.RowIndex].Value.ToString();
                txtBoxAddress.Text = dgvStock[2, e.RowIndex].Value.ToString();
                txtBoxEmail.Text = dgvStock[3, e.RowIndex].Value.ToString();
                txtBoxNumber.Text = dgvStock[4, e.RowIndex].Value.ToString();
                bRentalDate.Text = dgvStock[5, e.RowIndex].Value.ToString();
                txtBoxAge.Text = dgvStock[7, e.RowIndex].Value.ToString();
            }
            catch (Exception) { }


        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to delete this record? ",
               "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Sql = "Delete * from CustomerInfo where CustomerID =" + txtBoxCustomerID.Text + "";
                DBhelper.DBhelper.ModifyRecord(Sql);
                AddBiketoRent_Load(sender, e);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Sql = "UPDATE CustomerInfo SET Customername = '" + txtBoxCustomerName.Text
                 + "', Address = '" + txtBoxAddress.Text
                 + "', Email = '" + txtBoxEmail.Text
                 + "', PhoneNumber = '" + txtBoxNumber.Text
                 + "', RentalDate = '" + bRentalDate.Value.Date
                 + "', Datemodified = '" + DateTime.Now.ToShortDateString()
                 + "', Age = '" + txtBoxAge.Text
                 + "' WHERE CustomerID = " + txtBoxCustomerID.Text + "";


            DBhelper.DBhelper.ModifyRecord(Sql);
            MessageBox.Show("Data has been updated...", "Updated CustomerInformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AddBiketoRent_Load(sender, e);
           
        }

        private void ManageInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}

