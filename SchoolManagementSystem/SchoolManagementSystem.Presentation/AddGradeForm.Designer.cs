namespace SchoolManagementSystem.Presentation
{
    partial class AddGradeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.gradeTxt = new System.Windows.Forms.TextBox();
            this.subjectListBox = new System.Windows.Forms.ListBox();
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.studentComboBox = new System.Windows.Forms.ComboBox();
            this.AddStudent = new System.Windows.Forms.Button();
            this.removeStudentButton = new System.Windows.Forms.Button();
            this.removeSubjectButton = new System.Windows.Forms.Button();
            this.addSubjectButton = new System.Windows.Forms.Button();
            this.addGradeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grade :";
            // 
            // gradeTxt
            // 
            this.gradeTxt.Location = new System.Drawing.Point(96, 69);
            this.gradeTxt.Name = "gradeTxt";
            this.gradeTxt.Size = new System.Drawing.Size(262, 31);
            this.gradeTxt.TabIndex = 1;
            // 
            // subjectListBox
            // 
            this.subjectListBox.FormattingEnabled = true;
            this.subjectListBox.ItemHeight = 25;
            this.subjectListBox.Location = new System.Drawing.Point(357, 123);
            this.subjectListBox.Name = "subjectListBox";
            this.subjectListBox.Size = new System.Drawing.Size(299, 279);
            this.subjectListBox.TabIndex = 2;
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.ItemHeight = 25;
            this.studentListBox.Location = new System.Drawing.Point(34, 123);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(278, 279);
            this.studentListBox.TabIndex = 3;
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(357, 408);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(299, 33);
            this.subjectComboBox.TabIndex = 4;
            // 
            // studentComboBox
            // 
            this.studentComboBox.FormattingEnabled = true;
            this.studentComboBox.Location = new System.Drawing.Point(34, 408);
            this.studentComboBox.Name = "studentComboBox";
            this.studentComboBox.Size = new System.Drawing.Size(278, 33);
            this.studentComboBox.TabIndex = 5;
            // 
            // AddStudent
            // 
            this.AddStudent.Location = new System.Drawing.Point(34, 447);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(112, 34);
            this.AddStudent.TabIndex = 6;
            this.AddStudent.Text = "Add";
            this.AddStudent.UseVisualStyleBackColor = true;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // removeStudentButton
            // 
            this.removeStudentButton.Location = new System.Drawing.Point(200, 447);
            this.removeStudentButton.Name = "removeStudentButton";
            this.removeStudentButton.Size = new System.Drawing.Size(112, 34);
            this.removeStudentButton.TabIndex = 7;
            this.removeStudentButton.Text = "Remove";
            this.removeStudentButton.UseVisualStyleBackColor = true;
            this.removeStudentButton.Click += new System.EventHandler(this.removeStudentButton_Click);
            // 
            // removeSubjectButton
            // 
            this.removeSubjectButton.Location = new System.Drawing.Point(544, 447);
            this.removeSubjectButton.Name = "removeSubjectButton";
            this.removeSubjectButton.Size = new System.Drawing.Size(112, 34);
            this.removeSubjectButton.TabIndex = 8;
            this.removeSubjectButton.Text = "Remove";
            this.removeSubjectButton.UseVisualStyleBackColor = true;
            this.removeSubjectButton.Click += new System.EventHandler(this.removeSubjectButton_Click);
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.Location = new System.Drawing.Point(357, 447);
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(112, 34);
            this.addSubjectButton.TabIndex = 9;
            this.addSubjectButton.Text = "Add";
            this.addSubjectButton.UseVisualStyleBackColor = true;
            this.addSubjectButton.Click += new System.EventHandler(this.addSubjectButton_Click);
            // 
            // addGradeButton
            // 
            this.addGradeButton.Location = new System.Drawing.Point(213, 532);
            this.addGradeButton.Name = "addGradeButton";
            this.addGradeButton.Size = new System.Drawing.Size(145, 34);
            this.addGradeButton.TabIndex = 10;
            this.addGradeButton.Text = "Add Grade";
            this.addGradeButton.UseVisualStyleBackColor = true;
            this.addGradeButton.Click += new System.EventHandler(this.addGradeButton_Click);
            // 
            // AddGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 613);
            this.Controls.Add(this.addGradeButton);
            this.Controls.Add(this.addSubjectButton);
            this.Controls.Add(this.removeSubjectButton);
            this.Controls.Add(this.removeStudentButton);
            this.Controls.Add(this.AddStudent);
            this.Controls.Add(this.studentComboBox);
            this.Controls.Add(this.subjectComboBox);
            this.Controls.Add(this.studentListBox);
            this.Controls.Add(this.subjectListBox);
            this.Controls.Add(this.gradeTxt);
            this.Controls.Add(this.label1);
            this.Name = "AddGradeForm";
            this.Text = "AddGradeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox gradeTxt;
        private ListBox subjectListBox;
        private ListBox studentListBox;
        private ComboBox subjectComboBox;
        private ComboBox studentComboBox;
        private Button AddStudent;
        private Button removeStudentButton;
        private Button removeSubjectButton;
        private Button addSubjectButton;
        private Button addGradeButton;
    }
}