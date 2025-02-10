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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        string sql = "";
        
            public static string fullname = "";
            public static string email = "";
            public static string phonenumber = "";
            public static string address = "";

        private void btnCreateAccount_Click(object sender, EventArgs e)

        {
            
            try {
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Mismatched password ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CLEAR();
                }
                else if (txtFullname.Text == "" && txtEmail.Text == "" && txtPhoneNumber.Text == "" && txtAdd.Text == "" && txtUserName.Text == "" && txtPassword.Text == "" && txtConfirmPassword.Text == "")
                {
                    MessageBox.Show("fill up required field ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CLEAR();
                }
                else {
                    sql = "INSERT INTO [Customer_Signup] ([username], [password], [Name], [Email], [PhoneNumber],[Address]  )" +
                        "VALUES('" + txtUserName.Text + "'," +
                       "'" + txtPassword.Text + "', " +
                       "'" + txtFullname.Text + "', " +
                        "'" + txtEmail.Text + "', " +
                        "'" + txtPhoneNumber.Text + "'," +
                        "'" + txtAdd.Text + "')";
                    DBhelper.DBhelper.ModifyRecord(sql);
                    MessageBox.Show("Account Created!");

                    fullname = txtFullname.Text;
                    email = txtEmail.Text;
                    phonenumber = txtPhoneNumber.Text;
                    address = txtAdd.Text;
                    loginForm L = new loginForm();
                    L.Show();
                    this.Hide();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CLEAR()
        {
            txtConfirmPassword.Clear(); 
        }

        private void Signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }
    }
}
