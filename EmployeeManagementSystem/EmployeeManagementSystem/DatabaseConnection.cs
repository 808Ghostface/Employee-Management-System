using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class DatabaseConnection
    {
        private string sql_string; //creating variables
        private string strCon;

        public string Sql // creating a write-only property
        {
            set { sql_string = value; } // assigning value to sql_string

        }
        public string connection_string
        {
            set { strCon = value; } // assigning value to strCon

        }

        public System.Data.DataSet GetConnection //creating a read-only property
        {
            get { return MyDataSet(); } // connecting method to the database

        }
        private System.Data.DataSet MyDataSet() // making a method 
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(strCon); // creating the variable 'con' of the SqlClient.SqlConnection type
            con.Open(); // opening connection to database
            System.Data.SqlClient.SqlDataAdapter da_1 = new System.Data.SqlClient.SqlDataAdapter(sql_string, con); //creating a SqlClient.SqlDataAdapter 'da_1'. '(sql_string,con)' tells system what table to retrieve data from, the 'con' is the connection object.

            System.Data.DataSet dat_set = new System.Data.DataSet(); //creating 'dat_set' and returns DatatSet
            da_1.Fill(dat_set, "EmployeeTable.Data_1"); // filling the DataSet
            con.Close(); //closing the connection

            return dat_set; //returns the 'dat_set'
        }
        public void UpdateDatabase(System.Data.DataSet ds)
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(strCon);
            con.Open();
            System.Data.SqlClient.SqlDataAdapter da_1 = new System.Data.SqlClient.SqlDataAdapter(sql_string, con);
            System.Data.SqlClient.SqlCommandBuilder cb = new System.Data.SqlClient.SqlCommandBuilder(da_1);
            cb.DataAdapter.Update(ds.Tables[0]);
            con.Close();
        }

    }
}
