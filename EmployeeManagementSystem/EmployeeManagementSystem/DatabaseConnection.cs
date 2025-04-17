using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class DatabaseConnection
    {
        private string sqlStr; //creating variables
        private string ConnectionStr;

        public string SQLprop // creating a write-only property
        {
            set { sqlStr = value; } // assigning value to sql_string

        }
        public string connectionStrProp
        {
            set { ConnectionStr = value; } // assigning value to strCon

        }

        public System.Data.DataSet GetConnection //creating a read-only property
        {
            get { return DBDataSet(); } // connecting method to the database

        }
        private System.Data.DataSet DBDataSet() // making a method 
        {
            System.Data.SqlClient.SqlConnection connect = new System.Data.SqlClient.SqlConnection(ConnectionStr); // creating the variable 'con' of the SqlClient.SqlConnection type
            connect.Open(); // opening connection to database
            System.Data.SqlClient.SqlDataAdapter dataAdapt = new System.Data.SqlClient.SqlDataAdapter(sqlStr, connect); //creating a SqlClient.SqlDataAdapter 'da_1'. '(sql_string,con)' tells system what table to retrieve data from, the 'con' is the connection object.

            System.Data.DataSet dataSet = new System.Data.DataSet(); //creating 'dat_set' and returns DatatSet
            dataAdapt.Fill(dataSet, "EmployeeTable_Dat_1"); // filling the DataSet
            connect.Close(); //closing the connection

            return dataSet; //returns the 'dat_set'
        }
        public void UpdateDatabase(System.Data.DataSet ds)
        {
            System.Data.SqlClient.SqlConnection connect = new System.Data.SqlClient.SqlConnection(ConnectionStr);
            connect.Open();
            System.Data.SqlClient.SqlDataAdapter dataAdapt = new System.Data.SqlClient.SqlDataAdapter(sqlStr, connect);
            System.Data.SqlClient.SqlCommandBuilder cmdBD = new System.Data.SqlClient.SqlCommandBuilder(dataAdapt);
            cmdBD.DataAdapter.Update(ds.Tables[0]);
            connect.Close();
        }

    }
}
