using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnitTestExercises;
using UnitTestExercises.Models;

namespace WinFormUI
{
    public partial class Dashboard : Form
    {
        List<PersonModel> people;
        ICalculator _calc;
        public Dashboard()
        {
            InitializeComponent();

            RebindDropdown();
        }

        private void RebindDropdown()
        {
            people = DataAccess.GetAllPeople();
            usersDropdown.DataSource = null;
            usersDropdown.DataSource = people;
            usersDropdown.DisplayMember = "FullName";
            _calc = new Calculator();
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            DataAccess.AddNewPerson(new PersonModel { FirstName = firstNameText.Text, LastName = lastNameText.Text });

            firstNameText.Text = "";
            lastNameText.Text = "";

            RebindDropdown();
        }

        public void addButton_Click(object sender, EventArgs e)
        {
            resultsText.Text = _calc.Add((double)firstNumberValue.Value, (double)secondNumberValue.Value).ToString();
            firstNumberValue.Value = 0;
            secondNumberValue.Value = 0;
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            resultsText.Text = _calc.Subtract((double)firstNumberValue.Value, (double)secondNumberValue.Value).ToString();
            firstNumberValue.Value = 0;
            secondNumberValue.Value = 0;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            resultsText.Text = _calc.Multiply((double)firstNumberValue.Value, (double)secondNumberValue.Value).ToString();
            firstNumberValue.Value = 0;
            secondNumberValue.Value = 0;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            resultsText.Text = _calc.Divide((double)firstNumberValue.Value, (double)secondNumberValue.Value).ToString();
            firstNumberValue.Value = 0;
            secondNumberValue.Value = 0;
        }
    }
}