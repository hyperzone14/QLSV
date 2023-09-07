namespace QLSV
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuStudentTool = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.studentListForm = new System.Windows.Forms.ToolStripMenuItem();
            this.staticsForm = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteStudentForm = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentForm = new System.Windows.Forms.ToolStripMenuItem();
            this.printerForm = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseForm = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCourseForm = new System.Windows.Forms.ToolStripMenuItem();
            this.editCourseForm = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCoursesForm = new System.Windows.Forms.ToolStripMenuItem();
            this.printForm = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avgScoreByCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avgResultsByScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printScoreAllStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStudentTool,
            this.courseToolStripMenuItem,
            this.scoreToolStripMenuItem,
            this.resultToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuStudentTool
            // 
            this.MenuStudentTool.BackColor = System.Drawing.Color.Transparent;
            this.MenuStudentTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudent,
            this.studentListForm,
            this.staticsForm,
            this.updateDeleteStudentForm,
            this.manageStudentForm,
            this.printerForm,
            this.quitToolStripMenuItem});
            this.MenuStudentTool.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStudentTool.Name = "MenuStudentTool";
            this.MenuStudentTool.Size = new System.Drawing.Size(80, 24);
            this.MenuStudentTool.Text = "Student";
            // 
            // addNewStudent
            // 
            this.addNewStudent.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addNewStudent.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewStudent.ForeColor = System.Drawing.Color.White;
            this.addNewStudent.Name = "addNewStudent";
            this.addNewStudent.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addNewStudent.Size = new System.Drawing.Size(301, 26);
            this.addNewStudent.Text = "Add New Student";
            this.addNewStudent.Click += new System.EventHandler(this.addNewStudent_Click);
            // 
            // studentListForm
            // 
            this.studentListForm.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.studentListForm.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentListForm.ForeColor = System.Drawing.Color.White;
            this.studentListForm.Name = "studentListForm";
            this.studentListForm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.studentListForm.Size = new System.Drawing.Size(301, 26);
            this.studentListForm.Text = "Student List";
            this.studentListForm.Click += new System.EventHandler(this.studentListForm_Click);
            // 
            // staticsForm
            // 
            this.staticsForm.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.staticsForm.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticsForm.ForeColor = System.Drawing.Color.White;
            this.staticsForm.Name = "staticsForm";
            this.staticsForm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.staticsForm.Size = new System.Drawing.Size(301, 26);
            this.staticsForm.Text = "Statics";
            this.staticsForm.Click += new System.EventHandler(this.StaticsForm_Click);
            // 
            // updateDeleteStudentForm
            // 
            this.updateDeleteStudentForm.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.updateDeleteStudentForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.updateDeleteStudentForm.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDeleteStudentForm.ForeColor = System.Drawing.Color.White;
            this.updateDeleteStudentForm.Name = "updateDeleteStudentForm";
            this.updateDeleteStudentForm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.updateDeleteStudentForm.Size = new System.Drawing.Size(301, 26);
            this.updateDeleteStudentForm.Text = "Edit / Remove";
            this.updateDeleteStudentForm.Click += new System.EventHandler(this.UpdateDeleteStudentForm_Click);
            // 
            // manageStudentForm
            // 
            this.manageStudentForm.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.manageStudentForm.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageStudentForm.ForeColor = System.Drawing.Color.White;
            this.manageStudentForm.Name = "manageStudentForm";
            this.manageStudentForm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.manageStudentForm.Size = new System.Drawing.Size(301, 26);
            this.manageStudentForm.Text = "Manage Student Form";
            this.manageStudentForm.Click += new System.EventHandler(this.ManageStudentForm_Click);
            // 
            // printerForm
            // 
            this.printerForm.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.printerForm.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printerForm.ForeColor = System.Drawing.Color.White;
            this.printerForm.Name = "printerForm";
            this.printerForm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printerForm.Size = new System.Drawing.Size(301, 26);
            this.printerForm.Text = "Print";
            this.printerForm.Click += new System.EventHandler(this.PrinterForm_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.quitToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseForm,
            this.removeCourseForm,
            this.editCourseForm,
            this.manageCoursesForm,
            this.printForm});
            this.courseToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.courseToolStripMenuItem.Text = "Course";
            // 
            // addCourseForm
            // 
            this.addCourseForm.BackColor = System.Drawing.Color.Goldenrod;
            this.addCourseForm.ForeColor = System.Drawing.Color.White;
            this.addCourseForm.Name = "addCourseForm";
            this.addCourseForm.Size = new System.Drawing.Size(203, 26);
            this.addCourseForm.Text = "Add Course";
            this.addCourseForm.Click += new System.EventHandler(this.addCourseForm_Click);
            // 
            // removeCourseForm
            // 
            this.removeCourseForm.BackColor = System.Drawing.Color.Goldenrod;
            this.removeCourseForm.ForeColor = System.Drawing.Color.White;
            this.removeCourseForm.Name = "removeCourseForm";
            this.removeCourseForm.Size = new System.Drawing.Size(203, 26);
            this.removeCourseForm.Text = "Remove Course";
            this.removeCourseForm.Click += new System.EventHandler(this.removeCourseForm_Click);
            // 
            // editCourseForm
            // 
            this.editCourseForm.BackColor = System.Drawing.Color.Goldenrod;
            this.editCourseForm.ForeColor = System.Drawing.Color.White;
            this.editCourseForm.Name = "editCourseForm";
            this.editCourseForm.Size = new System.Drawing.Size(203, 26);
            this.editCourseForm.Text = "Edit Course";
            this.editCourseForm.Click += new System.EventHandler(this.editCourseForm_Click);
            // 
            // manageCoursesForm
            // 
            this.manageCoursesForm.BackColor = System.Drawing.Color.Goldenrod;
            this.manageCoursesForm.ForeColor = System.Drawing.Color.White;
            this.manageCoursesForm.Name = "manageCoursesForm";
            this.manageCoursesForm.Size = new System.Drawing.Size(203, 26);
            this.manageCoursesForm.Text = "Manage Courses";
            this.manageCoursesForm.Click += new System.EventHandler(this.manageCoursesForm_Click);
            // 
            // printForm
            // 
            this.printForm.BackColor = System.Drawing.Color.Goldenrod;
            this.printForm.ForeColor = System.Drawing.Color.White;
            this.printForm.Name = "printForm";
            this.printForm.Size = new System.Drawing.Size(203, 26);
            this.printForm.Text = "Print";
            this.printForm.Click += new System.EventHandler(this.printForm_Click);
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addScoreToolStripMenuItem,
            this.removeScoreToolStripMenuItem,
            this.manageScoreToolStripMenuItem,
            this.avgScoreByCourseToolStripMenuItem,
            this.printToolStripMenuItem,
            this.printScoreAllStudentToolStripMenuItem});
            this.scoreToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.scoreToolStripMenuItem.Text = "Score";
            // 
            // addScoreToolStripMenuItem
            // 
            this.addScoreToolStripMenuItem.BackColor = System.Drawing.Color.LimeGreen;
            this.addScoreToolStripMenuItem.Name = "addScoreToolStripMenuItem";
            this.addScoreToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.addScoreToolStripMenuItem.Text = "Add Score";
            this.addScoreToolStripMenuItem.Click += new System.EventHandler(this.addScoreToolStripMenuItem_Click);
            // 
            // removeScoreToolStripMenuItem
            // 
            this.removeScoreToolStripMenuItem.BackColor = System.Drawing.Color.LimeGreen;
            this.removeScoreToolStripMenuItem.Name = "removeScoreToolStripMenuItem";
            this.removeScoreToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.removeScoreToolStripMenuItem.Text = "Remove Score";
            this.removeScoreToolStripMenuItem.Click += new System.EventHandler(this.removeScoreToolStripMenuItem_Click);
            // 
            // manageScoreToolStripMenuItem
            // 
            this.manageScoreToolStripMenuItem.BackColor = System.Drawing.Color.LimeGreen;
            this.manageScoreToolStripMenuItem.Name = "manageScoreToolStripMenuItem";
            this.manageScoreToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.manageScoreToolStripMenuItem.Text = "Manage Score";
            this.manageScoreToolStripMenuItem.Click += new System.EventHandler(this.manageScoreToolStripMenuItem_Click);
            // 
            // avgScoreByCourseToolStripMenuItem
            // 
            this.avgScoreByCourseToolStripMenuItem.BackColor = System.Drawing.Color.LimeGreen;
            this.avgScoreByCourseToolStripMenuItem.Name = "avgScoreByCourseToolStripMenuItem";
            this.avgScoreByCourseToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.avgScoreByCourseToolStripMenuItem.Text = "Avg Score By Course";
            this.avgScoreByCourseToolStripMenuItem.Click += new System.EventHandler(this.avgScoreByCourseToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.BackColor = System.Drawing.Color.LimeGreen;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // resultToolStripMenuItem
            // 
            this.resultToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avgResultsByScoreToolStripMenuItem,
            this.staticResultToolStripMenuItem});
            this.resultToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultToolStripMenuItem.Name = "resultToolStripMenuItem";
            this.resultToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.resultToolStripMenuItem.Text = "Result";
            // 
            // avgResultsByScoreToolStripMenuItem
            // 
            this.avgResultsByScoreToolStripMenuItem.BackColor = System.Drawing.Color.Violet;
            this.avgResultsByScoreToolStripMenuItem.Name = "avgResultsByScoreToolStripMenuItem";
            this.avgResultsByScoreToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.avgResultsByScoreToolStripMenuItem.Text = "Avg Results By Score";
            this.avgResultsByScoreToolStripMenuItem.Click += new System.EventHandler(this.avgResultsByScoreToolStripMenuItem_Click);
            // 
            // staticResultToolStripMenuItem
            // 
            this.staticResultToolStripMenuItem.BackColor = System.Drawing.Color.Violet;
            this.staticResultToolStripMenuItem.Name = "staticResultToolStripMenuItem";
            this.staticResultToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.staticResultToolStripMenuItem.Text = "Static Result";
            this.staticResultToolStripMenuItem.Click += new System.EventHandler(this.staticResultToolStripMenuItem_Click);
            // 
            // printScoreAllStudentToolStripMenuItem
            // 
            this.printScoreAllStudentToolStripMenuItem.BackColor = System.Drawing.Color.LimeGreen;
            this.printScoreAllStudentToolStripMenuItem.Name = "printScoreAllStudentToolStripMenuItem";
            this.printScoreAllStudentToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.printScoreAllStudentToolStripMenuItem.Text = "Print Score All Student";
            this.printScoreAllStudentToolStripMenuItem.Click += new System.EventHandler(this.printScoreAllStudentToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuStudentTool;
        private System.Windows.Forms.ToolStripMenuItem addNewStudent;
        private System.Windows.Forms.ToolStripMenuItem studentListForm;
        private System.Windows.Forms.ToolStripMenuItem staticsForm;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteStudentForm;
        private System.Windows.Forms.ToolStripMenuItem manageStudentForm;
        private System.Windows.Forms.ToolStripMenuItem printerForm;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseForm;
        private System.Windows.Forms.ToolStripMenuItem removeCourseForm;
        private System.Windows.Forms.ToolStripMenuItem editCourseForm;
        private System.Windows.Forms.ToolStripMenuItem manageCoursesForm;
        private System.Windows.Forms.ToolStripMenuItem printForm;
        private System.Windows.Forms.ToolStripMenuItem addScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avgScoreByCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avgResultsByScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printScoreAllStudentToolStripMenuItem;
    }
}