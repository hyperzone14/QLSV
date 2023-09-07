namespace QLSV
{
    partial class PrintCourseStd
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
            this.DataGridstdinclass = new System.Windows.Forms.DataGridView();
            this.cancelBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbStd = new System.Windows.Forms.Label();
            this.lbCoursename = new System.Windows.Forms.Label();
            this.printtoWordBt = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridstdinclass)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridstdinclass
            // 
            this.DataGridstdinclass.AllowUserToAddRows = false;
            this.DataGridstdinclass.AllowUserToDeleteRows = false;
            this.DataGridstdinclass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridstdinclass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridstdinclass.Location = new System.Drawing.Point(12, 101);
            this.DataGridstdinclass.Name = "DataGridstdinclass";
            this.DataGridstdinclass.ReadOnly = true;
            this.DataGridstdinclass.RowHeadersWidth = 51;
            this.DataGridstdinclass.RowTemplate.Height = 24;
            this.DataGridstdinclass.Size = new System.Drawing.Size(879, 344);
            this.DataGridstdinclass.TabIndex = 1;
            // 
            // cancelBt
            // 
            this.cancelBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cancelBt.Location = new System.Drawing.Point(574, 451);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(167, 55);
            this.cancelBt.TabIndex = 2;
            this.cancelBt.Text = "Cancel";
            this.cancelBt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(247, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student In Class";
            // 
            // lbStd
            // 
            this.lbStd.AutoSize = true;
            this.lbStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbStd.Location = new System.Drawing.Point(569, 73);
            this.lbStd.Name = "lbStd";
            this.lbStd.Size = new System.Drawing.Size(266, 25);
            this.lbStd.TabIndex = 5;
            this.lbStd.Text = "Total Student in Course: 0";
            // 
            // lbCoursename
            // 
            this.lbCoursename.AutoSize = true;
            this.lbCoursename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCoursename.Location = new System.Drawing.Point(12, 73);
            this.lbCoursename.Name = "lbCoursename";
            this.lbCoursename.Size = new System.Drawing.Size(232, 25);
            this.lbCoursename.TabIndex = 6;
            this.lbCoursename.Text = "Course Name: XXXXX";
            // 
            // printtoWordBt
            // 
            this.printtoWordBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.printtoWordBt.ForeColor = System.Drawing.Color.Blue;
            this.printtoWordBt.Location = new System.Drawing.Point(195, 451);
            this.printtoWordBt.Name = "printtoWordBt";
            this.printtoWordBt.Size = new System.Drawing.Size(256, 55);
            this.printtoWordBt.TabIndex = 18;
            this.printtoWordBt.Text = "Print To Word File";
            this.printtoWordBt.UseVisualStyleBackColor = true;
            this.printtoWordBt.Click += new System.EventHandler(this.printtoWordBt_Click);
            // 
            // PrintCourseStd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 518);
            this.Controls.Add(this.printtoWordBt);
            this.Controls.Add(this.lbCoursename);
            this.Controls.Add(this.lbStd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBt);
            this.Controls.Add(this.DataGridstdinclass);
            this.Name = "PrintCourseStd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintCourseStd";
            this.Load += new System.EventHandler(this.PrintCourseStd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridstdinclass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbStd;
        private System.Windows.Forms.Button printtoWordBt;
        public System.Windows.Forms.DataGridView DataGridstdinclass;
        public System.Windows.Forms.Label lbCoursename;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}