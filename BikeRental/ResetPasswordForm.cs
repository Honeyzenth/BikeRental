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
    public partial class ResetPasswordForm : Form
    {
        private string userEmail;
        public ResetPasswordForm(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void ResetPasswordForm_Load(object sender, EventArgs e)
        {

        }

        private bool IsPasswordComplex(string password)
        {
            // Password must be at least 8 characters long, contain an uppercase letter, 
            // a lowercase letter, a number, and a special character.
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";

            return Regex.IsMatch(password, pattern);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsPasswordComplex(txtNewPassword.Text))
            {
                MessageBox.Show("Password must be at least 8 characters long and include a number, an uppercase letter, a lowercase letter, and a special character.",
                    "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Encryption encrypt = new Encryption();

            string hashedPassword = encrypt.HashPassword(txtNewPassword.Text);
            UpdatePasswordInDatabase(userEmail, hashedPassword);

            MessageBox.Show("Password reset successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loginForm lf = new loginForm();
            this.Close();
            lf.ShowDialog();
        }

        private void UpdatePasswordInDatabase(string email, string hashedPassword)
        {

            string sql = "UPDATE Customer_Signup SET [password]='" + hashedPassword + "' WHERE Email='" + email + "'";
            DBhelper.DBhelper.ModifyRecord(sql);
        }
    }
}
