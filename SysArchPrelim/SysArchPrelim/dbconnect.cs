﻿using System;
using System.Data.OleDb;

namespace SysArchPrelim
{
    public class DBConnect//AHIHI
    {
        private OleDbConnection connection;

<<<<<<< HEAD
        public DBConnect()//test
=======
        public DBConnect()//QWE
>>>>>>> origin/feature
        {
            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\user\\Documents\\SysArchMidterm\\SysArchPrelim\\SysArchPrelim\\Database.mdb");
            //C:\Users\john2\Documents\GitHub\SysArchMidterm\SysArchPrelim - SYDNEY'S SOURCE PATH
            //C:\\Users\\user\\Documents\\SysArchMidterm\\SysArchPrelim\\SysArchPrelim\\ - ZETH'S SOURCE PATH
        }

        public void OpenConnection()//AHOHO
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
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