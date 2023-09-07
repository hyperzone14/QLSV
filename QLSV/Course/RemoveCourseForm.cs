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
    public partial class RemoveCourseForm : Form
    {
        Course course = new Course();
        public RemoveCourseForm()
        {
            InitializeComponent();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            try
            {
                int id = Convert.ToInt32(txtCourseID.Text);
                if (MessageBox.Show("Are you sure you want to delete this course", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (course.deleteCourse(id))
                    {
                        MessageBox.Show("Course is deleted", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCourseID.Clear();
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

        private void RemoveCourseForm_Load(object sender, EventArgs e)
        {
            reloadListCourses();
        }
        public void reloadListCourses()
        {
            listBoxCourses.DataSource = course.getAllCourses();
            listBoxCourses.ValueMember = "id";
            listBoxCourses.DisplayMember = "label";
            //Unselect the item form listbox
            listBoxCourses.SelectedItem = null;         
        }
        public void refresh()
        {
            txtCourseID.Clear();           
        }
        public void showThisCourse(int index)
        {

            DataRow dr = course.getAllCourses().Rows[index];

            txtCourseID.Text = dr.ItemArray[0].ToString();
            txtCourseName.Text = dr.ItemArray[1].ToString();
        }
        int pos;
        private void listBoxCourses_Click(object sender, EventArgs e)
        {
            //display the selected course data
            pos = listBoxCourses.SelectedIndex;
            showThisCourse(pos);
        }
    }
}
