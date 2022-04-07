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
        List<StudentsModel> studentsList = GlobalConfig.Connection.GetAllStudents();
        StudentsModel students = new StudentsModel();

        int indexRow;
        public AddStudentForm()
        {
            InitializeComponent();

            // TODO - material skin manager

            
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
           

        }       
       


        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in studentsListView.Items)
            {
                if (item.Selected)
                {
                    studentsListView.Items.Remove(item);
                    GlobalConfig.Connection.DeleteStudent(students);
                }
               
            }
        }

        private void studentsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //indexRow = e.RowIndex;
            //DataGridViewRow row = studentsDataGridView.Rows[indexRow];

            //students.Id = Convert.ToInt32(row.Cells[0].Value);
            //firstNameTextBox.Text = row.Cells[1].Value.ToString();
            //lastNameTextBox.Text = row.Cells[2].Value.ToString();
            //emailTextBox.Text = row.Cells[3].Value.ToString();
            //phoneTextBox.Text = row.Cells[4].Value.ToString();
            //gradeTextBox.Text = row.Cells[5].Value.ToString();
            //birthdayDateTimePicker.Value = Convert.ToDateTime(row.Cells[6].Value);
            //if (row.Cells[7].Value.ToString() == "Male")
            //{
            //    maleRadioButton.Checked = true;
            //}
            //else if (row.Cells[7].Value.ToString() == "Female")
            //{
            //    femaleRadioButton.Checked = true;
            //}



        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //StudentsModel std = new StudentsModel();
            //DataGridViewRow newDatRow = studentsDataGridView.Rows[indexRow];
            //newDatRow.Cells[0].Value = students.Id;
            //newDatRow.Cells[1].Value = firstNameTextBox.Text;
            //newDatRow.Cells[2].Value = lastNameTextBox.Text;
            //newDatRow.Cells[3].Value = emailTextBox.Text;
            //newDatRow.Cells[4].Value = phoneTextBox.Text;
            //newDatRow.Cells[5].Value = gradeTextBox.Text;
            //newDatRow.Cells[6].Value = birthdayDateTimePicker.Value;
            //if (maleRadioButton.Checked)
            //{
            //    newDatRow.Cells[7].Value = "Male";
            //}             
            //else if(femaleRadioButton.Checked)
            //{
            //    newDatRow.Cells[7].Value = "Female";        
            //}



            //GlobalConfig.Connection.UpdateStudents(students);
            //WireUpStudentsList();

        }

        private void studentsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        

        private void addStudentsButton_Click(object sender, EventArgs e)
        {
            AddStudentEventForm stdEvent = new AddStudentEventForm();
            stdEvent.ShowDialog();
        }

        private void studentsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }

       

        private void loadButton_Click(object sender, EventArgs e)
        {
            List<StudentsModel> students = GlobalConfig.Connection.GetAllStudents();
            studentsListView.Items.Clear();
            foreach (StudentsModel std in students)
            {
                ListViewItem item = new ListViewItem(std.Id.ToString());
                item.SubItems.Add(std.FirstName);
                item.SubItems.Add(std.LastName);
                item.SubItems.Add(std.Email);
                item.SubItems.Add(std.Phone);
                item.SubItems.Add(std.Grade);
                item.SubItems.Add(std.Birthday.ToShortDateString());
                item.SubItems.Add(std.Gender);

                studentsListView.Items.Add(item);
            }            
                
        }
    } 
}
