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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            AcceptButton = btnLogin;
        }
        public static string sendtext = "";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();

                string query = "SELECT password FROM Customer_Signup WHERE username = @username";
                DBhelper.DBhelper.command = new OleDbCommand(query, Connection.Connection.conn);
                DBhelper.DBhelper.command.Parameters.AddWithValue("@username", txtUsername.Text);

                DBhelper.DBhelper.reader = DBhelper.DBhelper.command.ExecuteReader();

                if (DBhelper.DBhelper.reader.HasRows)
                {
                    DBhelper.DBhelper.reader.Read();
                    string storedHashedPassword = DBhelper.DBhelper.reader["password"].ToString();

                    Encryption encrypt = new Encryption();
                    bool isValid = encrypt.VerifyPassword(txtPassword.Text, storedHashedPassword);

                    if (isValid)
                    {
                        sendtext = txtUsername.Text;

                        timer1.Enabled = true;
                        timer1.Start();
                        timer1.Interval = 1;
                        progressBar1.Maximum = 200;
                        timer1.Tick += new EventHandler(timer1_Tick);
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password", "Invalid account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPassword.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Invalid account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Clear();
                }

                Connection.Connection.conn.Close();
            }
            catch (Exception ex)
            {
                Connection.Connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 200)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                progressBar1.Value = 0;
                adminManage add = new adminManage();
                add.Show();
                this.Hide();


            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Signup si = new Signup();
            si.Show();
            this.Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 200)
            {
                progressBar1.Value++;
            }
            else
            {
                timer2.Stop();
                progressBar1.Value = 0;
                Form1 f = new Form1();
                f.Show();
                this.Hide();

            }

        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void lblForgotPwd_Click(object sender, EventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            fp.Show();
            this.Hide();
        }
    }
}
