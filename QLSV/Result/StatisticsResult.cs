using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class StatisticsResult : Form
    {
        Student student = new Student();
        Score score = new Score();
        Course course = new Course();
        public StatisticsResult()
        {
            InitializeComponent();

        }

        private void StaticResultForm_Load(object sender, EventArgs e)
        {
            DataTable table = score.getAverageScoreByCourse();

            foreach (DataRow row in table.Rows)
            {
                Label coursename = new Label();
                Label point = new Label();
                coursename.Text = row["Course Name"].ToString().Trim() + ": ";
                this.flowLayoutPanelCourse.Controls.Add(coursename);
                point.Text = String.Format("{0:0.00}", Convert.ToDouble(row["Average Score By Course"].ToString().Trim()));                
                this.flowLayoutPanel1.Controls.Add(point);
                resultChart.Series.Add(row["Course Name"].ToString().Trim());
                resultChart.Series[row["Course Name"].ToString().Trim()].Points.AddY(Convert.ToDouble(row[1].ToString()));

            }
            resultChart.Series.Add("Maximum Score");
            resultChart.Series["Maximum Score"].Points.AddY(10);
           
            int numPass = score.getStudentPass();
            int numFail = score.getStudentFail();
            chartResult.Series["Result"].Points.AddXY("Pass", numPass);
            chartResult.Series["Result"].Points.AddXY("Fail",numFail);

            labelPass.Text = "Pass: " + String.Format("{0:0.00}", (double)(numPass * 100 / (numPass + numFail))) + " %";
            labelFail.Text = "Fail: " + String.Format("{0:0.00}", (double)(numFail * 100 / (numPass + numFail))) + " %";

            labelExcellent.Text = "Excellent: " + String.Format("{0:0.00}", (double)(score.getRatingStudent(10, 9) * 100 / (numPass + numFail))) + " %";
            labelGood.Text = "Good: " + String.Format("{0:0.00}", (double)(score.getRatingStudent(9, 8) * 100 / (numPass + numFail))) + " %";
            labelFairlyGood.Text = "Fairly Good: " + String.Format("{0:0.00}", (double)(score.getRatingStudent(8, 7) * 100 / (numPass + numFail))) + " %";
            labelMedium.Text = "Average: " + String.Format("{0:0.00}", (double)(score.getRatingStudent(7, 5) * 100 / (numPass + numFail))) + " %";
            labelWeak.Text = "Weak: " + String.Format("{0:0.00}", (double)(numFail * 100 / (numPass + numFail))) + " %";
        }

        private void chartResult_Click(object sender, EventArgs e)
        {

        }
    }
}
