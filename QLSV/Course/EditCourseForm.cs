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
    public partial class EditCourseForm : Form
    {
        public EditCourseForm()
        {
            InitializeComponent();
        }
        Course course = new Course();
        private void editButton_Click(object sender, EventArgs e)
        {
            string name = txtCourseName.Text;
            int period = (int)numericUpDownHours.Value;
            string des = txtBoxDescription.Text;
            int id = (int)comboBoxCourses.SelectedValue;

            // lay lai phan kiem tra ten course
            if (!course.checkCourseName(name, Convert.ToInt32(comboBoxCourses.SelectedValue)))
            {
                MessageBox.Show("This Course Name Already Exist","Edit Course",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else if(course.updateCourse(id,name,period,des))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillCombobox(comboBoxCourses.SelectedIndex);            
            }
            else
            {
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void EditCourseForm_Load(object sender, EventArgs e)
        {
            // dùng combobox lay ten Course
            comboBoxCourses.DataSource = course.getAllCourses();
            comboBoxCourses.DisplayMember = "label";
            comboBoxCourses.ValueMember="id";
            comboBoxCourses.SelectedItem = null;
        }

        // Courses Name and ID
        public void fillCombobox(int index)
        {
            comboBoxCourses.DataSource = course.getAllCourses();
            comboBoxCourses.DisplayMember = "label";
            comboBoxCourses.ValueMember = "id";
            comboBoxCourses.SelectedItem = index;
        }

        private void comboBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // lay du lieu
                int id = Convert.ToInt32(comboBoxCourses.SelectedValue);
                DataTable table = new DataTable();
                table = course.getCourseByID(id);
                txtCourseName.Text = table.Rows[0][1].ToString();
                numericUpDownHours.Value = Int32.Parse(table.Rows[0][2].ToString());
                txtBoxDescription.Text = table.Rows[0][3].ToString();
            }
            catch { }
        }
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
    }
}
