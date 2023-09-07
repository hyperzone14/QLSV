using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace QLSV
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        string veritificationCode;
        public static string toEmail;
        AccountLogin account = new AccountLogin();
        HRLogin hr = new HRLogin();
        private void sendEmailButton_Click(object sender, EventArgs e)
        {
            if (account.checkEmail(txtBoxEmail.Text.ToString()) == true || hr.checkEmail(txtBoxEmail.Text.ToString()) == true)
            {
                string fromEmail, pass, messageBody;
                Random rand = new Random();
                veritificationCode = (rand.Next(999999)).ToString();
                MailMessage mailMessage = new MailMessage();
                toEmail = txtBoxEmail.Text.ToString();
                fromEmail = "nhnnam2411@gmail.com";
                pass = "Namnguyen2411";
                messageBody = "You are requesting a password reset. Your verification code: " + veritificationCode + ". Please do not give the verification code to anyone to protect the account.";
                mailMessage.To.Add(toEmail);
                mailMessage.From = new MailAddress(fromEmail);
                mailMessage.Body = messageBody;
                mailMessage.Subject = "Password Reseting Code";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(fromEmail, pass);
                try
                {
                    smtp.Send(mailMessage);
                    MessageBox.Show("Verification code sent successfully", "Forgot Password");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        SqlCommand command = new SqlCommand();
        private void resetPasswordButton_Click(object sender, EventArgs e)
        {
            if (veritificationCode == txtBoxVertificationCode.Text.Trim())
            {
                toEmail = txtBoxEmail.Text;
                if (txtBoxNewPassword.Text == txtBoxConfirmPassword.Text)
                {
                    if (radioStudentButton.Checked == false && radioHRButton.Checked == false)
                    {
                        MessageBox.Show("Please select user type!", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (radioStudentButton.Checked)
                    {
                        command = new SqlCommand("UPDATE login SET password =@resetPass WHERE email=@email", mydb.getConnection);
                        command.Parameters.Add("@resetPass", SqlDbType.NChar).Value = txtBoxConfirmPassword.Text;
                        command.Parameters.Add("@email", SqlDbType.VarChar).Value = toEmail;
                        mydb.openConnection();
                        command.ExecuteNonQuery();
                        mydb.closeConnection();
                        MessageBox.Show("Password reset successful.", "Forgot Password");
                    }
                    else if (radioHRButton.Checked)
                    {
                        command = new SqlCommand("UPDATE hr SET password =@resetPass WHERE email=@email", mydb.getConnection);
                        command.Parameters.Add("@resetPass", SqlDbType.NChar).Value = txtBoxConfirmPassword.Text;
                        command.Parameters.Add("@email", SqlDbType.VarChar).Value = toEmail;
                        mydb.openConnection();
                        command.ExecuteNonQuery();
                        mydb.closeConnection();
                        MessageBox.Show("Password reset successful.", "Forgot Password");
                    }

                }
                else if (txtBoxNewPassword.Text.Trim() == "" || txtBoxConfirmPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Please fill in all the information!", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Passwords are not the same.", "Forgot Password");
                }
            }
            else
            {
                MessageBox.Show("The verification code is incorrect. Please re-enter!", "Forgot Password");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Hide();
            Application.Restart();
        }
        private void txtBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxVertificationCode.Text.Trim() == veritificationCode && txtBoxNewPassword.Text.Trim() == txtBoxConfirmPassword.Text.Trim())
            {
                resetPasswordButton.Enabled = true;
            }
            else
            {
                resetPasswordButton.Enabled = false;
            }
        }
    }
}
