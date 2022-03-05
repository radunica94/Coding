using OrderSystemLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrderSystemUI
{
    public partial class RegisterForm : Form
    {
        List<UsersModel> user = new List<UsersModel>();
        public RegisterForm()
        {
            InitializeComponent();
            
        }
       

        private void registerButton_Click(object sender, EventArgs e)
        {
            UsersModel u = new UsersModel();

            u.FirstName = firstNameTextBox.Text;
            u.LastName = lastNameTextBox.Text;
            u.Email = emailTextBox.Text;
            u.Password = passwordTextBox.Text;
            u.ConfirmPassword = confirmPasswordTextBox.Text;

            SqlDataAcces.SaveUser(u);

            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            passwordTextBox.Text = "";
            confirmPasswordTextBox.Text = "";
        }
               
    }
}
