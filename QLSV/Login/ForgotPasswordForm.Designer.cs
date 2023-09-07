namespace QLSV
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            this.backButton = new System.Windows.Forms.Button();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.txtBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.resetPasswordButton = new System.Windows.Forms.Button();
            this.txtBoxVertificationCode = new System.Windows.Forms.TextBox();
            this.labelForgotPassword = new System.Windows.Forms.Label();
            this.labelVertificationCode = new System.Windows.Forms.Label();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxNewPassword = new System.Windows.Forms.TextBox();
            this.sendEmailButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radioHRButton = new System.Windows.Forms.RadioButton();
            this.radioStudentButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(2, -1);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(67, 48);
            this.backButton.TabIndex = 26;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPassword.Location = new System.Drawing.Point(92, 307);
            this.labelNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(132, 24);
            this.labelNewPassword.TabIndex = 21;
            this.labelNewPassword.Text = "New Password:";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.Location = new System.Drawing.Point(198, 84);
            this.labelNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(284, 18);
            this.labelNote.TabIndex = 25;
            this.labelNote.Text = "Enter your email for resetting your password.";
            // 
            // txtBoxConfirmPassword
            // 
            this.txtBoxConfirmPassword.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConfirmPassword.Location = new System.Drawing.Point(232, 351);
            this.txtBoxConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxConfirmPassword.Name = "txtBoxConfirmPassword";
            this.txtBoxConfirmPassword.Size = new System.Drawing.Size(267, 31);
            this.txtBoxConfirmPassword.TabIndex = 24;
            this.txtBoxConfirmPassword.Text = "Password";
            this.txtBoxConfirmPassword.UseSystemPasswordChar = true;
            this.txtBoxConfirmPassword.TextChanged += new System.EventHandler(this.txtBoxConfirmPassword_TextChanged);
            // 
            // resetPasswordButton
            // 
            this.resetPasswordButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPasswordButton.Location = new System.Drawing.Point(232, 418);
            this.resetPasswordButton.Margin = new System.Windows.Forms.Padding(4);
            this.resetPasswordButton.Name = "resetPasswordButton";
            this.resetPasswordButton.Size = new System.Drawing.Size(267, 34);
            this.resetPasswordButton.TabIndex = 20;
            this.resetPasswordButton.Text = "Reset";
            this.resetPasswordButton.UseVisualStyleBackColor = true;
            this.resetPasswordButton.Click += new System.EventHandler(this.resetPasswordButton_Click);
            // 
            // txtBoxVertificationCode
            // 
            this.txtBoxVertificationCode.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxVertificationCode.Location = new System.Drawing.Point(232, 249);
            this.txtBoxVertificationCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxVertificationCode.Name = "txtBoxVertificationCode";
            this.txtBoxVertificationCode.Size = new System.Drawing.Size(192, 31);
            this.txtBoxVertificationCode.TabIndex = 19;
            // 
            // labelForgotPassword
            // 
            this.labelForgotPassword.AutoSize = true;
            this.labelForgotPassword.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForgotPassword.Location = new System.Drawing.Point(225, 43);
            this.labelForgotPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelForgotPassword.Name = "labelForgotPassword";
            this.labelForgotPassword.Size = new System.Drawing.Size(257, 41);
            this.labelForgotPassword.TabIndex = 14;
            this.labelForgotPassword.Text = "Forgot Password";
            // 
            // labelVertificationCode
            // 
            this.labelVertificationCode.AutoSize = true;
            this.labelVertificationCode.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVertificationCode.Location = new System.Drawing.Point(69, 256);
            this.labelVertificationCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVertificationCode.Name = "labelVertificationCode";
            this.labelVertificationCode.Size = new System.Drawing.Size(155, 24);
            this.labelVertificationCode.TabIndex = 18;
            this.labelVertificationCode.Text = "Verification Code:";
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPassword.Location = new System.Drawing.Point(66, 358);
            this.labelConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(158, 24);
            this.labelConfirmPassword.TabIndex = 22;
            this.labelConfirmPassword.Text = "Confirm Password:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(167, 200);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(57, 24);
            this.labelEmail.TabIndex = 17;
            this.labelEmail.Text = "Email:";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(232, 193);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(316, 31);
            this.txtBoxEmail.TabIndex = 15;
            // 
            // txtBoxNewPassword
            // 
            this.txtBoxNewPassword.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNewPassword.Location = new System.Drawing.Point(232, 300);
            this.txtBoxNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNewPassword.Name = "txtBoxNewPassword";
            this.txtBoxNewPassword.Size = new System.Drawing.Size(267, 31);
            this.txtBoxNewPassword.TabIndex = 23;
            this.txtBoxNewPassword.Text = "Password";
            this.txtBoxNewPassword.UseSystemPasswordChar = true;
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendEmailButton.Location = new System.Drawing.Point(454, 246);
            this.sendEmailButton.Margin = new System.Windows.Forms.Padding(4);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(94, 34);
            this.sendEmailButton.TabIndex = 16;
            this.sendEmailButton.Text = "Send";
            this.sendEmailButton.UseVisualStyleBackColor = true;
            this.sendEmailButton.Click += new System.EventHandler(this.sendEmailButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "User Type:";
            // 
            // radioHRButton
            // 
            this.radioHRButton.AutoSize = true;
            this.radioHRButton.BackColor = System.Drawing.Color.Transparent;
            this.radioHRButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioHRButton.ForeColor = System.Drawing.Color.Black;
            this.radioHRButton.Location = new System.Drawing.Point(365, 144);
            this.radioHRButton.Name = "radioHRButton";
            this.radioHRButton.Size = new System.Drawing.Size(130, 23);
            this.radioHRButton.TabIndex = 40;
            this.radioHRButton.TabStop = true;
            this.radioHRButton.Text = "Human Resource";
            this.radioHRButton.UseVisualStyleBackColor = false;
            // 
            // radioStudentButton
            // 
            this.radioStudentButton.AutoSize = true;
            this.radioStudentButton.BackColor = System.Drawing.Color.Transparent;
            this.radioStudentButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioStudentButton.ForeColor = System.Drawing.Color.Black;
            this.radioStudentButton.Location = new System.Drawing.Point(232, 144);
            this.radioStudentButton.Name = "radioStudentButton";
            this.radioStudentButton.Size = new System.Drawing.Size(80, 23);
            this.radioStudentButton.TabIndex = 39;
            this.radioStudentButton.TabStop = true;
            this.radioStudentButton.Text = "Student";
            this.radioStudentButton.UseVisualStyleBackColor = false;
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 483);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioHRButton);
            this.Controls.Add(this.radioStudentButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.labelNewPassword);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.txtBoxConfirmPassword);
            this.Controls.Add(this.resetPasswordButton);
            this.Controls.Add(this.txtBoxVertificationCode);
            this.Controls.Add(this.labelForgotPassword);
            this.Controls.Add(this.labelVertificationCode);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxNewPassword);
            this.Controls.Add(this.sendEmailButton);
            this.Name = "ForgotPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.TextBox txtBoxConfirmPassword;
        private System.Windows.Forms.Button resetPasswordButton;
        private System.Windows.Forms.TextBox txtBoxVertificationCode;
        private System.Windows.Forms.Label labelForgotPassword;
        private System.Windows.Forms.Label labelVertificationCode;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxNewPassword;
        private System.Windows.Forms.Button sendEmailButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioHRButton;
        private System.Windows.Forms.RadioButton radioStudentButton;
    }
}