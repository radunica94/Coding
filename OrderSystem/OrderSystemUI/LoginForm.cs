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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            passwordLoginTextBox.PasswordChar = '*';
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm r = new RegisterForm();
            r.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void emailLoginTextBox_Click(object sender, EventArgs e)
        {
            emailLoginTextBox.Text = "";
        }

        private void passwordLoginTextBox_Click(object sender, EventArgs e)
        {
            passwordLoginTextBox.Text = "";
        }

        private void employeeLoginButton_Click(object sender, EventArgs e)
        {
            EmployeeLoginForm emp = new EmployeeLoginForm();
            emp.ShowDialog();
            this.Close();
        }

        private bool ValidateForm()
        {
            if(emailLoginTextBox.Text.Length == 0)
            {
                MessageBox.Show("Enter email! ");
                return false;
            }
            if (passwordLoginTextBox.Text.Length == 0)
            {
                MessageBox.Show("Enter password! ");
                return false;
            }
            return true;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                UsersModel u = new UsersModel();

                u.Email = emailLoginTextBox.Text;
                u.Password = passwordLoginTextBox.Text;

                SqlDataAcces.LoginUser(u);

                emailLoginTextBox.Text = "";
                passwordLoginTextBox.Text = "";


                ClientMainForm clientForm = new ClientMainForm();
                this.Hide();
                clientForm.ShowDialog();
                this.Close();
            }
        }
    }
}
