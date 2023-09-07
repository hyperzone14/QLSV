using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class ShowFullContact : Form
    {
        MY_DB mydb = new MY_DB();
        public ShowFullContact()
        {
            InitializeComponent();
        }
        Contact contact = new Contact();
        Group group = new Group();
        int pos;
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        void getGroup()
        {
            listBoxGroup.DataSource = group.getGroup(Global.GlobalUserID);
            listBoxGroup.ValueMember = "id";
            listBoxGroup.DisplayMember = "name";
            //Show Total Group
            labelTotalGroup.Text = "Total Group: " + group.totalGroup(Global.GlobalUserID);
        }
        void fillGrid(string feature)
        {
            dataGridView.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView.RowTemplate.Height = 80;
            dataGridView.DataSource = contact.selectContactList(feature);
            picCol = (DataGridViewImageColumn)dataGridView.Columns[6];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView.AllowUserToAddRows = false;
        }
        private void ShowFullContact_Load(object sender, EventArgs e)
        {
            getGroup();
            fillGrid("SELECT fname AS [First Name], lname AS [Last Name], [name] AS [Group Name], phone AS [Phone], email AS [Email], [address] AS [Address], pic AS [Image] FROM MyContact INNER JOIN MyGroup ON MyContact.group_id = MyGroup.id and MyContact.userid = MyGroup.userid WHERE MyContact.userid=" + Global.GlobalUserID);
        }

        private void listBoxGroup_Click(object sender, EventArgs e)
        {
            //display the selected course data
            pos = Convert.ToInt32(listBoxGroup.SelectedValue.ToString().Trim());
            fillGrid("SELECT fname AS [First Name], lname AS [Last Name], [name] AS [Group Name], phone AS [Phone], email AS [Email], [address] AS [Address], pic AS [Image] FROM MyContact INNER JOIN MyGroup ON MyContact.group_id = MyGroup.id and MyContact.userid = MyGroup.userid WHERE MyContact.userid= " + Global.GlobalUserID + " and MyContact.group_id=" + pos);
        }

        private void showFullButton_Click(object sender, EventArgs e)
        {
            fillGrid("SELECT fname AS [First Name], lname AS [Last Name], [name] AS [Group Name], phone AS [Phone], email AS [Email], [address] AS [Address], pic AS [Image] FROM MyContact INNER JOIN MyGroup ON MyContact.group_id = MyGroup.id and MyContact.userid = MyGroup.userid WHERE MyContact.userid=" + Global.GlobalUserID);
        }

        private void txtBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            fillGrid("SELECT fname AS [First Name], lname AS [Last Name], [name] AS [Group Name], phone AS [Phone], email AS [Email], [address] AS [Address], pic AS [Image] FROM MyContact INNER JOIN MyGroup ON MyContact.group_id = MyGroup.id and MyContact.userid = MyGroup.userid WHERE MyContact.userid=" + Global.GlobalUserID + " and MyContact.[address] LIKE '%" + txtBoxSearch.Text.Trim() + "%'");
        }
       
    }
}
