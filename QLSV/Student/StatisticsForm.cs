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
    public partial class StatisticsForm : Form
    {
        Student student = new Student();
        public StatisticsForm()
        {
            InitializeComponent();

            genderStudentChart.Series["Gender"].Points.AddXY("Female", student.totalFemaleStudent());
            genderStudentChart.Series["Gender"].Points.AddXY("Male", student.totalMaleStudent());
        }
        Color panTotalColor;
        Color panMaleColor;
        Color panFemaleColor;
        private void StaticsForm_Load(object sender, EventArgs e)
        {
            // get panels color
            panTotalColor = panTotalStudent.BackColor;
            panMaleColor = panTotalMaleStudent.BackColor;
            panFemaleColor = panTotalFemaleStudent.BackColor;
            // display the values
            Student student = new Student();
            double total = Convert.ToDouble(student.totalStudent());
            double totalMale = Convert.ToDouble(student.totalMaleStudent());
            double totalFemale = Convert.ToDouble(student.totalFemaleStudent());
            // tinh %, cac ban xem lai phep toan
            // (tong students X 100) / (total students)|
            double maleStudentsPercentage = (totalMale * (100 / total));
            double femaleStudentsPercentage = (totalFemale * (100 / total));
            lblTotalStudents.Text = ("Total Students: " + total.ToString());
            lblMale.Text = ("Male " + (maleStudentsPercentage.ToString("0.00") + "%"));
            lblFemale.Text = ("Female :" + (femaleStudentsPercentage.ToString("0.00")+ "%"));
        }
        private void LabelTotal_MouseEnter(object sender, EventArgs e)
        {
            lblTotalStudents.ForeColor = panTotalColor;
            panTotalStudent.BackColor = Color.White;
        }

        private void LabelTotal_MouseLeave(object sender, EventArgs e)
        {
            lblTotalStudents.ForeColor = Color.White;
            panTotalStudent.BackColor = panTotalColor;
        }

        private void LabelMale_MouseEnter(object sender, EventArgs e)
        {
            lblMale.ForeColor = panMaleColor;
            panTotalMaleStudent.BackColor = Color.White;
        }

        private void LabelMale_MouseLeave(object sender, EventArgs e)
        {
            lblMale.ForeColor = Color.White;
            panTotalMaleStudent.BackColor = panMaleColor;
        }

        private void LabelFemale_MouseEnter(object sender, EventArgs e)
        {
            lblFemale.ForeColor = panFemaleColor;
            panTotalFemaleStudent.BackColor = Color.White;
        }

        private void LabelFemale_MouseLeave(object sender, EventArgs e)
        {
            lblFemale.ForeColor = Color.White;
            panTotalFemaleStudent.BackColor = panFemaleColor;
        }

        private void panTotalFemaleStudent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
