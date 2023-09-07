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
    public partial class StudentListForm : Form
    {
        Student student = new Student();
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSettt.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter1.Fill(this.qLSVDataSettt.std);
           
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGridView1.ReadOnly = true;
            // xu ly hinh anh, code co tham khao msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn(); // doi tuong lam viec voi dang picture cua datagridview
            dataGridView1.RowTemplate.Height = 80; // dong nay tham khao tren MSDN ngay 10/03/2019, co gian de pic dep, dang tim auto-size
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGridView1.ReadOnly = true; // Nap lai du lieu
            DataGridViewImageColumn picCol = new DataGridViewImageColumn(); 
            dataGridView1.RowTemplate.Height = 80; 
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDeleteStudentForm updateDelete = new UpdateDeleteStudentForm();
            // thu tu cua cac cot: id - fname - lnane bd - gdr phn adrs - pic
            updateDelete.txtStudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDelete.txtBoxFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDelete.txtBoxLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDelete.DateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            // gender
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim() == "Female")
            {
                updateDelete.RadioButtonFemale.Checked = true;
            }
            else
            {
                updateDelete.RadioButtonMale.Checked = true;
            }

            updateDelete.txtBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateDelete.txtBoxAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            // code xu ly hinh anh up len, version 01, chay OK, tim hieu them de code nhe hon
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDelete.PictureBoxStudentImage.Image = Image.FromStream(picture);
            this.Show();
            updateDelete.Show();
        }
    }
}
