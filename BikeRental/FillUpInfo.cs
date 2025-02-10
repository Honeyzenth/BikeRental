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
    public partial class FillUpInfo : Form

    {

        string Sql;
        int age;
        public FillUpInfo()
        {
            InitializeComponent();
        }
        
        private void AddBiketoRent_Load(object sender, EventArgs e)
        {

            
            txtBoxCustomerName.Text = Signup.fullname;
            txtBoxEmail.Text = Signup.email;
            txtBoxNumber.Text = Signup.phonenumber;
            txtBoxAddress.Text = Signup.address;

            Sql = "SELECT * from CustomerInfo";
            DBhelper.DBhelper.fill(Sql, dgvStock);
            GetMaxinfoNo.GetData.getMaxItem();
            txtBoxCustomerID.Text = GetMaxinfoNo.GlobalDeclaration.CustomerItemcode.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
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
            dpRentalDate.Text = DateTime.Now.ToShortDateString();
            txtBoxAge.Clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                /** Sql = "INSERT INTO CustomerInfo(CustomerID,Firstname,Lastname,Address,Email,PhoneNumber,RentalDate,Datemodified,Age)values('" + txtBoxCustomerID.Text +
                    "','" + txtBoxFirstName.Text + "','" + txtBoxLastname.Text + "','" +txtBoxAddress.Text+ "','" + txtBoxEmail.Text + "','" + txtBoxNumber.Text + "','" + dpRentalDate.Text + "','" + DateTime.Now.ToShortDateString() + "','" +
                    txtBoxAge.Text + "')";*/
                age = Convert.ToInt32(txtBoxAge.Text);

                if (age >= 18)
                {
                    
                    Sql = "INSERT INTO CustomerInfo(CustomerID, Customername, Address, Email, PhoneNumber, RentalDate, Datemodified, Age)"
                   + "values('" + txtBoxCustomerID.Text + "'," + " '"
                   
                   + txtBoxCustomerName.Text + "'," + " '"
                   + txtBoxAddress.Text + "'," + " '"
                   + txtBoxEmail.Text + "'," + " '"
                   + txtBoxNumber.Text + "'," + " '"
                   + dpRentalDate.Value.Date + "'," + " '"
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
            txtBoxCustomerID.Text = dgvStock[0, e.RowIndex].Value.ToString();
            
            txtBoxCustomerName.Text = dgvStock[1, e.RowIndex].Value.ToString();
            txtBoxAddress.Text = dgvStock[2, e.RowIndex].Value.ToString();
            txtBoxEmail.Text = dgvStock[3, e.RowIndex].Value.ToString();
            txtBoxNumber.Text = dgvStock[4, e.RowIndex].Value.ToString();
            dpRentalDate.Text = dgvStock[5, e.RowIndex].Value.ToString();
            txtBoxAge.Text = dgvStock[7, e.RowIndex].Value.ToString();
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
            Sql = "UPDATE CustomerInfo SET Customername = '"  + txtBoxCustomerName.Text
                + "', Address = '" + txtBoxAddress.Text
                + "', Email = '" + txtBoxEmail.Text
                + "', PhoneNumber = '" + txtBoxNumber.Text
                + "', RentalDate = '" + dpRentalDate.Value.Date
                + "', Datemodified = '" + DateTime.Now.ToShortDateString()
                + "', Age = '" + txtBoxAge.Text
                + "' WHERE CustomerID = " + txtBoxCustomerID.Text + "";


            DBhelper.DBhelper.ModifyRecord(Sql);
            MessageBox.Show("Data has been updated...", "Updated CustomerInformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AddBiketoRent_Load(sender, e);
           
        }

        private void FillUpInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
    }

