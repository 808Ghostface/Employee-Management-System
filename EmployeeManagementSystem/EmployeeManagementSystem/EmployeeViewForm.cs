using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EmployeeManagementSystem
{
    public partial class EmployeeView : Form
    {
        public EmployeeView()
        {
            InitializeComponent();
        }
        BindingSource binder = new BindingSource(); //binds datagrid to the database


        DatabaseConnection objectCon;//variable that stores the connection object
        string conStr;// variable the stores connection strring from setting page
        DataSet dataS;// creating another dataset
        DataRow dataR;//creating a datarow variable

        int MaxRows; //variables
        int inc = 0;

        // creating strings so information can be passed to the next form
        public static string First = "";
        public static string Last = "";
        public static string Year = "";
        public static string ID = "";
        public static string workerComments = "";
        public static string Date = "";

        public void workerData()
        {
            workerComments = txtComment.Text;
            Date = dateTimePicker1.Text;
        }

        public void commentSave() //creating method
        {
            string query = "INSERT INTO ManagementInfo (Id, Date, Comment)";
            query += " VALUES (@Id, @Date, @Comment)"; //instantiating values into query

            string conString; //declaring connection string in this method
            conString = Properties.Settings.Default.EmployeeDBConnectionString;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);

            int EmployeeIDvalue = int.Parse(lblEmployeeID.Text);
            string comm = txtComment.Text;

            cmd.Parameters.Add(new SqlParameter("@Id", EmployeeIDvalue)); //asigning values to parameters within the table
            cmd.Parameters.Add(new SqlParameter("@Date", dateTimePicker1.Value));
            cmd.Parameters.Add(new SqlParameter("@Comment", comm));
            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Updated");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            con.Close();
        }


        private void btnView_Click(object sender, EventArgs e)
        {

            string conString;//creating variables

            conString = Properties.Settings.Default.EmployeeDBConnectionString; //setting up property and connection string

            SqlConnection con = new SqlConnection(conString);
            con.Open();//opening connection

            SqlCommand cmd = new SqlCommand("ViewID", con); //calls stored procedure

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);//filling table

            dataGridView1.DataSource = binder; //connecting datagridview to binder

            binder.DataSource = dataTable;

            con.Close();//closing connection


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployeeForm AddForm = new AddEmployeeForm(); //Declares form 2's existence
            AddForm.Show(); //Creates a function that shows form 2
            this.Hide(); //Creates a function that hides form 3
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            SignInForm SignForm = new SignInForm(); //Declares form 1's existence
            SignForm.Show(); //Creates a function that shows form 1
            this.Hide(); //Creates a function that hides form 3
        }

        private void Skip()//creating method
        {
            dataR = dataS.Tables[0].Rows[inc];// accessing one row at a time
            lblEmployeeID.Text = dataR.ItemArray.GetValue(0).ToString();// text on form to table rows
            txtFirstName.Text = dataR.ItemArray.GetValue(1).ToString();
            txtLastName.Text = dataR.ItemArray.GetValue(2).ToString();
            txtRole.Text = dataR.ItemArray.GetValue(3).ToString();
            txtAddress.Text = dataR.ItemArray.GetValue(4).ToString();
            txtPostcode.Text = dataR.ItemArray.GetValue(5).ToString();
            txtEmail.Text = dataR.ItemArray.GetValue(6).ToString();
        }
        private void EmployeeView_Load(object sender, EventArgs e)
        {
            try
            {
                objectCon = new DatabaseConnection();//creating an object
                conStr = Properties.Settings.Default.EmployeeDBConnectionString;// instatiating the connection 

                objectCon.connectionStrProp = conStr;//passing SQL to database connection
                objectCon.SQLprop = Properties.Settings.Default.SQL;

                dataS = objectCon.GetConnection;// calling GetConnection Method from form load
                MaxRows = dataS.Tables[0].Rows.Count;// counting rows in table
                Skip();

            }
            catch (Exception err) // if there is an error loading a message will pop up
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            workerData();
            commentSave();//calling method
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (inc != MaxRows - 1)
            {
                inc++;
                Skip();
                string conString;// declaring variables
                int employeeIDvalue = int.Parse(lblEmployeeID.Text);

                conString = Properties.Settings.Default.EmployeeDBConnectionString;// connection string

                SqlConnection con = new SqlConnection(conString);
                con.Open(); //opening connection

                SqlCommand cmd = new SqlCommand("GetWorkerByID", con);//calls stored procedure
                cmd.CommandType = CommandType.StoredProcedure;//declaring data type
                cmd.Parameters.Add(new SqlParameter("@GetWorkerID", employeeIDvalue));//initialising a new parameter

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);//filling table

                dataGridView1.DataSource = binder;//connecting datagridview to binder

                binder.DataSource = dataTable;//closing connection

                con.Close();
            }
            else
            {
                MessageBox.Show("No more profiles.", "Warning");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inc > 0)
            {
                inc--; // moves the table backwards by 1
                Skip(); //calls method
                string conString;
                int employeeIDvalue = int.Parse(lblEmployeeID.Text);

                conString = Properties.Settings.Default.EmployeeDBConnectionString;// connection string

                SqlConnection con = new SqlConnection(conString);
                con.Open();

                SqlCommand cmd = new SqlCommand("GetWorkerByID", con);//calls stored procedure
                cmd.CommandType = CommandType.StoredProcedure;//declaring data type
                cmd.Parameters.Add(new SqlParameter("@GetWorkerID", employeeIDvalue)); //initialising a new parameter

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);//filling table

                dataGridView1.DataSource = binder;//connecting datagridview to binder

                binder.DataSource = dataTable;

                con.Close();//closing connection
            }
            else
            {
                MessageBox.Show("No more profiles.", "Warning");
            }
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            string conString;// declaring variables
            int WorkerIDvalue = int.Parse(lblEmployeeID.Text);

            conString = Properties.Settings.Default.EmployeeDBConnectionString;// connection string

            SqlConnection con = new SqlConnection(conString);
            con.Open();//opening connection

            SqlCommand cmd = new SqlCommand("ComWorkandManage", con);//calls stored procedure
            cmd.CommandType = CommandType.StoredProcedure;//declaring data type
            cmd.Parameters.Add(new SqlParameter("@Combine", WorkerIDvalue));//initialising a new parameter

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable); //filling table

            dataGridView1.DataSource = binder;//connecting datagridview to binder

            binder.DataSource = dataTable;

            con.Close();//closing connection
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string NewCom; //creating variables
            string commDat;
            string comm;

            DataGridViewRow selectRow = dataGridView1.Rows[e.RowIndex]; //this gets the rows values in the data grid

            NewCom = selectRow.Cells[0].Value.ToString(); //accesses the cells in the row
            commDat = selectRow.Cells[3].Value.ToString();
            comm = selectRow.Cells[4].Value.ToString();

            lblEmployeeID.Text = NewCom; // linking variables to form data
            dateTimePicker1.Text = commDat;
            txtComment.Text = comm;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            int i;
            if (!int.TryParse(txtSearch.Text, out i))//if statement that checks whether the information is filled
            {

                MessageBox.Show("Only type numbers in the textbox please");

            }
            else
            {
                string conString;// declaring variables
                int employeeIDvalue = int.Parse(txtSearch.Text);

                conString = Properties.Settings.Default.EmployeeDBConnectionString;// connection string

                SqlConnection con = new SqlConnection(conString);
                con.Open();//opening connection

                SqlCommand cmd = new SqlCommand("GetWorkerByID", con);//calls stored procedure
                cmd.CommandType = CommandType.StoredProcedure;//declaring data type
                cmd.Parameters.Add(new SqlParameter("@GetWorkerID", employeeIDvalue));//initialising a new parameter

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dataGridView1.DataSource = binder;//connecting datagridview to binder

                binder.DataSource = dataTable;

                con.Close();//closing connection
                Skip();
            }
        }

        private void btnView_Click_1(object sender, EventArgs e)
        {
            string conString;//creating variables

            conString = Properties.Settings.Default.EmployeeDBConnectionString; //setting up property and connection string

            SqlConnection con = new SqlConnection(conString);
            con.Open();//opening connection

            SqlCommand cmd = new SqlCommand("ViewID", con); //calls stored procedure

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);//filling table

            dataGridView1.DataSource = binder; //connecting datagridview to binder

            binder.DataSource = dataTable;

            con.Close();//closing connection
        }
    }
}
