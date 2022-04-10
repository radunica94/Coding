using SchoolManagementSystem.Business;
using SchoolManagementSystem.Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.Presentation
{
    public partial class AddUsersForm : Form
    {
        public AddUsersForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                UsersModel u = new UsersModel();
                u.UserName = usernameText.Text;
                u.Password = passwordText.Text;
                u.FirstName = firstnameText.Text;
                u.LastName = lastnameText.Text;
                u.Email = emailText.Text;
                u.Phone = phoneText.Text;
                u.Street = streetText.Text;
                u.Apartment = apartmentText.Text;
                u.City = cityText.Text;
                u.Country = countryText.Text;
                u.ZipCode = zipcodeText.Text;
                u.Birthday = birthdayDateTimePicker.Value;
                if (adminRadioButton.Checked)
                {
                    u.Role = "Admin";
                }
                else if(teacherRadioButton.Checked)
                {
                    u.Role = "Teacher";
                }
                else
                {
                    u.Role = "Student";
                }

                GlobalConfig.Connection.AddUsers(u);

                usernameText.Text = "";
                passwordText.Text = "";
                firstnameText.Text = "";
                lastnameText.Text = "";
                emailText.Text = "";
                phoneText.Text = "";
                streetText.Text = "";
                apartmentText.Text = "";
                cityText.Text = "";
                countryText.Text = "";
                zipcodeText.Text = "";
                birthdayDateTimePicker.CustomFormat = " ";
                adminRadioButton.Checked = false;
                teacherRadioButton.Checked = false;
                studentRadioButton.Checked = false;
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            if((usernameText.Text.Length == 0) || (passwordText.Text.Length == 0) || (firstnameText.Text.Length == 0) || (lastnameText.Text.Length == 0) ||
                (emailText.Text.Length == 0) || (phoneText.Text.Length == 0) || (streetText.Text.Length == 0) || (apartmentText.Text.Length == 0) || 
                (cityText.Text.Length == 0) || (countryText.Text.Length == 0) || (zipcodeText.Text.Length == 0))
            {
                output = false;
            }
            return true;
        }
    }
}
