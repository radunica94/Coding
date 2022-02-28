using OrdersLibrary;
using OrdersLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdersUI
{
    public partial class RegisterForm : Form
    {
        private List<RoleModel> userType = new List<RoleModel>();
        public RegisterForm()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
            confirmPasswordTextBox.PasswordChar = '*';

            LoadUserTypeClient();
        }
        private void LoadUserTypeClient()
        {
            userType = SqlDataAcces.GetUserTypeClient();

            WireUpLists();
        }
        
        private void WireUpLists()
        {
            userTypeComboBox.DataSource = null;
            userTypeComboBox.DataSource = userType;
            userTypeComboBox.DisplayMember = "Role";
            
        }

        private bool ValidateForm()
        {
            if(firstNameTextBox.Text.Length == 0)
            {
                return false;
            }
            if(lastNameTextBox.Text.Length == 0)
            {
                return false;
            }

            if(emailTextBox.Text.Length == 0)
            {
                return false;
            }
            if(passwordTextBox.Text.Length == 0)
            {
                return false;
            }
            if(confirmPasswordTextBox.Text.Length == 0)
            {
                return false;
            }            
            return true;
        }
        private void ValidatePassword()
        {
            
        }       
    }
}
