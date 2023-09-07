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

namespace QLSV
{
    public partial class LoginForm : Form
    {
        MY_DB db = new MY_DB();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        bool verif()
        {
            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                {
                    return true;
                }
            }
        }
        private void loginButton_Click(object sender, EventArgs e)
        {

            string permission = "hr";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            if (verif() == false)
            {
                MessageBox.Show("Please enter your account and password!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (radioStudentButton.Checked == false && radioHRButton.Checked == false)
            {
                MessageBox.Show("Please select the permission to login!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (radioHRButton.Checked)
                    {
                        permission = "hr";
                    }
                    else if (radioStudentButton.Checked)
                    {
                        permission = "Login";
                    }
                    //Set DataSource                    
                    SqlCommand command = new SqlCommand("SELECT * FROM [" + permission + "] WHERE username = @user and password = @pass", db.getConnection);//Username and Password
                    command.Parameters.Add("@user", SqlDbType.NChar).Value = txtUsername.Text;
                    command.Parameters.Add("@pass", SqlDbType.NChar).Value = txtPassword.Text;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        int userID = Convert.ToInt32(table.Rows[0][0].ToString().Trim());
                        string userName = Convert.ToString(table.Rows[0][1].ToString().Trim());
                        Global.SetGlobalUserID(userID);
                        Global.SetGlobalUsername(userName);
                        txtPassword.Clear();
                        txtUsername.Clear();
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Please check Username or Password again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
  
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (exit == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                errorProvider1.SetError(this.txtPassword, "Password is required.");
            }
        }

        private void txtUsername_Validated(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                errorProvider1.SetError(this.txtUsername, "Blank is not valid.");
            }
        }

        private void newaccountButton_Click(object sender, EventArgs e)
        {
            CreateNewAccountForm createNewAccountForm = new CreateNewAccountForm();
            createNewAccountForm.Show();
        }

        private void forgotButton_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.Show();
        }

        private void radioStudentButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
