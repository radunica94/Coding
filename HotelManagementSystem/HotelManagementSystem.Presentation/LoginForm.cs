using HotelManagementSystem.Business;
using HotelManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.Presentation
{
    public partial class LoginForm : Form
    {
        public UserOperations userOp = new UserOperations();
        public UserModel users = new UserModel();
        public string userType;

        DataTable dt = new DataTable();
        public LoginForm()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';           
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                users.username = usernameTextBox.Text;
                users.password = passwordTextBox.Text;

                dt = userOp.Login(users);

                userType = dt.Rows[0][6].ToString();
                if (userType == "admin")
                {
                    this.Hide();
                    AdminMainForm admin = new AdminMainForm();
                    admin.Show();
                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";

                }
                else if (userType == "employee")
                {
                    this.Hide();
                    EmployeeMainForm employee = new EmployeeMainForm();
                    employee.Show();
                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";

                }
                else
                {
                    MessageBox.Show("invalid username or password!");
                }
            }
            else
            {
                MessageBox.Show("You need to fill in all the fields! ");
            }
            
        }
       
        

        private bool ValidateForm()
        {
            if (usernameTextBox.Text.Length == 0)
            {                
                return false;
            }
            if (passwordTextBox.Text.Length == 0)
            {               
                return false;
            }
            return true;
        }
    }
}
