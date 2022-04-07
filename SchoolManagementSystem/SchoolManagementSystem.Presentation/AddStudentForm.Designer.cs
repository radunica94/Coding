namespace SchoolManagementSystem.Presentation
{
    partial class AddStudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addStudentsButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.studentsListView = new System.Windows.Forms.ListView();
            this.FirstName = new System.Windows.Forms.ColumnHeader();
            this.LastName = new System.Windows.Forms.ColumnHeader();
            this.Email = new System.Windows.Forms.ColumnHeader();
            this.Phone = new System.Windows.Forms.ColumnHeader();
            this.Grade = new System.Windows.Forms.ColumnHeader();
            this.Birthday = new System.Windows.Forms.ColumnHeader();
            this.Gender = new System.Windows.Forms.ColumnHeader();
            this.loadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addStudentsButton
            // 
            this.addStudentsButton.Location = new System.Drawing.Point(649, 577);
            this.addStudentsButton.Name = "addStudentsButton";
            this.addStudentsButton.Size = new System.Drawing.Size(103, 53);
            this.addStudentsButton.TabIndex = 6;
            this.addStudentsButton.Text = "Add";
            this.addStudentsButton.UseVisualStyleBackColor = true;
            this.addStudentsButton.Click += new System.EventHandler(this.addStudentsButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(933, 577);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(103, 53);
            this.removeButton.TabIndex = 17;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(784, 577);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(103, 53);
            this.updateButton.TabIndex = 18;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // studentsListView
            // 
            this.studentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstName,
            this.LastName,
            this.Email,
            this.Phone,
            this.Grade,
            this.Birthday,
            this.Gender});
            this.studentsListView.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentsListView.FullRowSelect = true;
            this.studentsListView.GridLines = true;
            this.studentsListView.Location = new System.Drawing.Point(12, 34);
            this.studentsListView.Name = "studentsListView";
            this.studentsListView.Size = new System.Drawing.Size(1406, 502);
            this.studentsListView.TabIndex = 19;
            this.studentsListView.UseCompatibleStateImageBehavior = false;
            this.studentsListView.View = System.Windows.Forms.View.Details;
            // 
            // FirstName
            // 
            this.FirstName.Text = "FirstName";
            this.FirstName.Width = 200;
            // 
            // LastName
            // 
            this.LastName.Text = "LastName";
            this.LastName.Width = 200;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 200;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            this.Phone.Width = 200;
            // 
            // Grade
            // 
            this.Grade.Text = "Grade";
            this.Grade.Width = 200;
            // 
            // Birthday
            // 
            this.Birthday.Text = "Birthday";
            this.Birthday.Width = 200;
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            this.Gender.Width = 200;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(12, 542);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(112, 45);
            this.loadButton.TabIndex = 20;
            this.loadButton.Text = "Display";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1723, 754);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.studentsListView);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addStudentsButton);
            this.Name = "AddStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudentForm";
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button addStudentsButton;
        private Button removeButton;
        private Button updateButton;
        private ListView studentsListView;
        private ColumnHeader FirstName;
        private ColumnHeader LastName;
        private ColumnHeader Email;
        private ColumnHeader Phone;
        private ColumnHeader Grade;
        private ColumnHeader Birthday;
        private ColumnHeader Gender;
        private Button loadButton;
    }
}