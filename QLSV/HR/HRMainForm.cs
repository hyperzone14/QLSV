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
    public partial class HRMainForm : Form
    {
        Group group = new Group();
        MY_DB mydb = new MY_DB();
        public HRMainForm()
        {
            InitializeComponent();
        }
        public void getImageAndUsername()
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
                pictureBox1.Image = Image.FromStream(picture);
                string fname = (string)table.Rows[0]["f_name"];
                string lname = (string)table.Rows[0]["l_name"];
                labelWelcome.Text = "Welcome Back " + fname.Trim() + " " + lname.Trim();
            }
        }

        private void HRMainForm_Load(object sender, EventArgs e)
        {
            getImageAndUsername();
            getGroup();
        }
        private void labelEditInfo_Click_1(object sender, EventArgs e)
        {
            EditMyInfoForm editMyInfoForm = new EditMyInfoForm();
            editMyInfoForm.ShowDialog();
        }
        public void getGroup()
        {
            txtBoxAddGroupName.Clear();
            txtBoxNewGroupName.Clear();
            comboBoxGroupNameEdit.DataSource = group.getGroup(Global.GlobalUserID);
            comboBoxGroupNameEdit.DisplayMember = "name";
            comboBoxGroupNameEdit.ValueMember = "id";
            comboBoxGroupNameEdit.SelectedItem = null;
            comboBoxGroupNameRemove.DataSource = group.getGroup(Global.GlobalUserID);
            comboBoxGroupNameRemove.DisplayMember = "name";
            comboBoxGroupNameRemove.ValueMember = "id";
            comboBoxGroupNameRemove.SelectedItem = null;
        }

        private void addGroupButton_Click(object sender, EventArgs e)
        {
            string groupName = txtBoxAddGroupName.Text;
            if (!groupName.Trim().Equals(""))
            {
                if (!group.groupNameExist(groupName, "add", Global.GlobalUserID))
                {
                    try
                    {
                        if (group.insertGroup(groupName, Global.GlobalUserID))
                        {
                            getGroup();
                            MessageBox.Show("New Group Added", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else
                {
                    MessageBox.Show("The group name already exists.\nPlease enter another group name!", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter the name of the group you want to add!", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void editGroupButton_Click(object sender, EventArgs e)
        {
            string newGroupName = txtBoxNewGroupName.Text;
            int groupID = Convert.ToInt32(comboBoxGroupNameEdit.SelectedValue.ToString().Trim());
            if (!newGroupName.Trim().Equals(""))
            {
                try
                {
                    if (!group.groupNameExist(newGroupName, "edit", Global.GlobalUserID, groupID))
                    {
                        try
                        {
                            if (group.updateGroup(newGroupName, groupID))
                            {
                                getGroup();
                                MessageBox.Show("Group Edited", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    else
                    {
                        MessageBox.Show("The group name already exists.\nPlease enter another group name!", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please enter the name of the group you want to edit!", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void removeGroupButton_Click(object sender, EventArgs e)
        {
            int groupID = Convert.ToInt32(comboBoxGroupNameRemove.SelectedValue.ToString().Trim());

            if (MessageBox.Show("Are You Sure You Want To Delete This Group", "Remove Group", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (group.deleteGroup(groupID))
                    {
                        getGroup();
                        MessageBox.Show("Group Deleted", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Remive Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }


        private void labelLogout_Click(object sender, EventArgs e)
        {
            Hide();
            Application.Restart();
        }

        private void labelRefresh_Click(object sender, EventArgs e)
        {
            getImageAndUsername();
        }

        private void addContactButton_Click(object sender, EventArgs e)
        {
            AddContactForm addContactForm = new AddContactForm();
            addContactForm.ShowDialog();
        }

        private void editContactButton_Click(object sender, EventArgs e)
        {
            EditContactForm editContactForm = new EditContactForm();
            editContactForm.ShowDialog();
        }

        private void selectContactButton_Click(object sender, EventArgs e)
        {
            SelectContactForm selectContactForm = new SelectContactForm();
            selectContactForm.ShowDialog();
        }

        private void removeContactButton_Click(object sender, EventArgs e)
        {
            int contactID = Convert.ToInt32(txtRemoveContact.Text);
            
            if (MessageBox.Show("Are You Sure You Want To Delete This Contact", "Remove Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (group.deleteGroup(contactID))
                    {
                        getGroup();
                        MessageBox.Show("Group Deleted", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Remive Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Remove Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void showFullListButton_Click(object sender, EventArgs e)
        {
            ShowFullContact show = new ShowFullContact();
            show.Show();
        }

      
    }
}
