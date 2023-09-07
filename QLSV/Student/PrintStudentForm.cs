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
    public partial class PrintStudentForm : Form
    {
        Student student = new Student();
        StudentExport export = new StudentExport();
        public PrintStudentForm()
        {
            InitializeComponent();
        }
        private void PrinterForm_Load(object sender, EventArgs e)
        {
            radioButtonAll.Checked = true;
            radioButtonNo.Checked = true;
            // TODO: This line of code loads data into the 'qLSVDataSetstd.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter1.Fill(this.qLSVDataSettt.std);
            SqlCommand command = new SqlCommand("SELECT id AS [Student ID],fname AS [First Name], lname AS [Last Name], bdate AS [Birthdate], gender AS [Gender], phone AS [Phone], address AS [Address], picture AS [Image] FROM std");
            fillGrid(command);
            if (radioButtonNo.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }
        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.AllowUserToAddRows = false;
        }
        private void checkButton_Click(object sender, EventArgs e)
        {
            string querry;
            if (radioButtonYes.Checked)
            {
                if (radioButtonAll.Checked)
                {
                    querry = "SELECT id AS [Student ID],fname AS [First Name], lname AS [Last Name], bdate AS [Birthdate], gender AS [Gender], phone AS [Phone], address AS [Address], picture AS [Image] FROM std WHERE (bdate BETWEEN'" + dateTimePicker1.Value.Date + "' AND '" + dateTimePicker2.Value.Date + "' )";
                }

                else if (radioButtonMale.Checked)
                {
                    querry = "SELECT id AS [Student ID],fname AS [First Name], lname AS [Last Name], bdate AS [Birthdate], gender AS [Gender], phone AS [Phone], address AS [Address], picture AS [Image] FROM std WHERE (bdate BETWEEN'" + dateTimePicker1.Value.Date + "' AND '" + dateTimePicker2.Value.Date + "' )" + " AND gender = 'Male'";
                }
                else
                {
                    querry = "SELECT id AS [Student ID],fname AS [First Name], lname AS [Last Name], bdate AS [Birthdate], gender AS [Gender], phone AS [Phone], address AS [Address], picture AS [Image] FROM std WHERE (bdate BETWEEN'" + dateTimePicker1.Value.Date + "' AND '" + dateTimePicker2.Value.Date + "' )" + " AND gender = 'Female'";
                }
            }
            else
            {
                if (radioButtonMale.Checked)
                {
                    querry = "SELECT id AS [Student ID],fname AS [First Name], lname AS [Last Name], bdate AS [Birthdate], gender AS [Gender], phone AS [Phone], address AS [Address], picture AS [Image] FROM std WHERE gender = 'Male'";

                }
                else if (radioButtonFemale.Checked)
                {
                    querry = "SELECT id AS [Student ID],fname AS [First Name], lname AS [Last Name], bdate AS [Birthdate], gender AS [Gender], phone AS [Phone], address AS [Address], picture AS [Image] FROM std WHERE gender = 'Female'";
                }
                else
                {
                    querry = "SELECT id AS [Student ID],fname AS [First Name], lname AS [Last Name], bdate AS [Birthdate], gender AS [Gender], phone AS [Phone], address AS [Address], picture AS [Image] FROM std ";
                }
            }
            SqlCommand command = new SqlCommand(querry);
            fillGrid(command);
        }
        private void saveToPDFButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
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
                            export.exportDataToPDF(dataGridView1, saveFileDialog1.FileName);
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
        private void saveToExcelButton_Click(object sender, EventArgs e)
        {
            StudentExport excel = new StudentExport();
            DataTable dt = (DataTable)dataGridView1.DataSource;
            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    saveFileDialog1.Filter = "Excel (.xlsx)|.xlsx";
                    saveFileDialog1.FileName = ".xlsx";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        excel.exportDataToExcel(dt, "Student", "Students List", saveFileDialog1.FileName);
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
        private void saveToWordButton_Click(object sender, EventArgs e)
        {
            StudentExport word = new StudentExport();
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
        private void printButton_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if (printDlg.ShowDialog() == DialogResult.OK)
                printDoc.Print();
        }
        private void saveFileTextButton_Click(object sender, EventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ @"\student_list.txt";
            using (var writer = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                DateTime bdate;
                for(int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for(int j =0; j < dataGridView1.Columns.Count-1; j++)
                    {
                        if (j == 3)
                        {
                            bdate = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value.ToString());
                            writer.Write("\t" + bdate.ToString("dd-MM-yyyy") + "\t" + "|");
                        }
                        else if(j== dataGridView1.Columns.Count-2)
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                        else
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                    }
                    writer.WriteLine();
                    writer.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                }
            }
            MessageBox.Show("Done", "Notification");
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
