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
                DBhelper.DBhelper.gen = "Select * from Customer_Signup where username = '" + txtUsername.Text + "' and password = '" + txtPassword.Text
                    + "'";
                DBhelper.DBhelper.command = new OleDbCommand(DBhelper.DBhelper.gen, Connection.Connection.conn);
                DBhelper.DBhelper.reader = DBhelper.DBhelper.command.ExecuteReader();
                if (DBhelper.DBhelper.reader.HasRows)
                {
                    DBhelper.DBhelper.reader.Read();
                    txtUsername.Text = (DBhelper.DBhelper.reader["username"].ToString());
                    txtPassword.Text = (DBhelper.DBhelper.reader["password"].ToString());


                    sendtext = txtUsername.Text;



                    timer1.Enabled = true;
                    timer1.Start();
                    timer1.Interval = 1;
                    progressBar1.Maximum = 200;
                    timer1.Tick += new EventHandler(timer1_Tick);

                    



                }
                else if (txtUsername.Text != "admin" && txtPassword.Text != "admin")
                {
                    Connection.Connection.DB();
                    DBhelper.DBhelper.gen = "Select * from Customer_Signup where username = '" + txtUsername.Text + "' and password = '" + txtPassword.Text
                        + "'";
                    DBhelper.DBhelper.command = new OleDbCommand(DBhelper.DBhelper.gen, Connection.Connection.conn);
                    DBhelper.DBhelper.reader = DBhelper.DBhelper.command.ExecuteReader();
                    if (DBhelper.DBhelper.reader.HasRows)
                    {
                        DBhelper.DBhelper.reader.Read();
                        txtUsername.Text = (DBhelper.DBhelper.reader["username"].ToString());
                        txtPassword.Text = (DBhelper.DBhelper.reader["password"].ToString());


                        /** info.fullname = DBhelper.DBhelper.reader["fullname"].ToString();
                         info.email = DBhelper.DBhelper.reader["email"].ToString();
                         info.phonenumber = DBhelper.DBhelper.reader["phonenumber"].ToString();
                         info.address = DBhelper.DBhelper.reader["address"].ToString();*/

                        sendtext = txtUsername.Text;
                        timer2.Enabled = true;
                        timer2.Start();
                        timer2.Interval = 1;
                        progressBar1.Maximum = 200;
                        timer2.Tick += new EventHandler(timer2_Tick);




                    }
                    else {
                        MessageBox.Show("Wrong Username or Password", "Invalid account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPassword.Clear();
                    }
                    Connection.Connection.conn.Close();
                }
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
            else {
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
    }
}
