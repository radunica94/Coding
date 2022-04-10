using SchoolManagementSystem.Business;
using SchoolManagementSystem.Business.Models;

namespace SchoolManagementSystem.Presentation
{
    public partial class LoginForm : Form
    {
        private List<UsersModel> getAdmin = GlobalConfig.Connection.LoginAsAdmin();
        private List<UsersModel> getTeacher = GlobalConfig.Connection.LoginAsTeacher();
        private List<UsersModel> getStudent = GlobalConfig.Connection.LoginAsStudent();
        private UsersModel user = new UsersModel();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (getAdmin.Any(x => x.UserName == loginUsernameTxt.Text && x.Password == loginPasswordTxt.Text))
            {
                user = getAdmin.FirstOrDefault(x => x.UserName == loginUsernameTxt.Text && x.Password == loginPasswordTxt.Text);
                this.Hide();
                MainAdminForm mainAdm = new MainAdminForm();
                mainAdm.Show();
            }
            else if (getTeacher.Any(x => x.UserName == loginUsernameTxt.Text && x.Password == loginPasswordTxt.Text))
            {
                user = getTeacher.FirstOrDefault(x => x.UserName == loginUsernameTxt.Text && x.Password == loginPasswordTxt.Text);
                this.Hide();
                MainTeacherForm mainTeacher = new MainTeacherForm();
                mainTeacher.Show();
            }
            else if (getStudent.Any(x => x.UserName == loginUsernameTxt.Text && x.Password == loginPasswordTxt.Text))
            {
                user = getStudent.FirstOrDefault(x => x.UserName == loginUsernameTxt.Text && x.Password == loginPasswordTxt.Text);
                this.Hide();
                MainStudentForm mainStudent = new MainStudentForm();
                mainStudent.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
