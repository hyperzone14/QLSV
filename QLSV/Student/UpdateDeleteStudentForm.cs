using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace QLSV
{
    public partial class UpdateDeleteStudentForm : Form
    {
        MY_DB db = new MY_DB();
        SqlCommand cmd = new SqlCommand();
        Student student = new Student();
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }
        bool verif()
        {
            if ((txtBoxFname.Text.Trim() == "")
                || (txtBoxLname.Text.Trim() == "")
                || (txtBoxAddress.Text.Trim() == "")
                || (txtBoxPhone.Text.Trim() == "")
                || (PictureBoxStudentImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            int id;
            string fname = txtBoxFname.Text;
            string lname = txtBoxLname.Text;
            DateTime bdate = DateTimePicker1.Value;
            string phone = txtBoxPhone.Text;
            string adrs = txtBoxAddress.Text;
            string gender = "Male";
            if (RadioButtonFemale.Checked)
            {
                gender = "Female";
            }
            MemoryStream pic = new MemoryStream();
            int born_year = DateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                try
                {
                    id = Convert.ToInt32(txtStudentID.Text);
                    PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                    if (student.updateStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                    {
                        txtStudentID.Clear();
                        txtBoxFname.Clear();
                        txtBoxLname.Clear();
                        txtBoxPhone.Clear();
                        txtBoxAddress.Clear();
                        DateTimePicker1.Text = "";
                        RadioButtonMale.Checked = false;
                        RadioButtonMale.Checked = false;
                        PictureBoxStudentImage.Image = null;
                        MessageBox.Show("Student is Edited", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtStudentID.Text);
                if(MessageBox.Show("Are you sure you want to delete this student","Delete Student",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (student.deleteStudent(id))
                    {
                        MessageBox.Show("Student is deleted","Delete Student",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtStudentID.Clear();
                        txtBoxFname.Clear();
                        txtBoxLname.Clear(); ;
                        txtBoxAddress.Clear();
                        txtBoxPhone.Clear();
                        DateTimePicker1.Value = DateTime.Now;
                        PictureBoxStudentImage.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Error","Delete Student",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid Student ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtStudentID.Text);
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM std WHERE id = " + id);
            DataTable table = student.getStudents(command);
            if (table.Rows.Count > 0)
            {
                txtBoxFname.Text = table.Rows[0]["fname"].ToString();
                txtBoxLname.Text = table.Rows[0]["lname"].ToString();
                DateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];
                if (table.Rows[0]["gender"].ToString().Trim() == "Female")
                {
                    RadioButtonFemale.Checked =true;
                }
                else
                {
                    RadioButtonMale.Checked=true;
                }
                txtBoxPhone.Text = table.Rows[0]["phone"].ToString();
                txtBoxAddress.Text = table.Rows[0]["address"].ToString();
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxStudentImage.Image = Image.FromStream(picture);

            }
            else
            {
                MessageBox.Show("Not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void toFirstButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            SqlCommand command = new SqlCommand("SELECT * FROM std");

            DataTable table = student.getStudents(command);
            if (table.Rows.Count > 0)
            {
                txtStudentID.Text = table.Rows[0]["id"].ToString();
                txtBoxFname.Text = table.Rows[0]["fname"].ToString();
                txtBoxLname.Text = table.Rows[0]["lname"].ToString();
                DateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];

                if (table.Rows[0]["gender"].ToString().Trim() == "Female")
                {
                    RadioButtonFemale.Checked = true;
                }
                    
                else RadioButtonMale.Checked = true;
                txtBoxPhone.Text = table.Rows[0]["phone"].ToString();
                txtBoxAddress.Text = table.Rows[0]["address"].ToString();

                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxStudentImage.Image = Image.FromStream(picture);
            }
            else MessageBox.Show("Not Found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void toLastButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            SqlCommand command = new SqlCommand("SELECT * FROM std");

            DataTable table = student.getStudents(command);
            if (table.Rows.Count > 0)
            {
                txtStudentID.Text = table.Rows[table.Rows.Count - 1]["id"].ToString();
                txtBoxFname.Text = table.Rows[table.Rows.Count - 1]["fname"].ToString();
                txtBoxLname.Text = table.Rows[table.Rows.Count - 1]["lname"].ToString();
                DateTimePicker1.Value = (DateTime)table.Rows[table.Rows.Count - 1]["bdate"];

                if (table.Rows[table.Rows.Count - 1]["gender"].ToString().Trim() == "Male")
                    RadioButtonMale.Checked = true;
                else RadioButtonFemale.Checked = true;
                txtBoxPhone.Text = table.Rows[table.Rows.Count - 1]["phone"].ToString();
                txtBoxAddress.Text = table.Rows[table.Rows.Count - 1]["address"].ToString();

                byte[] pic = (byte[])table.Rows[table.Rows.Count - 1]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxStudentImage.Image = Image.FromStream(picture);
            }
            else MessageBox.Show("Not Found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            SqlCommand command = new SqlCommand("SELECT * FROM std");

            DataTable table = student.getStudents(command);
            string id = txtStudentID.Text;
            int pre = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i]["id"].ToString() == id)
                    pre = i - 1;
            }
            if (pre > -1)
            {
                txtStudentID.Text = table.Rows[pre]["id"].ToString();
                txtBoxFname.Text = table.Rows[pre]["fname"].ToString();
                txtBoxLname.Text = table.Rows[pre]["lname"].ToString();
                DateTimePicker1.Value = (DateTime)table.Rows[pre]["bdate"];

                if (table.Rows[pre]["gender"].ToString().Trim() == "Female")
                    RadioButtonFemale.Checked = true;
                else RadioButtonMale.Checked = true;
                txtBoxPhone.Text = table.Rows[pre]["phone"].ToString();
                txtBoxAddress.Text = table.Rows[pre]["address"].ToString();

                byte[] pic = (byte[])table.Rows[pre]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxStudentImage.Image = Image.FromStream(picture);
            }
            else MessageBox.Show("This is the first Student", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            SqlCommand command = new SqlCommand("SELECT * FROM std");

            DataTable table = student.getStudents(command);
            string id = txtStudentID.Text;
            int next = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i]["id"].ToString() == id)
                    next = i + 1;
            }
            if (next < table.Rows.Count)
            {
                txtStudentID.Text = table.Rows[next]["id"].ToString();
                txtBoxFname.Text = table.Rows[next]["fname"].ToString();
                txtBoxLname.Text = table.Rows[next]["lname"].ToString();
                DateTimePicker1.Value = (DateTime)table.Rows[next]["bdate"];

                if (table.Rows[next]["gender"].ToString().Trim() == "Male")
                    RadioButtonMale.Checked = true;
                else RadioButtonFemale.Checked = true;
                txtBoxPhone.Text = table.Rows[next]["phone"].ToString();
                txtBoxAddress.Text = table.Rows[next]["address"].ToString();

                byte[] pic = (byte[])table.Rows[next]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxStudentImage.Image = Image.FromStream(picture);
            }
            else MessageBox.Show("This is the last Student", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void txtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtBoxFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtBoxLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
