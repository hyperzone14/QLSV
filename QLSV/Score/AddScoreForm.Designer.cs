namespace QLSV
{
    partial class AddScoreForm
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
            this.tbxStudentID = new System.Windows.Forms.TextBox();
            this.lbldescrip = new System.Windows.Forms.Label();
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.dataGridViewStudentID = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSettt = new QLSV.QLSVDataSettt();
            this.stdTableAdapter1 = new QLSV.QLSVDataSetttTableAdapters.stdTableAdapter();
            this.tbxScore = new System.Windows.Forms.TextBox();
            this.comboBoxCourses = new System.Windows.Forms.ComboBox();
            this.addScorebt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSettt)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxStudentID
            // 
            this.tbxStudentID.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStudentID.Location = new System.Drawing.Point(181, 28);
            this.tbxStudentID.Name = "tbxStudentID";
            this.tbxStudentID.Size = new System.Drawing.Size(327, 31);
            this.tbxStudentID.TabIndex = 53;
            // 
            // lbldescrip
            // 
            this.lbldescrip.AutoSize = true;
            this.lbldescrip.BackColor = System.Drawing.Color.Transparent;
            this.lbldescrip.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescrip.Location = new System.Drawing.Point(39, 175);
            this.lbldescrip.Name = "lbldescrip";
            this.lbldescrip.Size = new System.Drawing.Size(109, 24);
            this.lbldescrip.TabIndex = 52;
            this.lbldescrip.Text = "Description:";
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectCourse.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCourse.Location = new System.Drawing.Point(32, 31);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(110, 24);
            this.lblSelectCourse.TabIndex = 50;
            this.lblSelectCourse.Text = "Student ID:";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.BackColor = System.Drawing.Color.Transparent;
            this.lblPeriod.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(39, 131);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(64, 24);
            this.lblPeriod.TabIndex = 48;
            this.lblPeriod.Text = "Score:";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescription.ForeColor = System.Drawing.Color.Black;
            this.tbxDescription.Location = new System.Drawing.Point(181, 172);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(327, 108);
            this.tbxDescription.TabIndex = 47;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(32, 78);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(131, 24);
            this.lblCourseName.TabIndex = 46;
            this.lblCourseName.Text = "Select Course:";
            // 
            // dataGridViewStudentID
            // 
            this.dataGridViewStudentID.AutoGenerateColumns = false;
            this.dataGridViewStudentID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudentID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn});
            this.dataGridViewStudentID.DataSource = this.stdBindingSource1;
            this.dataGridViewStudentID.Location = new System.Drawing.Point(534, 28);
            this.dataGridViewStudentID.Name = "dataGridViewStudentID";
            this.dataGridViewStudentID.RowHeadersWidth = 51;
            this.dataGridViewStudentID.RowTemplate.Height = 24;
            this.dataGridViewStudentID.Size = new System.Drawing.Size(440, 252);
            this.dataGridViewStudentID.TabIndex = 54;
            this.dataGridViewStudentID.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudentID_CellContentClick);
            this.dataGridViewStudentID.Click += new System.EventHandler(this.DataGridViewStudents_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Student ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.fnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // stdBindingSource1
            // 
            this.stdBindingSource1.DataMember = "std";
            this.stdBindingSource1.DataSource = this.qLSVDataSettt;
            // 
            // qLSVDataSettt
            // 
            this.qLSVDataSettt.DataSetName = "QLSVDataSettt";
            this.qLSVDataSettt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stdTableAdapter1
            // 
            this.stdTableAdapter1.ClearBeforeFill = true;
            // 
            // tbxScore
            // 
            this.tbxScore.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxScore.Location = new System.Drawing.Point(181, 124);
            this.tbxScore.Name = "tbxScore";
            this.tbxScore.Size = new System.Drawing.Size(129, 31);
            this.tbxScore.TabIndex = 55;
            // 
            // comboBoxCourses
            // 
            this.comboBoxCourses.FormattingEnabled = true;
            this.comboBoxCourses.Location = new System.Drawing.Point(181, 81);
            this.comboBoxCourses.Name = "comboBoxCourses";
            this.comboBoxCourses.Size = new System.Drawing.Size(327, 24);
            this.comboBoxCourses.TabIndex = 58;
            this.comboBoxCourses.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourses_SelectedIndexChanged);
            // 
            // addScorebt
            // 
            this.addScorebt.Location = new System.Drawing.Point(160, 316);
            this.addScorebt.Name = "addScorebt";
            this.addScorebt.Size = new System.Drawing.Size(150, 45);
            this.addScorebt.TabIndex = 59;
            this.addScorebt.Text = "Add Score";
            this.addScorebt.UseVisualStyleBackColor = true;
            this.addScorebt.Click += new System.EventHandler(this.addScorebt_Click);
            // 
            // AddScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 409);
            this.Controls.Add(this.addScorebt);
            this.Controls.Add(this.comboBoxCourses);
            this.Controls.Add(this.tbxScore);
            this.Controls.Add(this.dataGridViewStudentID);
            this.Controls.Add(this.tbxStudentID);
            this.Controls.Add(this.lbldescrip);
            this.Controls.Add(this.lblSelectCourse);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.lblCourseName);
            this.Name = "AddScore";
            this.Text = "Add Score Form";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSettt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxStudentID;
        private System.Windows.Forms.Label lbldescrip;
        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.DataGridView dataGridViewStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stdBindingSource1;
        private QLSVDataSettt qLSVDataSettt;
        private QLSVDataSetttTableAdapters.stdTableAdapter stdTableAdapter1;
        private System.Windows.Forms.TextBox tbxScore;
        private System.Windows.Forms.ComboBox comboBoxCourses;
        private System.Windows.Forms.Button addScorebt;
    }
}