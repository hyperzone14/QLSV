namespace QLSV
{
    partial class PrintCourseForm
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
            this.CoursedataGridView = new System.Windows.Forms.DataGridView();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSetCourse = new QLSV.QLSVDataSetCourse();
            this.saveFileTextButton = new System.Windows.Forms.Button();
            this.courseTableAdapter = new QLSV.QLSVDataSetCourseTableAdapters.CourseTableAdapter();
            this.printtoWordBt = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printtoExcelBt = new System.Windows.Forms.Button();
            this.printPdfbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CoursedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSetCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // CoursedataGridView
            // 
            this.CoursedataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CoursedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoursedataGridView.Location = new System.Drawing.Point(12, 12);
            this.CoursedataGridView.Name = "CoursedataGridView";
            this.CoursedataGridView.RowHeadersWidth = 51;
            this.CoursedataGridView.RowTemplate.Height = 24;
            this.CoursedataGridView.Size = new System.Drawing.Size(1000, 388);
            this.CoursedataGridView.TabIndex = 0;
            this.CoursedataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CoursedataGridView_CellDoubleClick);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.qLSVDataSetCourse;
            // 
            // qLSVDataSetCourse
            // 
            this.qLSVDataSetCourse.DataSetName = "QLSVDataSetCourse";
            this.qLSVDataSetCourse.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saveFileTextButton
            // 
            this.saveFileTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.saveFileTextButton.Location = new System.Drawing.Point(838, 406);
            this.saveFileTextButton.Name = "saveFileTextButton";
            this.saveFileTextButton.Size = new System.Drawing.Size(164, 36);
            this.saveFileTextButton.TabIndex = 1;
            this.saveFileTextButton.Text = "Print Text File";
            this.saveFileTextButton.UseVisualStyleBackColor = true;
            this.saveFileTextButton.Click += new System.EventHandler(this.saveFileTextButton_Click);
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // printtoWordBt
            // 
            this.printtoWordBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.printtoWordBt.ForeColor = System.Drawing.Color.Blue;
            this.printtoWordBt.Location = new System.Drawing.Point(567, 406);
            this.printtoWordBt.Name = "printtoWordBt";
            this.printtoWordBt.Size = new System.Drawing.Size(254, 36);
            this.printtoWordBt.TabIndex = 17;
            this.printtoWordBt.Text = "Print To Word File";
            this.printtoWordBt.UseVisualStyleBackColor = true;
            this.printtoWordBt.Click += new System.EventHandler(this.printtoWordBt_Click);
            // 
            // printtoExcelBt
            // 
            this.printtoExcelBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.printtoExcelBt.ForeColor = System.Drawing.Color.Green;
            this.printtoExcelBt.Location = new System.Drawing.Point(12, 406);
            this.printtoExcelBt.Name = "printtoExcelBt";
            this.printtoExcelBt.Size = new System.Drawing.Size(254, 36);
            this.printtoExcelBt.TabIndex = 18;
            this.printtoExcelBt.Text = "Print To Excel File";
            this.printtoExcelBt.UseVisualStyleBackColor = true;
            this.printtoExcelBt.Click += new System.EventHandler(this.printtoExcelBt_Click);
            // 
            // printPdfbutton
            // 
            this.printPdfbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.printPdfbutton.ForeColor = System.Drawing.Color.Red;
            this.printPdfbutton.Location = new System.Drawing.Point(289, 406);
            this.printPdfbutton.Name = "printPdfbutton";
            this.printPdfbutton.Size = new System.Drawing.Size(254, 36);
            this.printPdfbutton.TabIndex = 19;
            this.printPdfbutton.Text = "Print To PDF File";
            this.printPdfbutton.UseVisualStyleBackColor = true;
            this.printPdfbutton.Click += new System.EventHandler(this.printPdfbutton_Click);
            // 
            // PrintCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 452);
            this.Controls.Add(this.printPdfbutton);
            this.Controls.Add(this.printtoExcelBt);
            this.Controls.Add(this.printtoWordBt);
            this.Controls.Add(this.saveFileTextButton);
            this.Controls.Add(this.CoursedataGridView);
            this.Name = "PrintCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Course";
            this.Load += new System.EventHandler(this.PrintCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CoursedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSetCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button saveFileTextButton;
        private QLSVDataSetCourse qLSVDataSetCourse;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private QLSVDataSetCourseTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.Button printtoWordBt;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button printtoExcelBt;
        private System.Windows.Forms.Button printPdfbutton;
        public System.Windows.Forms.DataGridView CoursedataGridView;
    }
}