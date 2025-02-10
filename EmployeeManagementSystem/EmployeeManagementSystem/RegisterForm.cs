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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Manager_btn_Click(object sender, EventArgs e)
        {
            ManagerRegisterForm ManagerForm = new ManagerRegisterForm(); 
            ManagerForm.Show();
            this.Hide(); 
        }

        private void Employee_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
