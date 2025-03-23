using System;
using System.Data.OleDb;

namespace SysArchPrelim
{
    public class DBConnect
    {
        private OleDbConnection connection;

        public DBConnect()
        {
            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\user\\Documents\\SysArchMidterm\\SysArchPrelim\\SysArchPrelim\\Database.mdb");
            //C:\\Users\\user\\Documents\\SysArchMidterm\\SysArchPrelim\\SysArchPrelim\\Database.mdb - ZETH'S SOURCE PATH
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()//ASD
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public OleDbDataReader ExecuteQuery(string query)
        {
            OleDbCommand cmd = new OleDbCommand(query, connection);
            return cmd.ExecuteReader();
        }

        public int ExecuteNonQuery(string query)
        {
            OleDbCommand cmd = new OleDbCommand(query, connection);
            return cmd.ExecuteNonQuery();
        }
    }
}