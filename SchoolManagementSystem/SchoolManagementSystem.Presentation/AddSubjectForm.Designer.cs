namespace SchoolManagementSystem.Presentation
{
    partial class AddSubjectForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.teacherDropDown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.teacherListBox = new System.Windows.Forms.ListBox();
            this.subjectNameText = new System.Windows.Forms.TextBox();
            this.addSubjectButton = new System.Windows.Forms.Button();
            this.addTeacherButton = new System.Windows.Forms.Button();
            this.yearText = new System.Windows.Forms.TextBox();
            this.semesterText = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teacher: ";
            // 
            // teacherDropDown
            // 
            this.teacherDropDown.FormattingEnabled = true;
            this.teacherDropDown.Location = new System.Drawing.Point(129, 271);
            this.teacherDropDown.Name = "teacherDropDown";
            this.teacherDropDown.Size = new System.Drawing.Size(182, 33);
            this.teacherDropDown.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Semester:";
            // 
            // teacherListBox
            // 
            this.teacherListBox.FormattingEnabled = true;
            this.teacherListBox.ItemHeight = 25;
            this.teacherListBox.Location = new System.Drawing.Point(463, 50);
            this.teacherListBox.Name = "teacherListBox";
            this.teacherListBox.Size = new System.Drawing.Size(315, 254);
            this.teacherListBox.TabIndex = 5;
            // 
            // subjectNameText
            // 
            this.subjectNameText.Location = new System.Drawing.Point(149, 70);
            this.subjectNameText.Name = "subjectNameText";
            this.subjectNameText.Size = new System.Drawing.Size(224, 31);
            this.subjectNameText.TabIndex = 6;
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.Location = new System.Drawing.Point(296, 372);
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(189, 34);
            this.addSubjectButton.TabIndex = 9;
            this.addSubjectButton.Text = "Create Subject";
            this.addSubjectButton.UseVisualStyleBackColor = true;
            this.addSubjectButton.Click += new System.EventHandler(this.addSubjectButton_Click);
            // 
            // addTeacherButton
            // 
            this.addTeacherButton.Location = new System.Drawing.Point(317, 271);
            this.addTeacherButton.Name = "addTeacherButton";
            this.addTeacherButton.Size = new System.Drawing.Size(63, 34);
            this.addTeacherButton.TabIndex = 10;
            this.addTeacherButton.Text = "Add";
            this.addTeacherButton.UseVisualStyleBackColor = true;
            this.addTeacherButton.Click += new System.EventHandler(this.addTeacherButton_Click);
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(156, 124);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(224, 31);
            this.yearText.TabIndex = 11;
            // 
            // semesterText
            // 
            this.semesterText.Location = new System.Drawing.Point(156, 163);
            this.semesterText.Name = "semesterText";
            this.semesterText.Size = new System.Drawing.Size(224, 31);
            this.semesterText.TabIndex = 12;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(666, 310);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(112, 34);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // AddSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.semesterText);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.addTeacherButton);
            this.Controls.Add(this.addSubjectButton);
            this.Controls.Add(this.subjectNameText);
            this.Controls.Add(this.teacherListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.teacherDropDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddSubjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSubjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox teacherDropDown;
        private Label label4;
        private Label label5;
        private ListBox teacherListBox;
        private TextBox subjectNameText;
        private Button addSubjectButton;
        private Button addTeacherButton;
        private TextBox yearText;
        private TextBox semesterText;
        private Button removeButton;
    }
}