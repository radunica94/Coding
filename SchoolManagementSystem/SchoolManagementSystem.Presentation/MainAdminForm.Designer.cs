namespace SchoolManagementSystem.Presentation
{
    partial class MainAdminForm
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
            this.userButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userButton
            // 
            this.userButton.Location = new System.Drawing.Point(0, 0);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(156, 34);
            this.userButton.TabIndex = 0;
            this.userButton.Text = "Create User";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // MainAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userButton);
            this.Name = "MainAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainAdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button userButton;
    }
}