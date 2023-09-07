namespace QLSV
{
    partial class AvgByScore
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageScoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSetAvgScore1 = new QLSV.QLSVDataSetAvgScore();
            this.averageScoreTableAdapter = new QLSV.QLSVDataSetAvgScoreTableAdapters.AverageScoreTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.averageScoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSetAvgScore1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.labelDataGridViewTextBoxColumn,
            this.averageGradeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.averageScoreBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(418, 424);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelDataGridViewTextBoxColumn
            // 
            this.labelDataGridViewTextBoxColumn.DataPropertyName = "label";
            this.labelDataGridViewTextBoxColumn.HeaderText = "Course Name";
            this.labelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.labelDataGridViewTextBoxColumn.Name = "labelDataGridViewTextBoxColumn";
            this.labelDataGridViewTextBoxColumn.Width = 125;
            // 
            // averageGradeDataGridViewTextBoxColumn
            // 
            this.averageGradeDataGridViewTextBoxColumn.DataPropertyName = "AverageGrade";
            this.averageGradeDataGridViewTextBoxColumn.HeaderText = "AverageGrade";
            this.averageGradeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.averageGradeDataGridViewTextBoxColumn.Name = "averageGradeDataGridViewTextBoxColumn";
            this.averageGradeDataGridViewTextBoxColumn.ReadOnly = true;
            this.averageGradeDataGridViewTextBoxColumn.Width = 125;
            // 
            // averageScoreBindingSource
            // 
            this.averageScoreBindingSource.DataMember = "AverageScore";
            this.averageScoreBindingSource.DataSource = this.qLSVDataSetAvgScore1;
            // 
            // qLSVDataSetAvgScore1
            // 
            this.qLSVDataSetAvgScore1.DataSetName = "QLSVDataSetAvgScore";
            this.qLSVDataSetAvgScore1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // averageScoreTableAdapter
            // 
            this.averageScoreTableAdapter.ClearBeforeFill = true;
            // 
            // AvgByScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 424);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AvgByScore";
            this.Text = "AvgByScore";
            this.Load += new System.EventHandler(this.AvgByScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.averageScoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSetAvgScore1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLSVDataSetAvgScore qLSVDataSetAvgScore1;
        private System.Windows.Forms.BindingSource averageScoreBindingSource;
        private QLSVDataSetAvgScoreTableAdapters.AverageScoreTableAdapter averageScoreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn labelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageGradeDataGridViewTextBoxColumn;
    }
}