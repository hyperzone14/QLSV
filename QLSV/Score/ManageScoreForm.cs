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
    public partial class ManageScoreForm : Form
    {
        public ManageScoreForm()
        {
            InitializeComponent();
        }
        Score score = new Score();
        Course course = new Course();
        Student student = new Student();
        string data = "score";
        bool verif()
        {
            if (tbxStudentID.Text.Trim() == "" || comboBoxCourses.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                int std = Convert.ToInt32(tbxStudentID.Text);
                int course = Convert.ToInt32(comboBoxCourses.SelectedValue);
                double stdscore = Convert.ToDouble(tbxScore.Text);
                string des = tbxDescription.Text;
                if (verif())
                {
                    if (score.insertScore(std, course, stdscore, des))
                    {
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter Student ID and select Course.", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("This student had scored for this course.", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int std = 0, course = 0;
            if (data == "student")
            {
                std = Convert.ToInt32(tbxStudentID.Text);
                course = Convert.ToInt32(comboBoxCourses.SelectedValue);
            }
            else if (data == "score")
            {
                std = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                course = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            }
            try
            {
                if (MessageBox.Show("Do you want to remove this student's scores for this course?", "Delete Student Score", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (score.deleteScore(std, course))
                    {
                        dataGridView1.DataSource = score.getScore();
                        MessageBox.Show("Score is deleted", "Delete Student Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Delete Student Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void averageButton_Click(object sender, EventArgs e)
        {
            AvgByScore average = new AvgByScore();
            average.Show(this);
        }

        private void showStudentButton_Click(object sender, EventArgs e)
        {
            data = "student";
            SqlCommand command = new SqlCommand("select id,fname,lname,bdate from std");
            dataGridView1.DataSource = student.getStudents(command);
            getDataFromDataGridView();
        }
        private void showScoresButton_Click(object sender, EventArgs e)
        {
            data = "score";
            dataGridView1.DataSource = score.getScore();
            getDataFromDataGridView();
        }
        private void ManageScoreForm_Load(object sender, EventArgs e)
        {

            comboBoxCourses.DataSource = course.getAllCourses();
            comboBoxCourses.DisplayMember = "label";
            comboBoxCourses.ValueMember = "id";
            dataGridView1.DataSource = score.getScore();
            getDataFromDataGridView();
            comboBoxCourses.SelectedIndex = -1;
            tbxStudentID.Clear();
        }

        public void getDataFromDataGridView()
        {
            if (data == "student")
            {
                dataGridView1.Columns[0].HeaderText = "Student ID";
                dataGridView1.Columns[1].HeaderText = "First Name";
                dataGridView1.Columns[2].HeaderText = "Last Name";
                dataGridView1.Columns[3].HeaderText = "Birthdate";
                tbxStudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            else if (data == "score")
            {
                dataGridView1.Columns[0].HeaderText = "Student ID";
                dataGridView1.Columns[1].HeaderText = "First Name";
                dataGridView1.Columns[2].HeaderText = "Last Name";
                dataGridView1.Columns[3].HeaderText = "Course ID";
                dataGridView1.Columns[4].HeaderText = "Course Name";
                dataGridView1.Columns[5].HeaderText = "Score";
                //dataGridView1.Columns[6].HeaderText = "Description";               
                tbxStudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                comboBoxCourses.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value;
            }

        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            getDataFromDataGridView();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbxStudentID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
