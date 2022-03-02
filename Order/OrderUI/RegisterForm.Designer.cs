
namespace OrderUI
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
            this.passwordTextBox = new System.Windows.Forms.RichTextBox();
            this.emailTextBox = new System.Windows.Forms.RichTextBox();
            this.lastNameTextBox = new System.Windows.Forms.RichTextBox();
            this.confPasswordTextBox = new System.Windows.Forms.RichTextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(104, 61);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 40);
            this.firstNameTextBox.TabIndex = 0;
            this.firstNameTextBox.Text = "";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(104, 205);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 40);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Text = "";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(104, 127);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 40);
            this.emailTextBox.TabIndex = 2;
            this.emailTextBox.Text = "";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(348, 61);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 40);
            this.lastNameTextBox.TabIndex = 3;
            this.lastNameTextBox.Text = "";
            // 
            // confPasswordTextBox
            // 
            this.confPasswordTextBox.Location = new System.Drawing.Point(104, 280);
            this.confPasswordTextBox.Name = "confPasswordTextBox";
            this.confPasswordTextBox.Size = new System.Drawing.Size(200, 40);
            this.confPasswordTextBox.TabIndex = 4;
            this.confPasswordTextBox.Text = "";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(511, 320);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(112, 34);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.confPasswordTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox firstNameTextBox;
        private System.Windows.Forms.RichTextBox passwordTextBox;
        private System.Windows.Forms.RichTextBox emailTextBox;
        private System.Windows.Forms.RichTextBox lastNameTextBox;
        private System.Windows.Forms.RichTextBox confPasswordTextBox;
        private System.Windows.Forms.Button registerButton;
    }
}