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
    public partial class AddClassesForm : Form
    {
        List<StudentsModel> studentList = GlobalConfig.Connection.GetAllStudents();
        List<SubjectModel> subjectList = GlobalConfig.Connection.GetAllSubjects();
        public AddClassesForm()
        {
            InitializeComponent();
            WireUpListst();
        }
        private void WireUpListst()
        {
            studentsListBox.DataSource = null;
            studentsListBox.DataSource = studentList;
            studentsListBox.DisplayMember = "FullName";

            subjectListBox.DataSource = null;
            subjectListBox.DataSource = subjectList;
            subjectListBox.DisplayMember = "Subject";
        }
        private void addStudentButton_Click(object sender, EventArgs e)
        {
            AddStudentForm studentForm = new AddStudentForm();
            studentForm.ShowDialog();
        }

        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            AddSubjectForm subjectForm = new AddSubjectForm();
            subjectForm.ShowDialog();
        }
    }
}
