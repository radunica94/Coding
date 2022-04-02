using iTextSharp.text;
using iTextSharp.text.pdf;
using SchoolManagementSystem.Business;
using SchoolManagementSystem.Business.Models;
using SchoolManagementSystem.Business.Models.TestModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.Presentation
{
    public partial class TestForm : Form
    {
        List<TestModel> models = GlobalConfig.Connection.GetTest();
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
                //test.Picture = pictureBox1.Image;

                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
                test.Picture = ms.ToArray();

                GlobalConfig.Connection.TestDB(test);

                WireUpList();

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
            if(textBox1.Text.Length == 0)
            {
                output=false;
            }

            return output;
        }

        private void imgButton_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = openFileDialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WireUpList()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = models;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            WireUpList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WireUpList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                TestModel2 test2 = new TestModel2();
                test2.Name = textBox1.Text;

                GlobalConfig.Connection.Test2DB(test2);

                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("error");
            }
        }
        
    }
}
