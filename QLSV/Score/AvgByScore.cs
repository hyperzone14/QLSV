using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLSV
{
    public partial class AvgByScore : Form
    {
        public AvgByScore()
        {
            InitializeComponent();
        }

        private void AvgByScore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSetAvgScore1.AverageScore' table. You can move, or remove it, as needed.
            this.averageScoreTableAdapter.Fill(this.qLSVDataSetAvgScore1.AverageScore);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                    }
    }
}
