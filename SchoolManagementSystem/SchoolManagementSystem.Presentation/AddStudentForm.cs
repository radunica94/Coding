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
        List<StudentsModel> studentsGrid = GlobalConfig.Connection.GetAllStudents();
        public AddStudentForm()
        {
            InitializeComponent();

            WireUpStudentsList();
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

        private void addStudentsButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                StudentsModel students = new StudentsModel();
                students.FirstName = firstNameTextBox.Text;
                students.LastName = lastNameTextBox.Text;
                students.Email = emailTextBox.Text;
                students.Phone = phoneTextBox.Text;
                students.Grade = gradeTextBox.Text;
                students.Birthday = birthdayDateTimePicker.Value;

                if (maleRadioButton.Checked)
                {
                    students.Gender = "Male";
                }
                else if (femaleRadioButton.Checked)
                {
                    students.Gender = "Female";
                }
                
                GlobalConfig.Connection.AddStudents(students);
                WireUpStudentsList();
                
                

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

        private void WireUpStudentsList()
        {

            studentsDataGridView.DataSource = studentsGrid;
            this.studentsDataGridView.RefreshEdit();
        }

        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            List<StudentsModel> std = GlobalConfig.Connection.DeleteStudent();
           
        }

       
    }
}
