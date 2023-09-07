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
    public partial class PrintCourseStd : Form
    {
        public PrintCourseStd()
        {
            InitializeComponent();
        }

        private void printtoWordBt_Click(object sender, EventArgs e)
        {
            CourseExport word = new CourseExport();
            if (DataGridstdinclass.Rows.Count > 0)
            {
                try
                {
                    saveFileDialog1.Filter = "Word Documents (.docx)|.docx";
                    saveFileDialog1.FileName = ".docx";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        word.exportDataToWord2(DataGridstdinclass, saveFileDialog1.FileName, lbCoursename.Text.Trim()) ;
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

        private void PrintCourseStd_Load(object sender, EventArgs e)
        {
            lbStd.Text = ("Total Student in Course: " + DataGridstdinclass.Rows.Count);
        }
    }
}
