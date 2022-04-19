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
    public partial class AddClassForm : Form
    {       
        List<StudentsModel> availableStudents = GlobalConfig.Connection.GetAllStudents();
        List<StudentsModel> selectedStudents = new List<StudentsModel>();
        public AddClassForm()
        {
            InitializeComponent();
            
            WireUpLists();
        }

        private void WireUpLists()
        {           
            studentDropDown.DataSource = null;

            studentDropDown.DataSource = availableStudents;
            studentDropDown.DisplayMember = "FullName";

            studentListBox.DataSource = null;

            studentListBox.DataSource = selectedStudents;
            studentListBox.DisplayMember = "FullName";
        }
               
        

        private void addSubjectLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddSubjectForm addSubject = new AddSubjectForm();
            addSubject.ShowDialog();
        }

        private void createClassButton_Click(object sender, EventArgs e)
        {
            ClassModel c = new ClassModel();


            c.ClassName = classNameText.Text;
            c.ClassCapacity = Convert.ToInt32(classCapacityText.Text);
            c.StudentsList = selectedStudents;

            GlobalConfig.Connection.CreateClass(c);

            classNameText.Text = "";
            classCapacityText.Text = "";            
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            StudentsModel s = (StudentsModel)studentDropDown.SelectedItem;

            if (s != null)
            {
                availableStudents.Remove(s);
                selectedStudents.Add(s);

                WireUpLists();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            StudentsModel s = (StudentsModel)studentListBox.SelectedItem;

            if (s != null)
            {
                selectedStudents.Remove(s);
                availableStudents.Add(s);

                WireUpLists();
            }
        }
    }
}
