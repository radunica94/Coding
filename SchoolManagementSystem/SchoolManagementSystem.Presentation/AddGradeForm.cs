using SchoolManagementSystem.Business;
using SchoolManagementSystem.Business.Models;

namespace SchoolManagementSystem.Presentation
{

    public partial class AddGradeForm : Form
    {
        List<StudentsModel> availableStudents = GlobalConfig.Connection.GetAllStudents();
        List<StudentsModel> selectedStudents = new List<StudentsModel>();
        List<SubjectModel> availableSubject = GlobalConfig.Connection.GetAllSubjects();
        List<SubjectModel> selectedSubject = new List<SubjectModel>();

        public AddGradeForm()
        {
            InitializeComponent();

            WireUpLists();
        }


        private void WireUpLists()
        {
            studentComboBox.DataSource = null;
            studentComboBox.DataSource = availableStudents;
            studentComboBox.DisplayMember = "FullName";

            studentListBox.DataSource = null;
            studentListBox.DataSource = selectedStudents;
            studentListBox.DisplayMember = "FullName";

            subjectComboBox.DataSource = null;
            subjectComboBox.DataSource = availableSubject;
            subjectComboBox.DisplayMember = "SubjectName";

            subjectListBox.DataSource = null;
            subjectListBox.DataSource = selectedSubject;
            subjectListBox.DisplayMember = "SubjectName";

        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            StudentsModel s = (StudentsModel)studentComboBox.SelectedItem;

            if (s != null)
            {
                availableStudents.Remove(s);
                selectedStudents.Add(s);

                WireUpLists();
            }
        }

        private void removeStudentButton_Click(object sender, EventArgs e)
        {
            StudentsModel s = (StudentsModel)studentListBox.SelectedItem;

            if (s != null)
            {
                selectedStudents.Remove(s);
                availableStudents.Add(s);

                WireUpLists();
            }
        }

        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            SubjectModel s = (SubjectModel)subjectComboBox.SelectedItem;
            if (s != null)
            {
                availableSubject.Remove(s);
                selectedSubject.Add(s);

                WireUpLists();
            }
        }

        private void removeSubjectButton_Click(object sender, EventArgs e)
        {
            SubjectModel s = (SubjectModel)subjectListBox.SelectedItem;
            if (s != null)
            {
                selectedSubject.Remove(s);
                availableSubject.Add(s);

                WireUpLists();
            }
        }

        private void addGradeButton_Click(object sender, EventArgs e)
        {
            GradeModel gm = new GradeModel();

            gm.Grade = Convert.ToInt32(gradeTxt.Text);
            gm.Students = selectedStudents;
            gm.Subjects = selectedSubject;

            GlobalConfig.Connection.AddGrade(gm);
        }
    }
}
