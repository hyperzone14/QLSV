using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLSV
{
    public partial class AddScoreForm : Form
    {
        Course course = new Course();
        Student student = new Student();
        Score score = new Score();

        public AddScoreForm()
        {
            InitializeComponent();

        }

        // on form load
        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            // lay thong tin all course
            comboBoxCourses.DataSource = course.getAllCourses();
            comboBoxCourses.DisplayMember = "label";
            comboBoxCourses.ValueMember = "id";
            // dua no voi student
            SqlCommand command = new SqlCommand("SELECT id, fname, lname FROM std");
            dataGridViewStudentID.DataSource = student.getStudents(command);
        }
        // on datagridview_students click
        private void DataGridViewStudents_Click(object sender, EventArgs e)
        {
            // get the id of the selected student
            tbxStudentID.Text = dataGridViewStudentID.CurrentRow.Cells[0].Value.ToString();
        }

        private void comboBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    // lay du lieu
            //    int id = Convert.ToInt32(comboBoxCourses.SelectedValue);
            //    DataTable table = new DataTable();
            //    table = course.getCourseByID(id);
            //}
            //catch { }
        }

        private void dataGridViewStudentID_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addScorebt_Click(object sender, EventArgs e)
        {

            try
            {
                int std = Convert.ToInt32(tbxStudentID.Text);
                int course = Convert.ToInt32(comboBoxCourses.SelectedValue);
                double stdscore = Convert.ToDouble(tbxScore.Text);
                string des = tbxDescription.Text;
                if (score.insertScore(std, course, stdscore, des))
                {
                    MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("This student had scored for this course.", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
