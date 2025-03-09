using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private bool IsPasswordComplex(string password)
        {
            // Password must be at least 8 characters long, contain an uppercase letter, 
            // a lowercase letter, a number, and a special character.
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";

            return Regex.IsMatch(password, pattern);
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Mismatched password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CLEAR();
                    return;
                }

                if (txtFullname.Text == "" || txtEmail.Text == "" || txtPhoneNumber.Text == "" ||
                    txtAdd.Text == "" || txtUserName.Text == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "")
                {
                    MessageBox.Show("Fill up required fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CLEAR();
                    return;
                }

                // Check password complexity
                if (!IsPasswordComplex(txtPassword.Text))
                {
                    MessageBox.Show("Password must be at least 8 characters long and include a number, an uppercase letter, a lowercase letter, and a special character.",
                        "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Hash and salt password
                Encryption encrypt = new Encryption();
                string password = txtPassword.Text;
                string hashedPassword = encrypt.HashPassword(password);

                sql = "INSERT INTO [Customer_Signup] ([username], [password], [Name], [Email], [PhoneNumber], [Address]) " +
                      "VALUES('" + txtUserName.Text + "'," +
                      "'" + hashedPassword + "', " +
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
            catch (Exception ex)
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
