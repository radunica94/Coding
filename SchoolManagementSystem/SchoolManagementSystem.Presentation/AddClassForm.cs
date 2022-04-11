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
        public AddClassForm()
        {
            InitializeComponent();
        }

        private void addSubjectLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddSubjectForm addSubject = new AddSubjectForm();
            addSubject.ShowDialog();
        }
    }
}
