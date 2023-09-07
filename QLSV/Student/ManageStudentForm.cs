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
using System.Drawing.Imaging;

namespace QLSV
{
    public partial class ManageStudentForm : Form
    {
        public ManageStudentForm()
        {
            InitializeComponent();
        }

        private void ManagementStudentForm_Load(object sender, EventArgs e)
        {
            Student student = new Student();
            // TODO: This line of code loads data into the 'qLSVDataSetstd.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter1.Fill(this.qLSVDataSettt.std);
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGridView1.ReadOnly = true;
            // xu ly hinh anh, code co tham khao msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn(); // doi tuong lam viec voi dang picture cua datagridview
            dataGridView1.RowTemplate.Height = 80; // dong nay tham khao tren MSDN ngay 10/03/2019, co gian de pic dep, dang tim auto-size
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.AllowUserToAddRows = false;
            lblTotal.Text = ("Total Student: " + dataGridView1.Rows.Count);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void fillGrid(SqlCommand command)
        {
            Student student = new Student();
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.AllowUserToAddRows = false;

            lblTotal.Text = ("Total Student: " + dataGridView1.Rows.Count);
        }
        public void dataRefresh()
        {
            Student student = new Student();
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE CONCAT(fname, lname, address) LIKE '%" + txtSearchBox.Text + "%'");
            dataGridView1.ReadOnly = true;

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.AllowUserToAddRows = false;
            lblTotal.Text = ("Total Student: " + dataGridView1.Rows.Count);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE CONCAT(fname, lname, address) LIKE '%" + txtSearchBox.Text + "%'");
            fillGrid(command);
            Student student = new Student();
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
                else
                {
                    RadioButtonMale.Checked = true;
                }
                txtBoxPhone.Text = table.Rows[0]["phone"].ToString();
                txtBoxAddress.Text = table.Rows[0]["address"].ToString();
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxStudentImage.Image = Image.FromStream(picture);

            }
            else
            {
                MessageBox.Show("Not found", "Search Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
        private void addButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
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
                    if (student.insertStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                    {
                        txtStudentID.Clear();
                        txtBoxFname.Clear();
                        txtBoxLname.Clear();
                        txtBoxPhone.Clear();
                        txtBoxAddress.Clear();
                        DateTimePicker1.Value = DateTime.Now;
                        RadioButtonMale.Checked = false;
                        RadioButtonMale.Checked = false;
                        PictureBoxStudentImage.Image = null;
                        dataRefresh();
                        MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            dataRefresh();
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

        private void editButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
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
                        dataRefresh();
                        MessageBox.Show("Student is Edited", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            dataRefresh();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            try
            {
                int id = Convert.ToInt32(txtStudentID.Text);
                if (MessageBox.Show("Are you sure you want to delete this student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (student.deleteStudent(id))
                    {
                        txtStudentID.Clear();
                        txtBoxFname.Clear();
                        txtBoxLname.Clear(); ;
                        txtBoxAddress.Clear();
                        txtBoxPhone.Clear();
                        DateTimePicker1.Value = DateTime.Now;
                        PictureBoxStudentImage.Image = null;
                        dataRefresh();
                        MessageBox.Show("Student is deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        MessageBox.Show("Error", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid Student ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataRefresh();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            txtSearchBox.Clear();
            txtStudentID.Clear();
            txtBoxFname.Clear();
            txtBoxLname.Clear();
            txtBoxPhone.Clear();
            DateTimePicker1.Value = DateTime.Now;
            txtBoxAddress.Clear();
            RadioButtonMale.Checked = false;
            RadioButtonFemale.Checked = false;
            PictureBoxStudentImage.Image = null;
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("student_" + txtStudentID);
            if ((PictureBoxStudentImage.Image == null))
                MessageBox.Show("No Image in Picture Box");
            else if ((svf.ShowDialog() == DialogResult.OK))
                PictureBoxStudentImage.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtStudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            txtBoxFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
            txtBoxLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
            DateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;

            if (dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim() == "Male")
            {
                RadioButtonMale.Checked = true;
            }
            else
            {
                RadioButtonFemale.Checked = true;
            }
            txtBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim();
            txtBoxAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString().Trim();
            //code xu ly hinh anh
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            PictureBoxStudentImage.Image = Image.FromStream(picture);
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

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
