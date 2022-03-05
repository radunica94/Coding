﻿
namespace OrderSystemUI
{
    partial class RegisterForm
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
            this.firstNameTextBox = new System.Windows.Forms.RichTextBox();
            this.lastNameTextBox = new System.Windows.Forms.RichTextBox();
            this.passwordTextBox = new System.Windows.Forms.RichTextBox();
            this.confirmPasswordTextBox = new System.Windows.Forms.RichTextBox();
            this.emailTextBox = new System.Windows.Forms.RichTextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameTextBox.ForeColor = System.Drawing.Color.Silver;
            this.firstNameTextBox.Location = new System.Drawing.Point(65, 140);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(150, 35);
            this.firstNameTextBox.TabIndex = 0;
            this.firstNameTextBox.Text = "First Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameTextBox.ForeColor = System.Drawing.Color.Silver;
            this.lastNameTextBox.Location = new System.Drawing.Point(221, 140);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(150, 35);
            this.lastNameTextBox.TabIndex = 1;
            this.lastNameTextBox.Text = "Last Name";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.ForeColor = System.Drawing.Color.Silver;
            this.passwordTextBox.Location = new System.Drawing.Point(65, 290);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(306, 35);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Text = "Password";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmPasswordTextBox.ForeColor = System.Drawing.Color.Silver;
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(65, 365);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(306, 35);
            this.confirmPasswordTextBox.TabIndex = 3;
            this.confirmPasswordTextBox.Text = "Confirm Password";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailTextBox.ForeColor = System.Drawing.Color.Silver;
            this.emailTextBox.Location = new System.Drawing.Point(65, 215);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(306, 35);
            this.emailTextBox.TabIndex = 4;
            this.emailTextBox.Text = "Email";
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registerButton.Location = new System.Drawing.Point(143, 455);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(150, 40);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Register Now";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(16, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Create your account. It\'s free and only takes a minute.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(142, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 43);
            this.label2.TabIndex = 7;
            this.label2.Text = "Register";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(436, 600);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox firstNameTextBox;
        private System.Windows.Forms.RichTextBox lastNameTextBox;
        private System.Windows.Forms.RichTextBox passwordTextBox;
        private System.Windows.Forms.RichTextBox confirmPasswordTextBox;
        private System.Windows.Forms.RichTextBox emailTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}