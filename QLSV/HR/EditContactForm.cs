using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace QLSV
{
    public partial class EditContactForm : Form
    {
        public EditContactForm()
        {
            InitializeComponent();
        }
        Contact contact = new Contact();
        Group group = new Group();
        MY_DB mydb = new MY_DB();
        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void getGroup()
        {
            comboBoxGroup.DataSource = group.getGroup(Global.GlobalUserID);
            comboBoxGroup.DisplayMember = "name";
            comboBoxGroup.ValueMember = "id";
            comboBoxGroup.SelectedItem = null;
        }
        void fillSelectContact()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM MyContact WHERE id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(txtContactID.Text);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                txtBoxFname.Text = table.Rows[0]["fname"].ToString().Trim();
                txtBoxLname.Text = table.Rows[0]["lname"].ToString().Trim();
                txtBoxEmail.Text = table.Rows[0]["email"].ToString().Trim();
                txtBoxAddress.Text = table.Rows[0]["address"].ToString().Trim();
                txtBoxPhone.Text = table.Rows[0]["phone"].ToString().Trim();
                comboBoxGroup.SelectedValue = Convert.ToInt32(table.Rows[0]["group_id"].ToString().Trim());
                byte[] pic = (byte[])table.Rows[0]["pic"];
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxImage.Image = Image.FromStream(picture);
            }
        }
        private void selectContactButton_Click(object sender, EventArgs e)
        {
            fillSelectContact();
        }
        bool verIf()
        {
            if (txtBoxFname.Text.Trim() == "" || txtBoxLname.Text.Trim() == "" || txtBoxEmail.Text.Trim() == "" || comboBoxGroup.Text.Trim() == "" || txtBoxPhone.Text.Trim() == "" || txtBoxAddress.Text.Trim() == "" || PictureBoxImage.Image == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void editContactButton_Click(object sender, EventArgs e)
        {
            int contactID = Convert.ToInt32(txtContactID.Text);
            string fname = txtBoxFname.Text;
            string lname = txtBoxLname.Text;
            int groupid = Convert.ToInt32(comboBoxGroup.SelectedValue.ToString().Trim());
            string phone = txtBoxPhone.Text;
            string email = txtBoxEmail.Text;
            string address = txtBoxAddress.Text;
            MemoryStream picture = new MemoryStream();
            if (verIf())
            {
                MessageBox.Show("Please fill in all the information!", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                if (!contact.MailGroupExist(groupid, email, "edit", contactID))
                {
                    try
                    {
                        PictureBoxImage.Image.Save(picture, PictureBoxImage.Image.RawFormat);
                        if (contact.updateContact(contactID, fname, lname, groupid, phone, email, address, picture))
                        {
                            txtBoxFname.Clear();
                            txtBoxLname.Clear();
                            txtBoxEmail.Clear();
                            txtBoxAddress.Clear();
                            txtBoxPhone.Clear();
                            comboBoxGroup.SelectedItem = null;
                            PictureBoxImage.Image = null;
                            txtContactID.Clear();
                            MessageBox.Show("Contact Edited", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Email already exists in group " + comboBoxGroup.Text + "!", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void EditContactForm_Load(object sender, EventArgs e)
        {
            getGroup();
        }
    }
}
