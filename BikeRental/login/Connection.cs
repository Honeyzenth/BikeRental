using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using static BikeRental.DbConstants;

namespace BikeRental.Connection
{
    class Connection
    {
        public static OleDbConnection conn;
        public static string dbConnection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DB_DIRECTORY;
        public static void DB()
        {
            try
            {
                conn = new OleDbConnection(dbConnection);
                conn.Open();
            }
            catch (Exception e)
            {
                conn.Close();
                MessageBox.Show(e.Message);
            }

        }
    }
}
