namespace SchoolManagementSystem.Presentation
{
    partial class MainTeacherForm
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
            this.addClass = new System.Windows.Forms.Button();
            this.addGradeButton = new System.Windows.Forms.Button();
            this.addSubjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addClass
            // 
            this.addClass.Location = new System.Drawing.Point(0, 36);
            this.addClass.Name = "addClass";
            this.addClass.Size = new System.Drawing.Size(163, 34);
            this.addClass.TabIndex = 0;
            this.addClass.Text = "Create Class";
            this.addClass.UseVisualStyleBackColor = true;
            this.addClass.Click += new System.EventHandler(this.addClass_Click);
            // 
            // addGradeButton
            // 
            this.addGradeButton.Location = new System.Drawing.Point(0, 175);
            this.addGradeButton.Name = "addGradeButton";
            this.addGradeButton.Size = new System.Drawing.Size(163, 34);
            this.addGradeButton.TabIndex = 1;
            this.addGradeButton.Text = "Add Grade";
            this.addGradeButton.UseVisualStyleBackColor = true;
            this.addGradeButton.Click += new System.EventHandler(this.addGradeButton_Click);
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.Location = new System.Drawing.Point(0, 104);
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(163, 34);
            this.addSubjectButton.TabIndex = 2;
            this.addSubjectButton.Text = "Add Subject";
            this.addSubjectButton.UseVisualStyleBackColor = true;
            this.addSubjectButton.Click += new System.EventHandler(this.addSubjectButton_Click);
            // 
            // MainTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addSubjectButton);
            this.Controls.Add(this.addGradeButton);
            this.Controls.Add(this.addClass);
            this.Name = "MainTeacherForm";
            this.Text = "MainTeacherForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button addClass;
        private Button addGradeButton;
        private Button addSubjectButton;
    }
}