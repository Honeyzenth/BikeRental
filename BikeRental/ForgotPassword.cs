using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using static BikeRental.DbConstants;
using System.Data.OleDb;

namespace BikeRental
{
    public partial class ForgotPassword : Form
    {
        private string generatedOTP; // Stores the OTP temporarily
        private string userEmail;    // Stores the user's email
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter your email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            userEmail = txtEmail.Text;

            if (!EmailExists(userEmail))
            {
                MessageBox.Show("Email not found in our records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            generatedOTP = new Random().Next(100000, 999999).ToString(); // Generate a 6-digit OTP

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(EMAIL); // Your email
                mail.To.Add(userEmail); // Recipient email
                mail.Subject = "Your OTP for Password Reset";
                mail.Body = $"Your OTP is: {generatedOTP}.\nThis OTP will expire in 3 minutes.";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(EMAIL, APP_PASSWORD); // Use App Password
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtp.Send(mail);

                MessageBox.Show("OTP sent to your email!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EmailExists(string email)
        {
            Connection.Connection.DB();

            string query = "SELECT Email FROM Customer_Signup WHERE Email = @Email";
            DBhelper.DBhelper.command = new OleDbCommand(query, Connection.Connection.conn);
            DBhelper.DBhelper.command.Parameters.AddWithValue("@Email", txtEmail.Text);

            DBhelper.DBhelper.reader = DBhelper.DBhelper.command.ExecuteReader();

            if (DBhelper.DBhelper.reader.HasRows)
            {
                Connection.Connection.conn.Close();
                return true;
            }
            else
            {
                Connection.Connection.conn.Close();
                return false;
            }
        }

        private void btnResetOTP_Click(object sender, EventArgs e)
        {
            if (txtOTP.Text == generatedOTP)
            {
                MessageBox.Show("OTP Verified! Please set a new password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide(); // Hide current form
                ResetPasswordForm resetForm = new ResetPasswordForm(userEmail);
                resetForm.ShowDialog(); // Show password reset form
            }
            else
            {
                MessageBox.Show("Invalid OTP! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
