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
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            int cid= Convert.ToInt32(txtCourseID.Text);
            string cname = txtCourseName.Text;
            int period = Convert.ToInt32(numericUpDownHours.Value);
            string des = txtBoxDescription.Text;
            if (cname.Trim()=="")
            {
                MessageBox.Show("Add A Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (course.checkCourseName(cname))
            {
                if (course.insertCourse(cid, cname, period, des))
                {
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

        private void numericUpDownHours_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDownHours.Value < 10)
            {
                errorProvider1.SetError(this.numericUpDownHours, "Period must be at least 10, please enter again!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
