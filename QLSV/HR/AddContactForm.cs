using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }
        Contact contact = new Contact();
        Group group = new Group();
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

        private void addContactButton_Click(object sender, EventArgs e)
        {
            MemoryStream pic = new MemoryStream();
            if (verIf())
            {
                MessageBox.Show("Please fill in all the information!", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string fname = txtBoxFname.Text;
                string lname = txtBoxLname.Text;
                int group_id = Convert.ToInt32(comboBoxGroup.SelectedValue.ToString().Trim());
                string phone = txtBoxPhone.Text;
                string email = txtBoxEmail.Text;
                string address = txtBoxAddress.Text;
                if (!contact.MailGroupExist(group_id, email, "add"))
                {
                    try
                    {
                        PictureBoxImage.Image.Save(pic, PictureBoxImage.Image.RawFormat);
                        if (contact.insertContact(fname, lname, group_id, phone, email, address, pic, Global.GlobalUserID))
                        {
                            txtBoxFname.Clear();
                            txtBoxLname.Clear();
                            txtBoxEmail.Clear();
                            txtBoxAddress.Clear();
                            txtBoxPhone.Clear();
                            comboBoxGroup.SelectedItem = null;
                            PictureBoxImage.Image = null;
                            MessageBox.Show("New Contact Added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Email already exists in group " + comboBoxGroup.Text + "!", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

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

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            getGroup();
        }
    }
}