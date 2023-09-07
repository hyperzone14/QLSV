using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QLSV
{
    public partial class CreateNewAccountForm : Form
    {
        public CreateNewAccountForm()
        {
            InitializeComponent();
        }
        AccountLogin account = new AccountLogin();
        HRLogin hr = new HRLogin();
        MY_DB mydb = new MY_DB();
        int verif()
        {
            if (txtBoxUsername.Text.Trim() == "" || txtBoxEmail.Text.Trim() == "" || txtBoxPassword.Text.Trim() == "" || txtBoxFname.Text.Trim() == "" || txtBoxLname.Text.Trim() == "" || PictureBoxImage.Image == null)
            {
                return 0;
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
        void clearFields()
        {
            txtBoxFname.Clear();
            txtBoxLname.Clear();
            txtBoxUsername.Clear();
            txtBoxPassword.Clear();
            txtBoxConfirmPassword.Clear();
            txtBoxEmail.Clear();
            radioHRButton.Checked = false;
            radioStudentButton.Checked = false;
            PictureBoxImage.Image = null;
        }
        private void labelSignIn_Click(object sender, EventArgs e)
        {
            Hide();
            Application.Restart();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string user = txtBoxUsername.Text;
            string confirm = txtBoxConfirmPassword.Text;
            string mail = txtBoxEmail.Text;
            string fname = txtBoxFname.Text;
            string lname = txtBoxLname.Text;
            MemoryStream pic = new MemoryStream();

            if (verif() == 0)
            {
                MessageBox.Show("Please fill in all the information!", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (verif() == 2)
            {
                MessageBox.Show("Please Enter The Confirmation Password.", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (verif() == 3)
            {
                MessageBox.Show("Confirmation password does not match.\nPlease re-enter the confirmation password!", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (account.checkUsername(user) == true || hr.usernameExist(user, "register") == true)
            {
                MessageBox.Show("Username was existed", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                if (!txtBoxEmail.Text.Contains('@') || !txtBoxEmail.Text.Contains('.'))
                {
                    MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    PictureBoxImage.Image.Save(pic, PictureBoxImage.Image.RawFormat);
                    if (radioStudentButton.Checked == false && radioHRButton.Checked == false)
                    {
                        MessageBox.Show("Please select user type!", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (radioStudentButton.Checked)
                    {
                        try
                        {
                            if (account.insertAccount(fname, lname, user, confirm, mail, pic))
                            {
                                clearFields();
                                MessageBox.Show("Registered An Account Successfully.", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Hide();
                                Application.Restart();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else if (radioHRButton.Checked)
                    {
                        try
                        {
                            if (hr.insertHR(fname, lname, user, confirm, mail, pic))
                            {
                                clearFields();
                                MessageBox.Show("Registered An Account Successfully.", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Hide();
                                Application.Restart();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
        }

        private void uploadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxImage.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
