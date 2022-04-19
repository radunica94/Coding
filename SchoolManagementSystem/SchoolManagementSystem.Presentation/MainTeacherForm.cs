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
    public partial class MainTeacherForm : Form
    {
        public MainTeacherForm()
        {
            InitializeComponent();
        }

        private void addClass_Click(object sender, EventArgs e)
        {
            AddClassForm addClass = new AddClassForm();
            addClass.Show();
        }

        private void addGradeButton_Click(object sender, EventArgs e)
        {
            AddGradeForm addGrade = new AddGradeForm();
            addGrade.Show();
        }

        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            AddSubjectForm addSubject = new AddSubjectForm();
            addSubject.Show();
        }
    }
}
