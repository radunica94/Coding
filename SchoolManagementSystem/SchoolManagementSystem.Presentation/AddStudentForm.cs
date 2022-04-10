using SchoolManagementSystem.Business;
using SchoolManagementSystem.Business.Models;

namespace SchoolManagementSystem.Presentation
{
    public partial class AddStudentForm : Form
    {
        List<StudentsModel> studentsList = GlobalConfig.Connection.GetAllStudents();
        StudentsModel students = new StudentsModel();

        public AddStudentForm()
        {
            InitializeComponent();

            // TODO - material skin manager            
        }

        private void addStudentsButton_Click(object sender, EventArgs e)
        {
            AddStudentEventForm stdEvent = new AddStudentEventForm();
            stdEvent.ShowDialog();
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
