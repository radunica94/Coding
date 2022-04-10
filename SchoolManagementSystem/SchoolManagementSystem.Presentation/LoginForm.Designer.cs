namespace SchoolManagementSystem.Presentation
{
    partial class LoginForm
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
            this.loginButton = new System.Windows.Forms.Button();
            this.loginPasswordTxt = new System.Windows.Forms.TextBox();
            this.loginUsernameTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(253, 208);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(112, 34);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginPasswordTxt
            // 
            this.loginPasswordTxt.Location = new System.Drawing.Point(253, 125);
            this.loginPasswordTxt.Name = "loginPasswordTxt";
            this.loginPasswordTxt.Size = new System.Drawing.Size(224, 31);
            this.loginPasswordTxt.TabIndex = 1;
            // 
            // loginUsernameTxt
            // 
            this.loginUsernameTxt.Location = new System.Drawing.Point(253, 69);
            this.loginUsernameTxt.Name = "loginUsernameTxt";
            this.loginUsernameTxt.Size = new System.Drawing.Size(224, 31);
            this.loginUsernameTxt.TabIndex = 2;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginUsernameTxt);
            this.Controls.Add(this.loginPasswordTxt);
            this.Controls.Add(this.loginButton);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button loginButton;
        private TextBox loginPasswordTxt;
        private TextBox loginUsernameTxt;
    }
}