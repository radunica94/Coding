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
    public partial class AddSubjectForm : Form
    {
        private List<UsersModel> availableTeachers = GlobalConfig.Connection.LoginAsTeacher();
        private List<UsersModel> selectedTeachers = new List<UsersModel>();
        
        public AddSubjectForm()
        {
            InitializeComponent();

                        
            WireUpLists();
        }
                

        private void WireUpLists()
        {
            teacherDropDown.DataSource = null;
            
            teacherDropDown.DataSource = availableTeachers;
            teacherDropDown.DisplayMember = "FullName";

            teacherListBox.DataSource = null;
            
            teacherListBox.DataSource = selectedTeachers;
            teacherListBox.DisplayMember = "FullName";
        }

        private bool ValidateForm()
        {
            bool value = true;
            if (subjectNameText.Text.Length == 0)
            {
                value = false;
            }
            if (yearText.Text.Length == 0)
            {
                value = false;
            }
            if (semesterText.Text.Length == 0)
            {
                value = false;
            }
            return value;
        }

        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            UsersModel u = (UsersModel)teacherDropDown.SelectedItem;

            if (u != null)
            {
                availableTeachers.Remove(u);
                selectedTeachers.Add(u);

                WireUpLists();
            }
        }

        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm()){
                SubjectModel s = new SubjectModel();

                s.SubjectName = subjectNameText.Text;
                s.Year = int.Parse(yearText.Text);
                s.Semester = int.Parse(semesterText.Text);
                s.Teachers = selectedTeachers;

                GlobalConfig.Connection.CreateSubject(s);

                subjectNameText.Text = "";
                yearText.Text = "";
                semesterText.Text = "";
            }
            else
            {
                MessageBox.Show("Please fill in all the fields");
            }
            
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            UsersModel u = (UsersModel)teacherListBox.SelectedItem;

            if (u != null)
            {
                selectedTeachers.Remove(u);
                availableTeachers.Add(u);

                WireUpLists();
            }
        }
    }
}
