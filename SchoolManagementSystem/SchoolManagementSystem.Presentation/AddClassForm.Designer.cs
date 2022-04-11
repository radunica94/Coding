namespace SchoolManagementSystem.Presentation
{
    partial class AddClassForm
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
            this.createClassButton = new System.Windows.Forms.Button();
            this.studentDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.classCapacityText = new System.Windows.Forms.TextBox();
            this.subjectCheckBox = new System.Windows.Forms.CheckedListBox();
            this.addSubjectLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // createClassButton
            // 
            this.createClassButton.Location = new System.Drawing.Point(398, 533);
            this.createClassButton.Name = "createClassButton";
            this.createClassButton.Size = new System.Drawing.Size(172, 34);
            this.createClassButton.TabIndex = 0;
            this.createClassButton.Text = "Create Class";
            this.createClassButton.UseVisualStyleBackColor = true;
            // 
            // studentDropDown
            // 
            this.studentDropDown.FormattingEnabled = true;
            this.studentDropDown.Location = new System.Drawing.Point(146, 409);
            this.studentDropDown.Name = "studentDropDown";
            this.studentDropDown.Size = new System.Drawing.Size(294, 33);
            this.studentDropDown.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Class Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add Student:";
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.ItemHeight = 25;
            this.studentListBox.Location = new System.Drawing.Point(464, 73);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(366, 404);
            this.studentListBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Class Capacity:";
            // 
            // classCapacityText
            // 
            this.classCapacityText.Location = new System.Drawing.Point(146, 348);
            this.classCapacityText.Name = "classCapacityText";
            this.classCapacityText.Size = new System.Drawing.Size(294, 31);
            this.classCapacityText.TabIndex = 7;
            // 
            // subjectCheckBox
            // 
            this.subjectCheckBox.FormattingEnabled = true;
            this.subjectCheckBox.Location = new System.Drawing.Point(146, 112);
            this.subjectCheckBox.Name = "subjectCheckBox";
            this.subjectCheckBox.Size = new System.Drawing.Size(180, 144);
            this.subjectCheckBox.TabIndex = 10;
            // 
            // addSubjectLink
            // 
            this.addSubjectLink.AutoSize = true;
            this.addSubjectLink.Location = new System.Drawing.Point(146, 259);
            this.addSubjectLink.Name = "addSubjectLink";
            this.addSubjectLink.Size = new System.Drawing.Size(109, 25);
            this.addSubjectLink.TabIndex = 11;
            this.addSubjectLink.TabStop = true;
            this.addSubjectLink.Text = "Add Subject";
            this.addSubjectLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addSubjectLink_LinkClicked);
            // 
            // AddClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 642);
            this.Controls.Add(this.addSubjectLink);
            this.Controls.Add(this.subjectCheckBox);
            this.Controls.Add(this.classCapacityText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.studentListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentDropDown);
            this.Controls.Add(this.createClassButton);
            this.Name = "AddClassForm";
            this.Text = "AddClassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button createClassButton;
        private ComboBox studentDropDown;
        private Label label1;
        private Label label2;
        private ListBox studentListBox;
        private Label label3;
        private TextBox classCapacityText;
        private CheckedListBox subjectCheckBox;
        private LinkLabel addSubjectLink;
    }
}