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
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            users.username = usernameTextBox.Text;
            users.password = passwordTextBox.Text;

            dt = userOp.Login(users);

            userType = dt.Rows[0][7].ToString();
            if (userType == "admin")
            {
                this.Hide();
                AdminMainForm admin = new AdminMainForm();
                admin.Show();
            }
            //employee form
            else
            {
                MessageBox.Show("invalid username or password!");
            }
            
        }
    }
}
