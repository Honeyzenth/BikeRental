﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;


namespace BikeRental.DBhelper
{
    class DBhelper
    {
        public static string gen = "";
        public static OleDbConnection conn;
        public static OleDbCommand command;
        public static OleDbDataReader reader;
        public static void fill(string q, DataGridView dgv)
        {
            try
            {
                Connection.Connection.DB();
                DataTable dt = new DataTable();
                OleDbDataAdapter data = null;
                OleDbCommand command = new OleDbCommand(q, Connection.Connection.conn);
                data = new OleDbDataAdapter(command);
                data.Fill(dt);
                dgv.DataSource = dt;
                Connection.Connection.conn.Close();

            }
            catch (Exception ex)
            {
                Connection.Connection.conn.Close();
                MessageBox.Show(ex.Message, "Error Fill Data GridView", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        public static void ModifyRecord(String updates)
        {
            try
            {
                Connection.Connection.DB();
                OleDbCommand command = new OleDbCommand(updates, Connection.Connection.conn);
                command.ExecuteNonQuery();
                Connection.Connection.conn.Close();
            }
            catch (Exception ex)
            {
                Connection.Connection.conn.Close();
                MessageBox.Show("Error --->" + ex.Message);
            }
        }

    }
}
