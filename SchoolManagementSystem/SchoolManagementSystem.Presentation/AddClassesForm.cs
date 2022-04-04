using SchoolManagementSystem.Business;
using SchoolManagementSystem.Business.Models;

namespace SchoolManagementSystem.Presentation
{
    public partial class AddClassesForm : Form
    {
        List<StudentsModel> availableStudents = GlobalConfig.Connection.GetAllStudents();
        List<StudentsModel> selectedStudents = new List<StudentsModel>();

        List<SubjectModel> availableSubjects = GlobalConfig.Connection.GetAllSubjects();
        List<SubjectModel> selectedSubjects = new List<SubjectModel>();
        

        public AddClassesForm()
        {
            InitializeComponent();


            WireUpList();
        }
       
        private void WireUpList()
        {
            studentsComboBox.DataSource = null;
            studentsComboBox.DataSource = availableStudents;
            studentsComboBox.DisplayMember = "FullName";

            studentsListBox.DataSource = null;
            studentsListBox.DataSource = selectedStudents;
            studentsListBox.DisplayMember = "FullName";

            subjectComboBox.DataSource = null;
            subjectComboBox.DataSource = availableSubjects;
            subjectComboBox.DisplayMember = "Subject";

            subjectListBox.DataSource = null;
            subjectListBox.DataSource = selectedSubjects;
            subjectListBox.DisplayMember = "Subject";

        }
        private void createStudentButton_Click(object sender, EventArgs e)
        {
            AddStudentForm studentForm = new AddStudentForm();
            studentForm.ShowDialog();
        }

        private void createSubjectButton_Click(object sender, EventArgs e)
        {
            AddSubjectForm subjectForm = new AddSubjectForm();
            subjectForm.ShowDialog();
        }
                
        private void addStudentButton_Click(object sender, EventArgs e)
        {
            StudentsModel std = (StudentsModel)studentsComboBox.SelectedItem;
            if(std != null)
            {
                availableStudents.Remove(std);
                selectedStudents.Add(std);

                WireUpList();
            }           
            
        }

        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            SubjectModel sbj =(SubjectModel)subjectComboBox.SelectedItem;
            if(sbj != null)
            {
                availableSubjects.Remove(sbj);
                selectedSubjects.Add(sbj);

                WireUpList();
            }           
            
        }

        private void removeStudentsButton_Click(object sender, EventArgs e)
        {
            StudentsModel std = (StudentsModel)studentsListBox.SelectedItem;
            if( std != null)
            {
                availableStudents.Add(std);
                selectedStudents.Remove(std);

                WireUpList();
            }                    
            
        }

        private void removeSubjectButton_Click(object sender, EventArgs e)
        {
            SubjectModel sbj = (SubjectModel)subjectListBox.SelectedItem;
            if( sbj != null)
            {
                availableSubjects.Add(sbj);
                selectedSubjects.Remove(sbj);

                WireUpList();

            }
        }

        private void createClassButton_Click(object sender, EventArgs e)
        {
            if(classNameTextBox.Text.Length > 0)
            {
                ClassesModel classes = new ClassesModel();
                classes.ClassName = classNameTextBox.Text;
                classes.Students = selectedStudents;
                classes.Subject = selectedSubjects;

                GlobalConfig.Connection.CreateClasses(classes);

                classNameTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void refreshGridButton_Click(object sender, EventArgs e)
        {
            WireUpStudentsList();
        }

        private void studentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            WireUpStudentsList();
        }

        private void WireUpStudentsList()
        {
            
            studentsDataGridView.DataSource = availableStudents;
          
        }
    }
}
