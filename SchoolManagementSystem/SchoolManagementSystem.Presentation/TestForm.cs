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
    public partial class TestForm : Form
    {
        
        public TestForm()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                TestModel test = new TestModel();
                test.Test = testTextBox.Text;
                test.Date = dateTimePicker1.Value;

                GlobalConfig.Connection.TestDB(test);
               

                testTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            if (testTextBox.Text.Length == 0)
            {
                output = false;
            }          

            return output;
        }
    }
}
