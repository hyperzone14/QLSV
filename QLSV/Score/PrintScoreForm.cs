using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace QLSV
{
    public partial class PrintScoreForm : Form
    {
        public PrintScoreForm()
        {
            InitializeComponent();
        }
        Score score = new Score();
        Course course = new Course();
        Student student = new Student();
        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            dataGridViewStudent.DataSource = student.getStudents(new SqlCommand("Select id,fname,lname From std"));
            dataGridViewStudent.Columns[0].HeaderText = "Student ID";
            dataGridViewStudent.Columns[1].HeaderText = "First Name";
            dataGridViewStudent.Columns[2].HeaderText = "Last Name";
            dataGridViewScore.ReadOnly = true;
            dataGridViewScore.RowTemplate.Height = 80;

            dataGridViewScore.DataSource = score.getScore();
            dataGridViewScore.Columns[0].HeaderText = "Student ID";
            dataGridViewScore.Columns[1].HeaderText = "First Name";
            dataGridViewScore.Columns[2].HeaderText = "Last Name";
            dataGridViewScore.Columns[3].HeaderText = "Course ID";
            dataGridViewScore.Columns[4].HeaderText = "Course Name";
            dataGridViewScore.Columns[5].HeaderText = "Score";
            dataGridViewScore.Columns[6].HeaderText = "Description";
            dataGridViewScore.AllowUserToAddRows = false;
            listBoxCourse.DataSource = course.getAllCourses();
            listBoxCourse.DisplayMember = "label";
            listBoxCourse.ValueMember = "id";
        }

        private void listBoxCourse_Click(object sender, EventArgs e)
        {
            dataGridViewScore.DataSource = score.getCourseScores(int.Parse(listBoxCourse.SelectedValue.ToString()));
        }

        private void dataGridViewScore_Click(object sender, EventArgs e)
        {
           
        }
        private void labelReset_Click(object sender, EventArgs e)
        {
            dataGridViewScore.DataSource = score.getScore();
            dataGridViewScore.Columns[0].HeaderText = "Student ID";
            dataGridViewScore.Columns[1].HeaderText = "First Name";
            dataGridViewScore.Columns[2].HeaderText = "Last Name";
            dataGridViewScore.Columns[3].HeaderText = "Course ID";
            dataGridViewScore.Columns[4].HeaderText = "Course Name";
            dataGridViewScore.Columns[5].HeaderText = "Score";
            dataGridViewScore.Columns[6].HeaderText = "Description";
        }

        private void printTxtFileButton_Click(object sender, EventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Score_List.txt";
            using (var writer = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                for (int i = 0; i < dataGridViewScore.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewScore.Columns.Count; j++)
                    {
                        writer.Write("\t" + dataGridViewScore.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    }
                    writer.WriteLine();
                    writer.WriteLine("---------------------------------------------------------------------------------------------------");

                }
            }
            MessageBox.Show("Done", "Notification");
        }

        private void dataGridViewStudent_Click(object sender, EventArgs e)
        {
            dataGridViewScore.DataSource = score.getStudentScores(int.Parse(dataGridViewStudent.CurrentRow.Cells[0].Value.ToString()));
        }

        private void printtoWordBt_Click(object sender, EventArgs e)
        {
            ScoreExport word = new ScoreExport();
            if (dataGridViewScore.Rows.Count > 0)
            {
                try
                {
                    saveFileDialog1.Filter = "Word Documents (.docx)|.docx";
                    saveFileDialog1.FileName = ".docx";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        word.exportDataToWord(dataGridViewScore , saveFileDialog1.FileName);
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
            ScoreExport excel = new ScoreExport();
            DataTable dt = (DataTable)dataGridViewScore.DataSource;
            if (dataGridViewScore.Rows.Count > 0)
            {
                try
                {
                    saveFileDialog1.Filter = "Excel (.xlsx)|.xlsx";
                    saveFileDialog1.FileName = ".xlsx";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        excel.exportDataToExcel(dt, "Score", "Score List", saveFileDialog1.FileName);
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

        private void printtoPDFBt_Click(object sender, EventArgs e)
        {
            ScoreExport export = new ScoreExport();
            if (dataGridViewScore.Rows.Count > 0)
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
                            export.exportDataToPDF(dataGridViewScore, saveFileDialog1.FileName);
                            MessageBox.Show("Data Exported Successfully !!!", "Notification");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error:" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Notification");
            }
        }
    }
}
