using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        DatabaseConnection objConnect;//variable that stores the connection object
        string conString;// variable the stores connection strring from setting page
        DataSet ds;// creating another dataset
        DataRow dRow;//creating a datarow variable

        int MaxRows; //variables
        int inc = 0;

        private void NavigateRecords()
        {
            dRow = ds.Tables[0].Rows[inc];
            txtID.Text = dRow.ItemArray.GetValue(0).ToString();
            txtFirstName.Text = dRow.ItemArray.GetValue(1).ToString();
            txtLastName.Text = dRow.ItemArray.GetValue(2).ToString();
            txtRole.Text = dRow.ItemArray.GetValue(3).ToString();
            txtAddress.Text = dRow.ItemArray.GetValue(4).ToString();
            txtPostcode.Text = dRow.ItemArray.GetValue(5).ToString();
            txtEmail.Text = dRow.ItemArray.GetValue(6).ToString();
        }

        private void btnDirect_Click(object sender, EventArgs e)
        {
            EmployeeView viewForm = new EmployeeView();
            viewForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnSavedit.Enabled = false;
            btnEdit.Enabled = true;
            btnAdd.Enabled = true;
            if (inc > 0)
            {
                inc--;
                NavigateRecords();
            }
            else
            {
                MessageBox.Show("No more profiles.", "Warning");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtID.Clear(); //clears textboxes for user
            txtFirstName.Clear();
            txtLastName.Clear();
            txtRole.Clear();
            txtAddress.Clear();
            txtPostcode.Clear();
            txtEmail.Clear();
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnCancel.Enabled = true;
            btnBack.Enabled = false;
            btnNext.Enabled = false;
            txtFirstName.ReadOnly = false;
            txtLastName.ReadOnly = false;
            txtRole.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtPostcode.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtID.ReadOnly = false;
            hireDate.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnSavedit.Enabled = false;
            btnEdit.Enabled = true;
            btnAdd.Enabled = true;

            if (inc != MaxRows - 1)
            {
                inc++;
                NavigateRecords();
            }
            else
            {
                MessageBox.Show("No more profiles.", "Warning");
            }
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            try
            {
                objConnect = new DatabaseConnection();//creating an object
                conString = Properties.Settings.Default.CompanyDatabaseConnectionString;// instatiating the connection

                objConnect.connection_string = conString;//passing SQL to database connection
                objConnect.Sql = Properties.Settings.Default.SQL;

                ds = objConnect.GetConnection;// calling GetConnection Method from form load
                MaxRows = ds.Tables[0].Rows.Count;// counting rows in table

                NavigateRecords();
            }
            catch (Exception err)// if there is an error loading a message will pop up
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow();
            row[1] = txtFirstName.Text; // creating array to record data in specific places in the table rows
            row[2] = txtLastName.Text;
            row[3] = txtRole.Text;
            row[4] = txtAddress.Text;
            row[5] = txtPostcode.Text;
            row[6] = txtEmail.Text;


            ds.Tables[0].Rows.Add(row);

            try //try...catch statement
            {
                objConnect.UpdateDatabase(ds); // accessing database connection
                MaxRows = MaxRows + 1; // adds new row to table
                inc = MaxRows - 1;

                MessageBox.Show("Database updated"); //message to signify it has worked
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error");
            }

            btnCancel.Enabled = false; // stops button from being accessed
            btnSave.Enabled = false;
            btnSavedit.Enabled = false;
            btnDelete.Enabled = true; // button to be accessed
            btnEdit.Enabled = true;
            btnBack.Enabled = true;
            btnNext.Enabled = true;
            btnAdd.Enabled = true;
            txtFirstName.ReadOnly = true;
            txtLastName.ReadOnly = true;
            txtRole.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtPostcode.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtID.ReadOnly = true;
        }

        private void btnSavedit_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnSavedit.Enabled = false;
            btnEdit.Enabled = true;
            btnAdd.Enabled = true;
            btnNext.Enabled = true;
            btnBack.Enabled = true;

            DataRow row = ds.Tables[0].Rows[inc];
            row[1] = txtFirstName.Text;
            row[2] = txtLastName.Text;
            row[3] = txtRole.Text;
            row[4] = txtAddress.Text;
            row[5] = txtPostcode.Text;
            row[6] = txtEmail.Text;

            try
            {

                objConnect.UpdateDatabase(ds); // calls method to update database

                MessageBox.Show("Record Updated");

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds.Tables[0].Rows[inc].Delete();//deletes rows fro dataset not database
                objConnect.UpdateDatabase(ds);// deletes row from database

                MaxRows = ds.Tables[0].Rows.Count;
                inc--;//deducts 1 from the inc variable
                NavigateRecords();// calls method
                MessageBox.Show("Record Deleted");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;// declares buttons usuable or unusable
            btnSave.Enabled = false;
            btnSavedit.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = false;
            btnBack.Enabled = false;
            btnNext.Enabled = false;
            btnAdd.Enabled = false;
            txtFirstName.ReadOnly = false;
            txtLastName.ReadOnly = false;
            txtRole.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtPostcode.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtID.ReadOnly = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NavigateRecords();

            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnSavedit.Enabled = false;
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnBack.Enabled = true;
            btnNext.Enabled = true;
            btnAdd.Enabled = true;
            txtFirstName.ReadOnly = true;
            txtLastName.ReadOnly = true;
            txtRole.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtPostcode.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtID.ReadOnly = true;
        }
    }
}
