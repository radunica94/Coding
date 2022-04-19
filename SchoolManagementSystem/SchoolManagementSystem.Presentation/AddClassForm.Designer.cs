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
            this.addStudentButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.classNameText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createClassButton
            // 
            this.createClassButton.Location = new System.Drawing.Point(358, 524);
            this.createClassButton.Name = "createClassButton";
            this.createClassButton.Size = new System.Drawing.Size(172, 34);
            this.createClassButton.TabIndex = 0;
            this.createClassButton.Text = "Create Class";
            this.createClassButton.UseVisualStyleBackColor = true;
            this.createClassButton.Click += new System.EventHandler(this.createClassButton_Click);
            // 
            // studentDropDown
            // 
            this.studentDropDown.FormattingEnabled = true;
            this.studentDropDown.Location = new System.Drawing.Point(140, 345);
            this.studentDropDown.Name = "studentDropDown";
            this.studentDropDown.Size = new System.Drawing.Size(294, 33);
            this.studentDropDown.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Class Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 345);
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
            this.label3.Location = new System.Drawing.Point(6, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Class Capacity:";
            // 
            // classCapacityText
            // 
            this.classCapacityText.Location = new System.Drawing.Point(140, 284);
            this.classCapacityText.Name = "classCapacityText";
            this.classCapacityText.Size = new System.Drawing.Size(294, 31);
            this.classCapacityText.TabIndex = 7;
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(365, 384);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(69, 34);
            this.addStudentButton.TabIndex = 12;
            this.addStudentButton.Text = "Add";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(736, 483);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(94, 34);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // classNameText
            // 
            this.classNameText.Location = new System.Drawing.Point(140, 143);
            this.classNameText.Name = "classNameText";
            this.classNameText.Size = new System.Drawing.Size(263, 31);
            this.classNameText.TabIndex = 14;
            // 
            // AddClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 642);
            this.Controls.Add(this.classNameText);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addStudentButton);
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
        private Button addStudentButton;
        private Button removeButton;
        private TextBox classNameText;
    }
}