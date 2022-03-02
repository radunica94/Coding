using OrderLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderUI
{
    public partial class RegisterForm : Form
    {
        List<UserModel> users = new List<UserModel>();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();

            user.FirstName = firstNameTextBox.Text;
            user.LastName = lastNameTextBox.Text;
            user.Email = emailTextBox.Text;
            user.Password = passwordTextBox.Text;
            user.ConfirmPassword = confPasswordTextBox.Text;

            SqlConnector.RegisterUser(user);

            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            passwordTextBox.Text = "";
            confPasswordTextBox.Text = "";
        }
    }
}
