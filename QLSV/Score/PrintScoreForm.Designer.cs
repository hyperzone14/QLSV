namespace QLSV
{
    partial class PrintScoreForm
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
            this.labelReset = new System.Windows.Forms.Label();
            this.printTxtFileButton = new System.Windows.Forms.Button();
            this.labelStudent = new System.Windows.Forms.Label();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.labelScoreList = new System.Windows.Forms.Label();
            this.dataGridViewScore = new System.Windows.Forms.DataGridView();
            this.listBoxCourse = new System.Windows.Forms.ListBox();
            this.labelCourseList = new System.Windows.Forms.Label();
            this.printtoWordBt = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printtoExcelBt = new System.Windows.Forms.Button();
            this.printtoPDFBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).BeginInit();
            this.SuspendLayout();
            // 
            // labelReset
            // 
            this.labelReset.AutoSize = true;
            this.labelReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelReset.ForeColor = System.Drawing.Color.Red;
            this.labelReset.Location = new System.Drawing.Point(7, 9);
            this.labelReset.Name = "labelReset";
            this.labelReset.Size = new System.Drawing.Size(81, 29);
            this.labelReset.TabIndex = 15;
            this.labelReset.Text = "Reset";
            this.labelReset.Click += new System.EventHandler(this.labelReset_Click);
            // 
            // printTxtFileButton
            // 
            this.printTxtFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.printTxtFileButton.Location = new System.Drawing.Point(12, 439);
            this.printTxtFileButton.Name = "printTxtFileButton";
            this.printTxtFileButton.Size = new System.Drawing.Size(254, 36);
            this.printTxtFileButton.TabIndex = 14;
            this.printTxtFileButton.Text = "Print To Text File";
            this.printTxtFileButton.UseVisualStyleBackColor = true;
            this.printTxtFileButton.Click += new System.EventHandler(this.printTxtFileButton_Click);
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelStudent.Location = new System.Drawing.Point(270, 43);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(99, 20);
            this.labelStudent.TabIndex = 13;
            this.labelStudent.Text = "Student List";
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(273, 81);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.RowHeadersWidth = 51;
            this.dataGridViewStudent.RowTemplate.Height = 24;
            this.dataGridViewStudent.Size = new System.Drawing.Size(321, 324);
            this.dataGridViewStudent.TabIndex = 12;
            this.dataGridViewStudent.Click += new System.EventHandler(this.dataGridViewStudent_Click);
            // 
            // labelScoreList
            // 
            this.labelScoreList.AutoSize = true;
            this.labelScoreList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelScoreList.Location = new System.Drawing.Point(597, 43);
            this.labelScoreList.Name = "labelScoreList";
            this.labelScoreList.Size = new System.Drawing.Size(86, 20);
            this.labelScoreList.TabIndex = 11;
            this.labelScoreList.Text = "Score List";
            // 
            // dataGridViewScore
            // 
            this.dataGridViewScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScore.Location = new System.Drawing.Point(601, 81);
            this.dataGridViewScore.Name = "dataGridViewScore";
            this.dataGridViewScore.RowHeadersWidth = 51;
            this.dataGridViewScore.RowTemplate.Height = 24;
            this.dataGridViewScore.Size = new System.Drawing.Size(700, 487);
            this.dataGridViewScore.TabIndex = 10;
            this.dataGridViewScore.Click += new System.EventHandler(this.dataGridViewScore_Click);
            // 
            // listBoxCourse
            // 
            this.listBoxCourse.FormattingEnabled = true;
            this.listBoxCourse.ItemHeight = 16;
            this.listBoxCourse.Location = new System.Drawing.Point(12, 81);
            this.listBoxCourse.Name = "listBoxCourse";
            this.listBoxCourse.Size = new System.Drawing.Size(255, 324);
            this.listBoxCourse.TabIndex = 9;
            this.listBoxCourse.Click += new System.EventHandler(this.listBoxCourse_Click);
            // 
            // labelCourseList
            // 
            this.labelCourseList.AutoSize = true;
            this.labelCourseList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelCourseList.Location = new System.Drawing.Point(8, 43);
            this.labelCourseList.Name = "labelCourseList";
            this.labelCourseList.Size = new System.Drawing.Size(96, 20);
            this.labelCourseList.TabIndex = 8;
            this.labelCourseList.Text = "Course List";
            // 
            // printtoWordBt
            // 
            this.printtoWordBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.printtoWordBt.ForeColor = System.Drawing.Color.DodgerBlue;
            this.printtoWordBt.Location = new System.Drawing.Point(327, 439);
            this.printtoWordBt.Name = "printtoWordBt";
            this.printtoWordBt.Size = new System.Drawing.Size(254, 36);
            this.printtoWordBt.TabIndex = 16;
            this.printtoWordBt.Text = "Print To Word File";
            this.printtoWordBt.UseVisualStyleBackColor = true;
            this.printtoWordBt.Click += new System.EventHandler(this.printtoWordBt_Click);
            // 
            // printtoExcelBt
            // 
            this.printtoExcelBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.printtoExcelBt.ForeColor = System.Drawing.Color.Green;
            this.printtoExcelBt.Location = new System.Drawing.Point(327, 507);
            this.printtoExcelBt.Name = "printtoExcelBt";
            this.printtoExcelBt.Size = new System.Drawing.Size(254, 36);
            this.printtoExcelBt.TabIndex = 17;
            this.printtoExcelBt.Text = "Print To Excel File";
            this.printtoExcelBt.UseVisualStyleBackColor = true;
            this.printtoExcelBt.Click += new System.EventHandler(this.printtoExcelBt_Click);
            // 
            // printtoPDFBt
            // 
            this.printtoPDFBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.printtoPDFBt.ForeColor = System.Drawing.Color.OrangeRed;
            this.printtoPDFBt.Location = new System.Drawing.Point(13, 507);
            this.printtoPDFBt.Name = "printtoPDFBt";
            this.printtoPDFBt.Size = new System.Drawing.Size(254, 36);
            this.printtoPDFBt.TabIndex = 18;
            this.printtoPDFBt.Text = "Print To PDF File";
            this.printtoPDFBt.UseVisualStyleBackColor = true;
            this.printtoPDFBt.Click += new System.EventHandler(this.printtoPDFBt_Click);
            // 
            // PrintScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 580);
            this.Controls.Add(this.printtoPDFBt);
            this.Controls.Add(this.printtoExcelBt);
            this.Controls.Add(this.printtoWordBt);
            this.Controls.Add(this.labelReset);
            this.Controls.Add(this.printTxtFileButton);
            this.Controls.Add(this.labelStudent);
            this.Controls.Add(this.dataGridViewStudent);
            this.Controls.Add(this.labelScoreList);
            this.Controls.Add(this.dataGridViewScore);
            this.Controls.Add(this.listBoxCourse);
            this.Controls.Add(this.labelCourseList);
            this.Name = "PrintScoreForm";
            this.Text = "Print Score";
            this.Load += new System.EventHandler(this.PrintScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReset;
        private System.Windows.Forms.Button printTxtFileButton;
        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.Label labelScoreList;
        private System.Windows.Forms.DataGridView dataGridViewScore;
        private System.Windows.Forms.ListBox listBoxCourse;
        private System.Windows.Forms.Label labelCourseList;
        private System.Windows.Forms.Button printtoWordBt;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button printtoExcelBt;
        private System.Windows.Forms.Button printtoPDFBt;
    }
}