﻿using System;
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
    public partial class MainAdminForm : Form
    {
        public MainAdminForm()
        {
            InitializeComponent();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            AddUsersForm addUser = new AddUsersForm();
            addUser.Show();
        }

        
    }
}
