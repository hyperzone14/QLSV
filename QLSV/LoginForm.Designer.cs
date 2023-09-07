
namespace QLSV
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.userIcon = new System.Windows.Forms.PictureBox();
            this.passIcon = new System.Windows.Forms.PictureBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.newaccountButton = new System.Windows.Forms.Button();
            this.forgotButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.radioStudentButton = new System.Windows.Forms.RadioButton();
            this.radioHRButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(50, 136);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(302, 35);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.Validated += new System.EventHandler(this.txtUsername_Validated);
            // 
            // userIcon
            // 
            this.userIcon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userIcon.Enabled = false;
            this.userIcon.Location = new System.Drawing.Point(50, 136);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(42, 25);
            this.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userIcon.TabIndex = 4;
            this.userIcon.TabStop = false;
            // 
            // passIcon
            // 
            this.passIcon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passIcon.Enabled = false;
            this.passIcon.Location = new System.Drawing.Point(50, 205);
            this.passIcon.Name = "passIcon";
            this.passIcon.Size = new System.Drawing.Size(42, 25);
            this.passIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passIcon.TabIndex = 5;
            this.passIcon.TabStop = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loginButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Black;
            this.loginButton.Location = new System.Drawing.Point(50, 283);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(303, 45);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // newaccountButton
            // 
            this.newaccountButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.newaccountButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newaccountButton.ForeColor = System.Drawing.Color.Black;
            this.newaccountButton.Location = new System.Drawing.Point(49, 334);
            this.newaccountButton.Name = "newaccountButton";
            this.newaccountButton.Size = new System.Drawing.Size(303, 45);
            this.newaccountButton.TabIndex = 3;
            this.newaccountButton.Text = "Create New Account";
            this.newaccountButton.UseVisualStyleBackColor = false;
            this.newaccountButton.Click += new System.EventHandler(this.newaccountButton_Click);
            // 
            // forgotButton
            // 
            this.forgotButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.forgotButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotButton.ForeColor = System.Drawing.Color.IndianRed;
            this.forgotButton.Location = new System.Drawing.Point(49, 385);
            this.forgotButton.Name = "forgotButton";
            this.forgotButton.Size = new System.Drawing.Size(303, 45);
            this.forgotButton.TabIndex = 4;
            this.forgotButton.Text = "Forgot Password";
            this.forgotButton.UseVisualStyleBackColor = false;
            this.forgotButton.Click += new System.EventHandler(this.forgotButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(126, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 60);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOGIN";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(50, 205);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(302, 35);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Validated += new System.EventHandler(this.txtPassword_Validated);
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.Transparent;
            this.Exitbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exitbutton.BackgroundImage")));
            this.Exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exitbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exitbutton.Location = new System.Drawing.Point(0, -1);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(40, 39);
            this.Exitbutton.TabIndex = 7;
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // radioStudentButton
            // 
            this.radioStudentButton.AutoSize = true;
            this.radioStudentButton.Location = new System.Drawing.Point(49, 251);
            this.radioStudentButton.Name = "radioStudentButton";
            this.radioStudentButton.Size = new System.Drawing.Size(93, 26);
            this.radioStudentButton.TabIndex = 8;
            this.radioStudentButton.TabStop = true;
            this.radioStudentButton.Text = "Student";
            this.radioStudentButton.UseVisualStyleBackColor = true;
            this.radioStudentButton.CheckedChanged += new System.EventHandler(this.radioStudentButton_CheckedChanged);
            // 
            // radioHRButton
            // 
            this.radioHRButton.AutoSize = true;
            this.radioHRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioHRButton.Location = new System.Drawing.Point(206, 251);
            this.radioHRButton.Name = "radioHRButton";
            this.radioHRButton.Size = new System.Drawing.Size(170, 26);
            this.radioHRButton.TabIndex = 9;
            this.radioHRButton.TabStop = true;
            this.radioHRButton.Text = "Human Resourse";
            this.radioHRButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.Exitbutton;
            this.ClientSize = new System.Drawing.Size(400, 480);
            this.Controls.Add(this.radioHRButton);
            this.Controls.Add(this.radioStudentButton);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forgotButton);
            this.Controls.Add(this.newaccountButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passIcon);
            this.Controls.Add(this.userIcon);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox userIcon;
        private System.Windows.Forms.PictureBox passIcon;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button newaccountButton;
        private System.Windows.Forms.Button forgotButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.RadioButton radioHRButton;
        public System.Windows.Forms.RadioButton radioStudentButton;
    }
}

