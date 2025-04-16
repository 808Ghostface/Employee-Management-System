using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
        BindingSource binder = new BindingSource(); //binds datagridview to connection

        DatabaseConnection objConnect; //variable that stores the connection object
        string conString; // variable the stores connection strring from setting page
        DataSet ds; // creating another dataset
        DataRow dRow; //creating a datarow variable

        int MaxRows; //variables
        int inc = 0;

        private void NavigateRecords() //creating method
        {
            dRow = ds.Tables[0].Rows[inc]; // accessing one row at a time

            lblEmployeeID.Text = dRow.ItemArray.GetValue(0).ToString(); // text on form to table rows
            txtFirstName.Text = dRow.ItemArray.GetValue(1).ToString();
            txtLastName.Text = dRow.ItemArray.GetValue(2).ToString();
            txtRole.Text = dRow.ItemArray.GetValue(3).ToString();
            txtAddress.Text = dRow.ItemArray.GetValue(4).ToString();
            txtPostcode.Text = dRow.ItemArray.GetValue(5).ToString();
            txtEmail.Text = dRow.ItemArray.GetValue(6).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Adding addingForm = new Adding(); //Declares form 1's existence
            addingForm.Show(); //Creates a function that shows form 1
            this.Hide(); //Creates a function that hides form 2
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SignInForm signIn = new SignInForm(); //Declares form 1's existence
            signIn.Show(); //Creates a function that shows form 1
            this.Hide(); //Creates a function that hides form 2
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (inc != MaxRows - 1) // advancing table rows by 1
            {
                inc++;
                NavigateRecords();//calls method
                string conString;// declaring variables
                int studentIDvalue = int.Parse(lblEmployeeID.Text);

                conString = Properties.Settings.Default.CompanyDatabaseConnectionString;// connection string

                SqlConnection con = new SqlConnection(conString);
                con.Open();//opening connection

                SqlCommand cmd = new SqlCommand("Combine", con);//calls stored procedure
                cmd.CommandType = CommandType.StoredProcedure;//declaring data type
                cmd.Parameters.Add(new SqlParameter("combi", studentIDvalue));//initialising a new parameter

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable); //filling table

                dataGridView1.DataSource = binder;//connecting datagridview to binder

                binder.DataSource = dataTable;

                con.Close();//closing connection
            }
            else
            {
                MessageBox.Show("No more profiles.", "Warning"); // shows a warning if the table has run out of rows
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
