using Microsoft.Win32;
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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void Enter_btn_Click(object sender, EventArgs e)
        {
            string AdminUser = "MemriAdmin"; //This adds the admin's username to a string named AdminUser
            string AdminPass = "Pass";//This declares that the admin's password is Pass
                                      //(this is temporary and will be changed for security)
            
            string UserName = txtUser.Text; //This declares that username typed into the
                                            //"Username" textboxmust be the same as the
                                            //username stored in the code
           
            string PassWord = txtPass.Text; //This declares that the password typed into
                                            //the "Password" textbox is the same as the
                                            //password is the same as the password stored
                                            //in the code

            if (AdminUser == UserName && AdminPass == PassWord) //If the username and password typed into the respective textboxes match the coding an event will be triggered
            {
                EmployeeView employee = new EmployeeView(); //Declares the main form's existence
                employee.Show(); //Creates a function that shows the main form
                this.Hide(); //Creates a function that hides this form

            }
            else if (UserName == "" && PassWord == AdminPass)
            {
                userWarning.Visible = true;
                userWarning.Text = "Please enter a username";
            }
            else if (PassWord == "" && UserName == AdminUser)
            {
                passWarning.Visible = true;
                passWarning.Text = "Please enter a password";
            }
            else
            {
                MessageBox.Show("Your username or password is incorrect. Please try again."); // if the username/password is entered incorrectly, this messagebox will show
            }
        }
        private void passwordCB_CheckedChanged(object sender, EventArgs e)
        {
            if(passwordCB.Checked) 
            { 
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
}
