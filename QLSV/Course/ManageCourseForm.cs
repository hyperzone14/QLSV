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
    public partial class ManageCourseForm : Form
    {
        Course course = new Course();
        int pos;
        public ManageCourseForm()
        {
            InitializeComponent();
        }
        public void refresh()
        {
            txtCourseID.Clear();
            txtCourseName.Clear();
            txtBoxDescription.Clear();
            numericUpDownHours.Value = 10;
        }
        public void reloadListCourses()
        {
            listBoxCourses.DataSource = course.getAllCourses();
            listBoxCourses.ValueMember = "id";
            listBoxCourses.DisplayMember = "label";
            //Unselect the item form listbox
            listBoxCourses.SelectedItem = null;
            //Show Total Course
            lblTotalCoures.Text = "Total Course: " + course.totalCourses();
        }
        public void showThisCourse(int index)
        {

            DataRow dr = course.getAllCourses().Rows[index];

            txtCourseID.Text = dr.ItemArray[0].ToString();
            txtCourseName.Text = dr.ItemArray[1].ToString();
            numericUpDownHours.Value = int.Parse(dr.ItemArray[2].ToString());
            txtBoxDescription.Text = dr.ItemArray[3].ToString();
        }
        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            reloadListCourses();
        }

        private void listBoxCourses_Click(object sender, EventArgs e)
        {
            //display the selected course data
            pos = listBoxCourses.SelectedIndex;
            showThisCourse(pos);
        }

        /*private void listBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pos = listBoxCourses.SelectedIndex;
                showThisCourse(pos);
                // lay du lieu
                int id = Convert.ToInt32(listBoxCourses.SelectedValue);
                DataTable table = new DataTable();
                table = course.getCourseByID(id);
                txtCourseName.Text = table.Rows[0][1].ToString();
                numericUpDownHours.Value = Int32.Parse(table.Rows[0][2].ToString());
                txtBoxDescription.Text = table.Rows[0][3].ToString();
            }
            catch { }
        }*/

        private void numericUpDownHours_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownHours.Value < 10)
            {
                errorProvider1.SetError(this.numericUpDownHours, "Period must be at least 10, please enter again!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(txtCourseID.Text);
            string cname = txtCourseName.Text;
            int period = Convert.ToInt32(numericUpDownHours.Value);
            string des = txtBoxDescription.Text;
            if (cname.Trim() == "")
            {
                MessageBox.Show("Add A Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (course.checkCourseName(cname, cid))
            {
                if (course.insertCourse(cid, cname, period, des))
                {
                    refresh();
                    reloadListCourses();
                    MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("This Course Name Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            string name = txtCourseName.Text;
            int period = (int)numericUpDownHours.Value;
            string des = txtBoxDescription.Text;
            int id = Convert.ToInt32(txtCourseID.Text);

            // lay lai phan kiem tra ten course
            if (!course.checkCourseName(name, id))
            {
                MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (course.updateCourse(id, name, period, des))
            {
                refresh();
                reloadListCourses();
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtCourseID.Text);
                if (MessageBox.Show("Are you sure you want to delete this course", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (course.deleteCourse(id))
                    {
                        refresh();
                        reloadListCourses();
                        MessageBox.Show("Course is deleted", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid Course ID", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void firstButton_Click(object sender, EventArgs e)
        {

            pos = 0;
            showThisCourse(0);
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            pos = course.getAllCourses().Rows.Count - 1;
            showThisCourse(pos);
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos = pos - 1;
                showThisCourse(pos);
            }
            else
            {
                MessageBox.Show("This is the first course.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (pos < (course.getAllCourses().Rows.Count - 1))
            {
                pos = pos + 1;
                showThisCourse(pos);
            }
            else
            {
                MessageBox.Show("This is the last course.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void listBoxCourses_DoubleClick(object sender, EventArgs e)
        {
            DataTable table = course.getCourseByID(Convert.ToInt32(listBoxCourses.SelectedValue));
            PrintCourseStd studentListByCourse = new PrintCourseStd();
            studentListByCourse.DataGridstdinclass.DataSource = course.getStudentByCourse(Convert.ToInt32(listBoxCourses.SelectedValue));
            studentListByCourse.lbCoursename.Text = "Course Name: " + table.Rows[0]["label"].ToString().Trim();
            studentListByCourse.ShowDialog();
        }
    }
    
}
