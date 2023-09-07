using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm quit = new LoginForm();
            quit.Show();
        }

        private void addNewStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm newstd = new AddStudentForm();
            newstd.Show(this);
        }

        private void studentListForm_Click(object sender, EventArgs e)
        {
            StudentListForm liststd = new StudentListForm();
            liststd.Show(this);
        }

        private void UpdateDeleteStudentForm_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updatedelete = new UpdateDeleteStudentForm();
            updatedelete.Show(this);
        }

        private void StaticsForm_Click(object sender, EventArgs e)
        {
            StatisticsForm statics = new StatisticsForm();
            statics.Show(this);
        }

        private void PrinterForm_Click(object sender, EventArgs e)
        {
            PrintStudentForm print = new PrintStudentForm(); ;
            print.Show(this);
        }

        private void ManageStudentForm_Click(object sender, EventArgs e)
        {
            ManageStudentForm manage = new ManageStudentForm();
            manage.Show(this);
        }

        private void editCourseForm_Click(object sender, EventArgs e)
        {
            EditCourseForm edit = new EditCourseForm();
            edit.Show(this);
        }

        private void addCourseForm_Click(object sender, EventArgs e)
        {
            AddCourseForm add = new AddCourseForm();
            add.Show(this); 
        }

        private void removeCourseForm_Click(object sender, EventArgs e)
        {
            RemoveCourseForm remove = new RemoveCourseForm();
            remove.Show(this);
        }

        private void manageCoursesForm_Click(object sender, EventArgs e)
        {
            ManageCourseForm manage = new ManageCourseForm();
            manage.Show(this);
        }

        private void printForm_Click(object sender, EventArgs e)
        {
            PrintCourseForm printCourse = new PrintCourseForm();
            printCourse.Show(this); 
        }

        private void avgScoreByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvgByScore avg = new AvgByScore();
            avg.Show(this);
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm addscore = new AddScoreForm();
            addscore.Show();
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScoreForm deletescore = new RemoveScoreForm();
            deletescore.Show();
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScoreForm manageScoreForm = new ManageScoreForm();
            manageScoreForm.Show(this);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintScoreForm printScoreForm = new PrintScoreForm();
            printScoreForm.Show(this);
        }

        private void avgResultsByScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvgResultByScoreForm avgResultByScoreForm = new AvgResultByScoreForm();
            avgResultByScoreForm.Show(this);
        }

        private void staticResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticsResult staticResult = new StatisticsResult();
            staticResult.Show(this);
        }
     
        private void printScoreAllStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestReportForm testReportForm = new TestReportForm();
            testReportForm.Show(this);
        }
    }
}
