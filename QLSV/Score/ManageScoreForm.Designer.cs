namespace QLSV
{
    partial class ManageScoreForm
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
            this.addScorebt = new System.Windows.Forms.Button();
            this.comboBoxCourses = new System.Windows.Forms.ComboBox();
            this.tbxScore = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbxStudentID = new System.Windows.Forms.TextBox();
            this.lbldescrip = new System.Windows.Forms.Label();
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.aveScorebt = new System.Windows.Forms.Button();
            this.showScoresButton = new System.Windows.Forms.Button();
            this.showStudentsButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addScorebt
            // 
            this.addScorebt.Location = new System.Drawing.Point(56, 331);
            this.addScorebt.Name = "addScorebt";
            this.addScorebt.Size = new System.Drawing.Size(150, 45);
            this.addScorebt.TabIndex = 69;
            this.addScorebt.Text = "Add Score";
            this.addScorebt.UseVisualStyleBackColor = true;
            this.addScorebt.Click += new System.EventHandler(this.addButton_Click);
            // 
            // comboBoxCourses
            // 
            this.comboBoxCourses.FormattingEnabled = true;
            this.comboBoxCourses.Location = new System.Drawing.Point(160, 68);
            this.comboBoxCourses.Name = "comboBoxCourses";
            this.comboBoxCourses.Size = new System.Drawing.Size(327, 24);
            this.comboBoxCourses.TabIndex = 68;
            this.comboBoxCourses.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourses_SelectedIndexChanged);
            // 
            // tbxScore
            // 
            this.tbxScore.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxScore.Location = new System.Drawing.Point(160, 111);
            this.tbxScore.Name = "tbxScore";
            this.tbxScore.Size = new System.Drawing.Size(129, 31);
            this.tbxScore.TabIndex = 67;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(519, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(522, 293);
            this.dataGridView1.TabIndex = 66;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // tbxStudentID
            // 
            this.tbxStudentID.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStudentID.Location = new System.Drawing.Point(160, 15);
            this.tbxStudentID.Name = "tbxStudentID";
            this.tbxStudentID.Size = new System.Drawing.Size(327, 31);
            this.tbxStudentID.TabIndex = 65;
            this.tbxStudentID.TextChanged += new System.EventHandler(this.tbxStudentID_TextChanged);
            // 
            // lbldescrip
            // 
            this.lbldescrip.AutoSize = true;
            this.lbldescrip.BackColor = System.Drawing.Color.Transparent;
            this.lbldescrip.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescrip.Location = new System.Drawing.Point(18, 162);
            this.lbldescrip.Name = "lbldescrip";
            this.lbldescrip.Size = new System.Drawing.Size(109, 24);
            this.lbldescrip.TabIndex = 64;
            this.lbldescrip.Text = "Description:";
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectCourse.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCourse.Location = new System.Drawing.Point(11, 18);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(110, 24);
            this.lblSelectCourse.TabIndex = 63;
            this.lblSelectCourse.Text = "Student ID:";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.BackColor = System.Drawing.Color.Transparent;
            this.lblPeriod.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(18, 118);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(64, 24);
            this.lblPeriod.TabIndex = 62;
            this.lblPeriod.Text = "Score:";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescription.ForeColor = System.Drawing.Color.Black;
            this.tbxDescription.Location = new System.Drawing.Point(160, 159);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(327, 108);
            this.tbxDescription.TabIndex = 61;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(11, 65);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(131, 24);
            this.lblCourseName.TabIndex = 60;
            this.lblCourseName.Text = "Select Course:";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(337, 331);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(150, 45);
            this.removeButton.TabIndex = 70;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // aveScorebt
            // 
            this.aveScorebt.Location = new System.Drawing.Point(160, 413);
            this.aveScorebt.Name = "aveScorebt";
            this.aveScorebt.Size = new System.Drawing.Size(231, 45);
            this.aveScorebt.TabIndex = 71;
            this.aveScorebt.Text = "Average Score by Course";
            this.aveScorebt.UseVisualStyleBackColor = true;
            this.aveScorebt.Click += new System.EventHandler(this.averageButton_Click);
            // 
            // showScoresButton
            // 
            this.showScoresButton.Location = new System.Drawing.Point(620, 331);
            this.showScoresButton.Name = "showScoresButton";
            this.showScoresButton.Size = new System.Drawing.Size(150, 45);
            this.showScoresButton.TabIndex = 72;
            this.showScoresButton.Text = "Show Score";
            this.showScoresButton.UseVisualStyleBackColor = true;
            this.showScoresButton.Click += new System.EventHandler(this.showScoresButton_Click);
            // 
            // showStudentsButton
            // 
            this.showStudentsButton.Location = new System.Drawing.Point(834, 331);
            this.showStudentsButton.Name = "showStudentsButton";
            this.showStudentsButton.Size = new System.Drawing.Size(150, 45);
            this.showStudentsButton.TabIndex = 73;
            this.showStudentsButton.Text = "Show Student";
            this.showStudentsButton.UseVisualStyleBackColor = true;
            this.showStudentsButton.Click += new System.EventHandler(this.showStudentButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(731, 413);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 45);
            this.cancelButton.TabIndex = 74;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ManageScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 470);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.showStudentsButton);
            this.Controls.Add(this.showScoresButton);
            this.Controls.Add(this.aveScorebt);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addScorebt);
            this.Controls.Add(this.comboBoxCourses);
            this.Controls.Add(this.tbxScore);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbxStudentID);
            this.Controls.Add(this.lbldescrip);
            this.Controls.Add(this.lblSelectCourse);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.lblCourseName);
            this.Name = "ManageScoreForm";
            this.Text = "ManageScoreForm";
            this.Load += new System.EventHandler(this.ManageScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addScorebt;
        private System.Windows.Forms.ComboBox comboBoxCourses;
        private System.Windows.Forms.TextBox tbxScore;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbxStudentID;
        private System.Windows.Forms.Label lbldescrip;
        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button aveScorebt;
        private System.Windows.Forms.Button showScoresButton;
        private System.Windows.Forms.Button showStudentsButton;
        private System.Windows.Forms.Button cancelButton;
    }
}