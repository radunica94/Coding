﻿namespace SchoolManagementSystem.Presentation
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
            this.SuspendLayout();
            // 
            // addClass
            // 
            this.addClass.Location = new System.Drawing.Point(0, 0);
            this.addClass.Name = "addClass";
            this.addClass.Size = new System.Drawing.Size(163, 34);
            this.addClass.TabIndex = 0;
            this.addClass.Text = "Create Class";
            this.addClass.UseVisualStyleBackColor = true;
            this.addClass.Click += new System.EventHandler(this.addClass_Click);
            // 
            // MainTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addClass);
            this.Name = "MainTeacherForm";
            this.Text = "MainTeacherForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button addClass;
    }
}