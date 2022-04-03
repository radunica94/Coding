namespace SchoolManagementSystem.Presentation
{
    partial class AddClassesForm
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
            this.createStudentButton = new System.Windows.Forms.Button();
            this.createSubjectButton = new System.Windows.Forms.Button();
            this.studentsListBox = new System.Windows.Forms.ListBox();
            this.subjectListBox = new System.Windows.Forms.ListBox();
            this.createClassButton = new System.Windows.Forms.Button();
            this.studentsComboBox = new System.Windows.Forms.ComboBox();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.removeStudentsButton = new System.Windows.Forms.Button();
            this.removeSubjectButton = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.addSubjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createStudentButton
            // 
            this.createStudentButton.Location = new System.Drawing.Point(12, 130);
            this.createStudentButton.Name = "createStudentButton";
            this.createStudentButton.Size = new System.Drawing.Size(154, 34);
            this.createStudentButton.TabIndex = 0;
            this.createStudentButton.Text = "Create Student";
            this.createStudentButton.UseVisualStyleBackColor = true;
            this.createStudentButton.Click += new System.EventHandler(this.createStudentButton_Click);
            // 
            // createSubjectButton
            // 
            this.createSubjectButton.Location = new System.Drawing.Point(12, 264);
            this.createSubjectButton.Name = "createSubjectButton";
            this.createSubjectButton.Size = new System.Drawing.Size(154, 34);
            this.createSubjectButton.TabIndex = 1;
            this.createSubjectButton.Text = "Create Subject";
            this.createSubjectButton.UseVisualStyleBackColor = true;
            this.createSubjectButton.Click += new System.EventHandler(this.createSubjectButton_Click);
            // 
            // studentsListBox
            // 
            this.studentsListBox.FormattingEnabled = true;
            this.studentsListBox.ItemHeight = 25;
            this.studentsListBox.Location = new System.Drawing.Point(328, 24);
            this.studentsListBox.Name = "studentsListBox";
            this.studentsListBox.Size = new System.Drawing.Size(500, 429);
            this.studentsListBox.TabIndex = 2;
            // 
            // subjectListBox
            // 
            this.subjectListBox.FormattingEnabled = true;
            this.subjectListBox.ItemHeight = 25;
            this.subjectListBox.Location = new System.Drawing.Point(834, 24);
            this.subjectListBox.Name = "subjectListBox";
            this.subjectListBox.Size = new System.Drawing.Size(500, 429);
            this.subjectListBox.TabIndex = 3;
            // 
            // createClassButton
            // 
            this.createClassButton.Location = new System.Drawing.Point(12, 388);
            this.createClassButton.Name = "createClassButton";
            this.createClassButton.Size = new System.Drawing.Size(170, 34);
            this.createClassButton.TabIndex = 4;
            this.createClassButton.Text = "Create Class";
            this.createClassButton.UseVisualStyleBackColor = true;
            this.createClassButton.Click += new System.EventHandler(this.createClassButton_Click);
            // 
            // studentsComboBox
            // 
            this.studentsComboBox.FormattingEnabled = true;
            this.studentsComboBox.Location = new System.Drawing.Point(12, 91);
            this.studentsComboBox.Name = "studentsComboBox";
            this.studentsComboBox.Size = new System.Drawing.Size(310, 33);
            this.studentsComboBox.TabIndex = 5;
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(12, 215);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(310, 33);
            this.subjectComboBox.TabIndex = 6;
            // 
            // removeStudentsButton
            // 
            this.removeStudentsButton.Location = new System.Drawing.Point(654, 459);
            this.removeStudentsButton.Name = "removeStudentsButton";
            this.removeStudentsButton.Size = new System.Drawing.Size(174, 34);
            this.removeStudentsButton.TabIndex = 7;
            this.removeStudentsButton.Text = "Remove Students";
            this.removeStudentsButton.UseVisualStyleBackColor = true;
            this.removeStudentsButton.Click += new System.EventHandler(this.removeStudentsButton_Click);
            // 
            // removeSubjectButton
            // 
            this.removeSubjectButton.Location = new System.Drawing.Point(1162, 459);
            this.removeSubjectButton.Name = "removeSubjectButton";
            this.removeSubjectButton.Size = new System.Drawing.Size(172, 34);
            this.removeSubjectButton.TabIndex = 8;
            this.removeSubjectButton.Text = "Remove Subject";
            this.removeSubjectButton.UseVisualStyleBackColor = true;
            this.removeSubjectButton.Click += new System.EventHandler(this.removeSubjectButton_Click);
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(168, 130);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(154, 34);
            this.addStudentButton.TabIndex = 9;
            this.addStudentButton.Text = "Add  Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.Location = new System.Drawing.Point(172, 264);
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(154, 34);
            this.addSubjectButton.TabIndex = 10;
            this.addSubjectButton.Text = "Add Subject";
            this.addSubjectButton.UseVisualStyleBackColor = true;
            this.addSubjectButton.Click += new System.EventHandler(this.addSubjectButton_Click);
            // 
            // AddClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 676);
            this.Controls.Add(this.addSubjectButton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.removeSubjectButton);
            this.Controls.Add(this.removeStudentsButton);
            this.Controls.Add(this.subjectComboBox);
            this.Controls.Add(this.studentsComboBox);
            this.Controls.Add(this.createClassButton);
            this.Controls.Add(this.subjectListBox);
            this.Controls.Add(this.studentsListBox);
            this.Controls.Add(this.createSubjectButton);
            this.Controls.Add(this.createStudentButton);
            this.Name = "AddClassesForm";
            this.Text = "AddClassesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button createStudentButton;
        private Button createSubjectButton;
        private ListBox studentsListBox;
        private ListBox subjectListBox;
        private Button createClassButton;
        private ComboBox studentsComboBox;
        private ComboBox subjectComboBox;
        private Button removeStudentsButton;
        private Button removeSubjectButton;
        private Button addStudentButton;
        private Button addSubjectButton;
    }
}