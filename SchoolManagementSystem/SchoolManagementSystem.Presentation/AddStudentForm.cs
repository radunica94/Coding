using SchoolManagementSystem.Business;
using SchoolManagementSystem.Business.Models;
using SchoolManagementSystem.Business.DataAccess;
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
    public partial class AddStudentForm : Form
    {        
        public AddStudentForm()
        {
            InitializeComponent();
        }
        //TODO - create the add Student form and test if it works

        private bool ValidateForm()
        {
            bool output = true;
            if (firstNameTextBox.Text.Length == 0) 
            {
                output = false;
            }
            if (lastNameTextBox.Text.Length == 0)
            {
                output = false;
            }
            if (emailTextBox.Text.Length == 0)
            {
                output = false;
            }
            if (phoneTextBox.Text.Length == 0)
            {
                output = false;
            }
            if (gradeTextBox.Text.Length == 0)
            {
                output = false;
            }

            return output;
        }

        private void c(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                StudentsModel students = new StudentsModel();
                students.firstName = firstNameTextBox.Text;
                students.lastName = lastNameTextBox.Text;
                students.email = emailTextBox.Text;
                students.phone = phoneTextBox.Text;
                students.grade = gradeTextBox.Text;
                students.birthday = birthdayDateTimePicker.Value;
                
                students = GlobalConfig.Connections.AddStudents(students);

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                emailTextBox.Text = "";
                phoneTextBox.Text = "";
                gradeTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all the fields! ");
            }
        }
    }
}
