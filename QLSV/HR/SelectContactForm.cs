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
    public partial class SelectContactForm : Form
    {
        public SelectContactForm()
        {
            InitializeComponent();
        }
        Contact contact = new Contact();
        private void SelectContactForm_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = contact.selectContact("SELECT id AS [Contact ID], CONCAT(fname,' ',lname) AS [Full Name], group_id AS [Group ID] FROM MyContact WHERE userid = @userid", Global.GlobalUserID);
        }
    }
}
