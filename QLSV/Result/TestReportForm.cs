using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class TestReportForm : Form
    {       
        
        Student student = new Student();
        SqlCommand command;
        public TestReportForm()
        {
            InitializeComponent();
            dataGridView1.Hide();
        }
        Microsoft.Office.Interop.Word.Application app;
        Microsoft.Office.Interop.Word.Document document;
        object objMiss = Missing.Value;
        object TmpFile = System.IO.Path.GetTempPath() + "INVOICE.pdf";
        object FileLocation = @"C:\Users\Nam\OneDrive\Desktop\ĐHSPKT\HK2 T2 2022\Window Programming\MIDTERM PROJECT\MiPRoject\TemplateClass.docx";

        private void TestReportForm_Load(object sender, EventArgs e)
        {
            string coursename = insert_co();
            string cmd = "SELECT studentid as [Student ID], fname as [First Name], lname as [Last Name], " + coursename + "  ,ROUND(GOOD.[Average Score],2) AS [Average Score] FROM(Select * FROM(select  DTB.[label], DTB.score, fname, lname, id from(Select[label],[studentid], courseid, score From score Inner JOIN  Course on courseid = id Group by score, courseid, [label], studentid)as DTB Inner JOIN std on DTB.studentid = id) as OK PIVOT(SUM(score) FOR OK.[label] IN( " + coursename + ")) AS PVTTable)AS MUCH INNER JOIN(Select studentid, AVG(score.score) AS [Average Score] FROM score Group by studentid) AS GOOD ON studentid = MUCH.id";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
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

            try
            {
                app = new Microsoft.Office.Interop.Word.Application();
                document = app.Documents.Open(ref FileLocation, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss);

                Microsoft.Office.Interop.Word.Table tab = document.Tables[1];
                for (int i = 2; i < dataGridView1.Rows.Count +2 ; i++)
                {
                    tab.Rows.Add(ref objMiss);
                    for (int j = 1; j <= dataGridView1.Columns.Count; j++)
                    {
                        tab.Cell(i, j).Range.Text = dataGridView1.Rows[i-2].Cells[j - 1].Value.ToString();
                    }

                }
                document.ExportAsFixedFormat(TmpFile.ToString(), Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
                this.axAcroPDF1.src = TmpFile.ToString();
                this.axAcroPDF1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                document.Close(WdSaveOptions.wdDoNotSaveChanges, WdOriginalFormat.wdOriginalDocumentFormat, false);
                app.Quit(WdSaveOptions.wdDoNotSaveChanges);
            }
        }
        int temp;
        Course course = new Course();
        public string insert_co()
        {
            string chuoi = "";
            SqlCommand cmd = new SqlCommand("select [label] from Course");
            //DataGridView dataload = new DataGridView();
            dataGridView1.DataSource = course.getCourses(cmd);
            //dataload.DataSource = course.getCourses(cmd);
            temp = dataGridView1.RowCount - 1;
            for (int i = 0; i < temp; i++)
            {
                chuoi += "[" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "], ";
            }
            chuoi += "[" + dataGridView1.Rows[temp].Cells[0].Value.ToString() + "]";
            //MessageBox.Show(chuoi);
            return chuoi;
        }
        private void FindAndReplace(object FindText, object ReplaceText)
        {
            this.app.Selection.Find.Execute(ref FindText, true, true, false, false, false, true, false, 1, ref ReplaceText, 2, false, false, false, false);
        }
    }
}
