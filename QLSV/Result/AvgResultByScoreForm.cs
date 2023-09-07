using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace QLSV
{
    public partial class AvgResultByScoreForm : Form
    {
        ScoreExport export = new ScoreExport();
        DataTable table = new DataTable();
        Student student = new Student();
        SqlCommand command;
        public AvgResultByScoreForm()
        {
            InitializeComponent();
            
            dataGridView2.Hide();
        }
        private void AVGResultByScoreForm_Load(object sender, EventArgs e)
        {
            string coursename = insert_co();
            string cmd = "SELECT studentid as [Student ID], fname as [First Name], lname as [Last Name], " + coursename + "  ,ROUND(GOOD.[Average Score],2) AS [Average Score] FROM(Select * FROM(select  DTB.[label], DTB.score, fname, lname, id from(Select[label],[studentid], courseid, score From score Inner JOIN  Course on courseid = id Group by score, courseid, [label], studentid)as DTB Inner JOIN std on DTB.studentid = id) as OK PIVOT(SUM(score) FOR OK.[label] IN( " + coursename + ")) AS PVTTable)AS MUCH INNER JOIN(Select studentid, AVG(score.score) AS [Average Score] FROM score Group by studentid) AS GOOD ON studentid = MUCH.id";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            command = new SqlCommand(cmd);
            dataGridView1.DataSource = student.getStudents(command);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns.Add("Result", "Result");
            int end = dataGridView1.Columns.Count;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToDouble(dataGridView1.Rows[i].Cells[end - 2].Value) >= 5)
                    dataGridView1.Rows[i].Cells[end - 1].Value = "Passed";
                else
                    dataGridView1.Rows[i].Cells[end - 1].Value = "Failed";

            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            
        }
        int temp;
        Course course = new Course();
        //id mon,ten mon, diem
        private string insert_co()
        {
            string str2 = "select [label] from course";
            string chuoi = "";
            SqlCommand cmd = new SqlCommand(str2);
            DataGridView dataload = new DataGridView();
            dataGridView1.DataSource = course.getCourses(cmd);
            dataload.DataSource = course.getCourses(cmd);
            temp = dataGridView1.RowCount - 1;
            for (int i = 0; i < temp; i++)
            {
                chuoi = chuoi + "[" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "], ";
            }
            chuoi += "[" + dataGridView1.Rows[temp].Cells[0].Value.ToString() + "]";
            //MessageBox.Show(chuoi);
            return chuoi;
        }
        private void searchButton_Click(object sender, EventArgs e)
        {         
            string coursename = insert_co();        
            string cmd =   "SELECT  studentid as [Student ID],fname as [First Name], lname as [Last Name], " + coursename + " ,ROUND(GOOD.[Average Score],2) AS [Average Score]  FROM(Select * FROM(select  DTB.[label], DTB.score, fname, lname, id from(Select[label],[studentid], courseid, score From score Inner JOIN  Course on courseid = id Group by score, courseid, [label], studentid) as DTB Inner JOIN std on DTB.studentid = id) as OK PIVOT(SUM(score) FOR OK.[label] IN( " + coursename + ")) AS PVTTable) AS MUCH INNER JOIN (Select studentid, AVG(score.score) AS [Average Score] FROM score Group by studentid) AS GOOD ON studentid = MUCH.id WHERE CONCAT(studentid,fname,lname) LIKE '%" + txtSearchBox.Text + "%'";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            SqlCommand command = new SqlCommand(cmd);
            dataGridView1.DataSource = student.getStudents(command);
            dataGridView1.AllowUserToAddRows = false;

            table = student.getStudents(command);
            dataGridView1.DataSource = table;
            table.Columns.Add("Result");
            int end1 = dataGridView1.Columns.Count;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToDouble(dataGridView1.Rows[i].Cells[end1 - 2].Value) >= 5)
                {
                    table.Rows[i]["Result"] = "Pass";
                }
                else
                {
                    table.Rows[i]["Result"] = "Failed";
                }
            }
            dataGridView1.Columns.RemoveAt(0);
            if (table.Rows.Count > 0)
            {
                int end = dataGridView1.Columns.Count;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (Convert.ToDouble(dataGridView1.Rows[i].Cells[end - 2].Value) >= 5)
                    {
                        table.Rows[i]["Result"] = "Pass";
                        dataGridView1.Rows[i].Cells[end - 1].Value = table.Rows[i]["Result"].ToString();
                    }
                    else
                    {
                        table.Rows[i]["Result"] = "Failed";
                        dataGridView1.Rows[i].Cells[end - 1].Value = table.Rows[i]["Result"].ToString();
                    }
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = table;
        }
        private void printButton_Click(object sender, EventArgs e)
        {
            TestReportForm testReportForm = new TestReportForm();
            testReportForm.Show();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtStudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBoxFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtBoxLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
           
        }
        
        private void printWordBt_Click(object sender, EventArgs e)
        {
            ResultExport word = new ResultExport();
            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    saveFileDialog1.Filter = "Word Documents (.docx)|.docx";
                    saveFileDialog1.FileName = ".docx";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        word.exportDataToWord(dataGridView1, saveFileDialog1.FileName);
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

        private void printExcelbt_Click(object sender, EventArgs e)
        {
            ResultExport excel = new ResultExport();
            DataTable dt = (DataTable)dataGridView1.DataSource;
            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    saveFileDialog1.Filter = "Excel (.xlsx)|.xlsx";
                    saveFileDialog1.FileName = ".xlsx";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        excel.exportDataToExcel(dt, "Result", "Result Student List", saveFileDialog1.FileName);
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
        
        string path = @"C:\Users\Nam\OneDrive\Desktop\ĐHSPKT\HK2 T2 2022\Window Programming\MIDTERM PROJECT\MiPRoject\Template1SV.docx";
        private void printWordReport_Click(object sender, EventArgs e)
        {
            ResultExport exportToWord = new ResultExport();
            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string studentid = dataGridView1.Rows[0].Cells[0].Value.ToString().Trim();
                        string fullname = dataGridView1.Rows[0].Cells[1].Value.ToString().Trim() + " " + dataGridView1.Rows[0].Cells[2].Value.ToString().Trim();
                        string prte = dataGridView1.Rows[0].Cells[3].Value.ToString().Trim();
                        string wdpr = dataGridView1.Rows[0].Cells[4].Value.ToString().Trim();
                        string dbms = dataGridView1.Rows[0].Cells[5].Value.ToString().Trim();
                        string cldcomp = dataGridView1.Rows[0].Cells[6].Value.ToString().Trim();
                        string caal = dataGridView1.Rows[0].Cells[7].Value.ToString().Trim();
                        string score = dataGridView1.Rows[0].Cells[8].Value.ToString().Trim();
                        double average = Convert.ToDouble(dataGridView1.Rows[0].Cells[8].Value);
                        string result = dataGridView1.Rows[0].Cells[9].Value.ToString().Trim();
                        string rating = "NOT";
                        if (average >= 9)
                        {
                            rating = "Excellent";
                        }
                        else if (average >= 8)
                        {
                            rating = "Good";
                        }
                        else if (average >= 7)
                        {
                            rating = "Fairly Good";
                        }
                        else if (average >= 5)
                        {
                            rating = "Medium";
                        }
                        else
                        {
                            rating = "Weak";
                        }
                        exportToWord.CreateWordDocument(path, saveFileDialog1.FileName, studentid, fullname, prte, wdpr, dbms, cldcomp, caal, score, result, rating);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Export Student Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("The information table is empty, please fill out the information sheet!", "Export Student Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
    
}
