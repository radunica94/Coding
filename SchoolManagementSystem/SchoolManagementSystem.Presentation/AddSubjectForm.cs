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
        public AddSubjectForm()
        {
            InitializeComponent();
        }

        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SubjectModel subjectModel = new SubjectModel();
                subjectModel.Professor = professorTextBox.Text;
                subjectModel.Subject = subjectTextBox.Text;

                GlobalConfig.Connection.AddSubject(subjectModel);

                professorTextBox.Text = "";
                subjectTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            if(professorTextBox.Text.Length == 0)
            {
                output = false;
            }
            if(subjectTextBox.Text.Length == 0)
            {
                output = false;
            }
            return output;
        }
    }
}
