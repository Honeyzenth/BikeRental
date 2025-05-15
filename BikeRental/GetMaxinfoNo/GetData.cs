using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace BikeRental.GetMaxinfoNo
{
    class GetData
    {
        public static void getMaxItem()
        {
            try
            {
                string sql = "Select MAX(CustomerID)from CustomerInfo";
                Connection.Connection.DB();
                GlobalDeclaration.command = new OleDbCommand(sql, Connection.Connection.conn);
                GlobalDeclaration.reader = GlobalDeclaration.command.ExecuteReader();
                if (GlobalDeclaration.reader.Read())
                {
                    sql = GlobalDeclaration.reader[0].ToString();
                    if (sql == "")
                    {
                        GlobalDeclaration.CustomerItemcode = 1;
                    }
                    else
                    {
                        GlobalDeclaration.CustomerItemcode = Convert.ToInt32(GlobalDeclaration.reader[0].ToString()) + 1;
                    }
                    GlobalDeclaration.reader.Close();
                }
                Connection.Connection.conn.Close();
            }
            catch (Exception ex)
            {
                Connection.Connection.conn.Close();
                MessageBox.Show("Error ---> GET MAX ID" + ex.Message);
            }

        }
        public static void getMaxItem1()
        {
            try
            {
                string sql = "Select MAX(itemCode)from Stocks";
                Connection.Connection.DB();
                GlobalDeclaration.command = new OleDbCommand(sql, Connection.Connection.conn);
                GlobalDeclaration.reader = GlobalDeclaration.command.ExecuteReader();
                if (GlobalDeclaration.reader.Read())
                {
                    sql = GlobalDeclaration.reader[0].ToString();
                    if (sql == "")
                    {
                        GlobalDeclaration.itemNumber = 1;
                    }
                    else
                    {
                        GlobalDeclaration.itemNumber = Convert.ToInt32(GlobalDeclaration.reader[0].ToString()) + 1;
                    }
                    GlobalDeclaration.reader.Close();
                }
                Connection.Connection.conn.Close();
            }
            catch (Exception ex)
            {
                Connection.Connection.conn.Close();
                MessageBox.Show("Error ---> GET MAX ID" + ex.Message);
            }

        }
        public static void getMaxORNO()
        {
            try
            {
                string sql = "Select MAX(RentNo) from Sales_Master";
                Connection.Connection.DB();
                GlobalDeclaration.command = new OleDbCommand(sql, Connection.Connection.conn);
                GlobalDeclaration.reader = GlobalDeclaration.command.ExecuteReader();
                if (GlobalDeclaration.reader.Read())
                {
                    sql = GlobalDeclaration.reader[0].ToString();
                    if (sql == "")
                    {
                        GlobalDeclaration.BIKENO = 10001;
                    }
                    else
                    {
                        GlobalDeclaration.BIKENO = Convert.ToInt32(GlobalDeclaration.reader[0].ToString())+1;
                    }
                    GlobalDeclaration.reader.Close();
                }
                Connection.Connection.conn.Close();
            }
            catch (Exception ex)
            {
                Connection.Connection.conn.Close();
                MessageBox.Show("Error ---> GET MAX RentNo" + ex.Message);
            }
        }
    }
}
