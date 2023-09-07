using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace QLSV
{
    public partial class PrintCourseForm : Form
    {
        public PrintCourseForm()
        {
            InitializeComponent();
        }

        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSetCourse.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.qLSVDataSetCourse.Course);
            SqlCommand command = new SqlCommand("SELECT id as [Course ID], label as [Course Name], period [Period], description AS [Description], semester AS [Semester] FROM Course");
            fillGrid(command);

        }

        Score score = new Score();
        Course course = new Course();
        public void fillGrid(SqlCommand command)
        {
            CoursedataGridView.ReadOnly = true;
            CoursedataGridView.RowTemplate.Height = 80;
            CoursedataGridView.DataSource = course.getCourses(command);
            CoursedataGridView.AllowUserToAddRows = false;
        }


        private void saveFileTextButton_Click(object sender, EventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Course_List.txt";
            using (var writer = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                for (int i = 0; i < CoursedataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < CoursedataGridView.Columns.Count; j++)
                    {
                        if (j == CoursedataGridView.Columns.Count - 1)
                        {
                            writer.Write("\t" + CoursedataGridView.Rows[i].Cells[j].Value.ToString());
                        }
                        else
                        {
                            writer.Write("\t" + CoursedataGridView.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                        if (j == 3)
                        {
                            writer.Write("\t|");
                        }
                    }
                    writer.WriteLine();
                    writer.WriteLine("---------------------------------------------------------------------------------------------------");
                }
            }
            MessageBox.Show("Done", "Notification");
        }

        private void printtoWordBt_Click(object sender, EventArgs e)
        {
            CourseExport word = new CourseExport();
            if (CoursedataGridView.Rows.Count > 0)
            {
                try
                {
                    saveFileDialog1.Filter = "Word Documents (.docx)|.docx";
                    saveFileDialog1.FileName = ".docx";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        word.exportDataToWord(CoursedataGridView, saveFileDialog1.FileName);
                    }
                    MessageBox.Show("Data Exported Successfully !!!", "Notification");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Notification");
            }
        }

        private void printtoExcelBt_Click(object sender, EventArgs e)
        {
            CourseExport excel = new CourseExport();
            DataTable dt = (DataTable)CoursedataGridView.DataSource;
            if (CoursedataGridView.Rows.Count > 0)
            {
                try
                {
                    saveFileDialog1.Filter = "Excel (.xlsx)|.xlsx";
                    saveFileDialog1.FileName = ".xlsx";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        excel.exportDataToExcel(dt, "Course", "Courses List", saveFileDialog1.FileName);
                    }
                    MessageBox.Show("Data Exported Successfully !!!", "Notification");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Notification");
            }
        }

        private void printPdfbutton_Click(object sender, EventArgs e)
        {
            CourseExport export = new CourseExport();
            if (CoursedataGridView.Rows.Count > 0)
            {
                saveFileDialog1.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog1.FileName = ".pdf"; bool fileError = false;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        try
                        {
                            File.Delete(saveFileDialog1.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            export.exportDataToPDF(CoursedataGridView, saveFileDialog1.FileName);
                            MessageBox.Show("Data Exported Successfully !!!", "Notification");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error:" + ex.Message);
                        }
                    }
                }
            }
        }

        private void CoursedataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable table = course.getCourseByID(Convert.ToInt32(CoursedataGridView.CurrentRow.Cells[0].Value));
            PrintCourseStd printCourseStd = new PrintCourseStd();
            printCourseStd.DataGridstdinclass.DataSource = course.getStudentByCourse(Convert.ToInt32(CoursedataGridView.CurrentRow.Cells[0].Value));
            printCourseStd.lbCoursename.Text = "Course Name: "+table.Rows[0]["label"].ToString().Trim();
            printCourseStd.ShowDialog();
        }
    }
}
