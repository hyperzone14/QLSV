using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class EditMyInfoForm : Form
    {
        public EditMyInfoForm()
        {
            InitializeComponent();
        }
        HRLogin hr = new HRLogin();
        MY_DB mydb = new MY_DB();
        int verif()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM hr WHERE id =@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Global.GlobalUserID;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (txtBoxUsername.Text.Trim() == "" || txtBoxEmail.Text.Trim() == "" || txtBoxPassword.Text.Trim() == "" || txtBoxFname.Text.Trim() == "" || txtBoxLname.Text.Trim() == "" || PictureBoxImage.Image == null || txtBoxOldPassword.Text.Trim() == "")
            {
                return 0;
            }
            else if (txtBoxOldPassword.Text != table.Rows[0]["password"].ToString().Trim())
            {
                return 4;
            }
            else if (txtBoxConfirmPassword.Text.Trim() == "")
            {
                return 2;
            }
            else if (txtBoxConfirmPassword.Text.Trim() != txtBoxPassword.Text.Trim())
            {
                return 3;
            }
            else
            {
                return 1;
            }
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            string user = Global.GlobalUsername;
            string confirm = txtBoxConfirmPassword.Text;
            string mail = txtBoxEmail.Text;
            string fname = txtBoxFname.Text;
            string lname = txtBoxLname.Text;
            MemoryStream pic = new MemoryStream();
            if (verif() == 0)
            {
                MessageBox.Show("Please fill in all the information!", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (verif() == 4)
            {
                MessageBox.Show("Your old password does not match, please re-enter!", "Edit My Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (verif() == 2)
            {
                MessageBox.Show("Please Enter The Confirmation Password.", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (verif() == 3)
            {
                MessageBox.Show("Confirmation password does not match.\nPlease re-enter the confirmation password!", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            /*else if (hr.usernameExist(user, "register") == true)
            {
                MessageBox.Show("Username was existed", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }*/
            else
            {

                if (!txtBoxEmail.Text.Contains('@') || !txtBoxEmail.Text.Contains('.'))
                {
                    MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    PictureBoxImage.Image.Save(pic, PictureBoxImage.Image.RawFormat);
                    try
                    {
                        if (hr.updateHR(fname, lname, user, confirm, mail, pic))
                        {
                            MessageBox.Show("Your Information Is Edited", "Edit  My Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Edit My Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Edit My Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void changeImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void EditMyInfoForm_Load(object sender, EventArgs e)
        {
            getInfo();
        }
        public void getInfo()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM hr WHERE id =@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Global.GlobalUserID;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                byte[] pic = (byte[])table.Rows[0]["fimage"];
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxImage.Image = Image.FromStream(picture);
                string fname = (string)table.Rows[0]["f_name"];
                string lname = (string)table.Rows[0]["l_name"];
                string mail = (string)table.Rows[0]["email"];
                txtBoxFname.Text = fname.Trim();
                txtBoxLname.Text = lname.Trim();
                txtBoxEmail.Text = mail.Trim();
                txtBoxUsername.Text = Global.GlobalUsername.Trim();
            }
        }
    }
}
