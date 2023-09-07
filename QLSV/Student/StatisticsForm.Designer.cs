namespace QLSV
{
    partial class StatisticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.lblMale = new System.Windows.Forms.Label();
            this.lblFemale = new System.Windows.Forms.Label();
            this.panTotalStudent = new System.Windows.Forms.Panel();
            this.panTotalMaleStudent = new System.Windows.Forms.Panel();
            this.panTotalFemaleStudent = new System.Windows.Forms.Panel();
            this.genderStudentChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panTotalStudent.SuspendLayout();
            this.panTotalMaleStudent.SuspendLayout();
            this.panTotalFemaleStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genderStudentChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStudents.ForeColor = System.Drawing.Color.White;
            this.lblTotalStudents.Location = new System.Drawing.Point(113, 51);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(135, 25);
            this.lblTotalStudents.TabIndex = 0;
            this.lblTotalStudents.Text = "Total Student:";
            // 
            // lblMale
            // 
            this.lblMale.AutoSize = true;
            this.lblMale.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMale.ForeColor = System.Drawing.Color.White;
            this.lblMale.Location = new System.Drawing.Point(11, 37);
            this.lblMale.Name = "lblMale";
            this.lblMale.Size = new System.Drawing.Size(58, 25);
            this.lblMale.TabIndex = 1;
            this.lblMale.Text = "Male:";
            // 
            // lblFemale
            // 
            this.lblFemale.AutoSize = true;
            this.lblFemale.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFemale.ForeColor = System.Drawing.Color.White;
            this.lblFemale.Location = new System.Drawing.Point(17, 37);
            this.lblFemale.Name = "lblFemale";
            this.lblFemale.Size = new System.Drawing.Size(76, 25);
            this.lblFemale.TabIndex = 2;
            this.lblFemale.Text = "Female:";
            // 
            // panTotalStudent
            // 
            this.panTotalStudent.BackColor = System.Drawing.Color.LimeGreen;
            this.panTotalStudent.Controls.Add(this.lblTotalStudents);
            this.panTotalStudent.Location = new System.Drawing.Point(1, -4);
            this.panTotalStudent.Name = "panTotalStudent";
            this.panTotalStudent.Size = new System.Drawing.Size(396, 123);
            this.panTotalStudent.TabIndex = 3;
            this.panTotalStudent.MouseEnter += new System.EventHandler(this.LabelTotal_MouseEnter);
            this.panTotalStudent.MouseLeave += new System.EventHandler(this.LabelTotal_MouseLeave);
            // 
            // panTotalMaleStudent
            // 
            this.panTotalMaleStudent.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panTotalMaleStudent.Controls.Add(this.lblMale);
            this.panTotalMaleStudent.Location = new System.Drawing.Point(1, 125);
            this.panTotalMaleStudent.Name = "panTotalMaleStudent";
            this.panTotalMaleStudent.Size = new System.Drawing.Size(197, 100);
            this.panTotalMaleStudent.TabIndex = 4;
            this.panTotalMaleStudent.MouseLeave += new System.EventHandler(this.LabelMale_MouseLeave);
            this.panTotalMaleStudent.MouseHover += new System.EventHandler(this.LabelMale_MouseEnter);
            // 
            // panTotalFemaleStudent
            // 
            this.panTotalFemaleStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panTotalFemaleStudent.Controls.Add(this.lblFemale);
            this.panTotalFemaleStudent.Location = new System.Drawing.Point(200, 125);
            this.panTotalFemaleStudent.Name = "panTotalFemaleStudent";
            this.panTotalFemaleStudent.Size = new System.Drawing.Size(197, 100);
            this.panTotalFemaleStudent.TabIndex = 5;
            this.panTotalFemaleStudent.Paint += new System.Windows.Forms.PaintEventHandler(this.panTotalFemaleStudent_Paint);
            this.panTotalFemaleStudent.MouseEnter += new System.EventHandler(this.LabelFemale_MouseEnter);
            this.panTotalFemaleStudent.MouseLeave += new System.EventHandler(this.LabelFemale_MouseLeave);
            // 
            // genderStudentChart
            // 
            chartArea1.Name = "ChartArea1";
            this.genderStudentChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.genderStudentChart.Legends.Add(legend1);
            this.genderStudentChart.Location = new System.Drawing.Point(1, 225);
            this.genderStudentChart.Name = "genderStudentChart";
            this.genderStudentChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Gender";
            this.genderStudentChart.Series.Add(series1);
            this.genderStudentChart.Size = new System.Drawing.Size(396, 229);
            this.genderStudentChart.TabIndex = 6;
            this.genderStudentChart.Text = "chart1";
            // 
            // StaticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 457);
            this.Controls.Add(this.genderStudentChart);
            this.Controls.Add(this.panTotalFemaleStudent);
            this.Controls.Add(this.panTotalMaleStudent);
            this.Controls.Add(this.panTotalStudent);
            this.Name = "StaticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaticsForm";
            this.Load += new System.EventHandler(this.StaticsForm_Load);
            this.panTotalStudent.ResumeLayout(false);
            this.panTotalStudent.PerformLayout();
            this.panTotalMaleStudent.ResumeLayout(false);
            this.panTotalMaleStudent.PerformLayout();
            this.panTotalFemaleStudent.ResumeLayout(false);
            this.panTotalFemaleStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genderStudentChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Label lblMale;
        private System.Windows.Forms.Label lblFemale;
        private System.Windows.Forms.Panel panTotalStudent;
        private System.Windows.Forms.Panel panTotalMaleStudent;
        private System.Windows.Forms.Panel panTotalFemaleStudent;
        private System.Windows.Forms.DataVisualization.Charting.Chart genderStudentChart;
    }
}