using OrderSystemLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
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
            if (ValidateForm())
            {
                UsersModel u = new UsersModel();

                u.FirstName = firstNameTextBox.Text;
                u.LastName = lastNameTextBox.Text;
                u.Email = emailTextBox.Text;
                u.Password = passwordTextBox.Text;
                u.ConfirmPassword = confirmPasswordTextBox.Text;

                if(SqlDataAcces.CheckEmail(u))
                {
                    MessageBox.Show("Email exists");

                }
                else
                {
                    if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                    {
                        MessageBox.Show("The password confirmation does not match");

                    }
                    else
                    {
                        SqlDataAcces.SaveUser(u);

                        firstNameTextBox.Text = "";
                        lastNameTextBox.Text = "";
                        emailTextBox.Text = "";
                        passwordTextBox.Text = "";
                        confirmPasswordTextBox.Text = "";
                    }
                }                                 
            }            
        }

        private void firstNameTextBox_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = "";
        }

        private void lastNameTextBox_Click(object sender, EventArgs e)
        {
            lastNameTextBox.Text = "";
        }

        private void emailTextBox_Click(object sender, EventArgs e)
        {
            emailTextBox.Text = "";
        }

        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = "";
        }

        private void confirmPasswordTextBox_Click(object sender, EventArgs e)
        {
            confirmPasswordTextBox.Text = "";
        }

        private bool ValidateForm()
        {
            if (firstNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Enter a first name! ");
                return false;
            }
            if (lastNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Enter a last name! ");
                return false;
            }
            if (emailTextBox.Text.Length == 0)
            {
                MessageBox.Show("Enter email! ");
                return false;
            }
            if (passwordTextBox.Text.Length == 0)
            {
                MessageBox.Show("Enter password! ");
                return false;
            }
            if (confirmPasswordTextBox.Text.Length == 0)
            {
                MessageBox.Show("Enter confirm password! ");
                return false;
            }
            return true;
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            string pattern = @"^(([A-Za-z0-9]+_+)|([A-Za-z0-9]+\-+)|([A-Za-z0-9]+\.+)|([A-Za-z0-9]+\++))*[A-Za-z0-9_]+@((\w+\-+)|(\w+\.))*\w{1,63}\.[a-zA-Z]{2,6}$"; ;
            if (Regex.IsMatch(emailTextBox.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.emailTextBox, "Provide a valid Email address");
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
