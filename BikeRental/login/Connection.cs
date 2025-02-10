using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BikeRental.Connection
{
    class Connection
    {
        public static OleDbConnection conn;
        public static string dbConnection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maven\Downloads\BikeRental Latest Final\BikeRental\BikeRental\Database3.accdb";
        public static void DB()
        {
            try
            {
                conn = new OleDbConnection(dbConnection);
                conn.Open();
            }
            catch(Exception e) {
                conn.Close();
                MessageBox.Show(e.Message);
            }
            
        }
    }
}
