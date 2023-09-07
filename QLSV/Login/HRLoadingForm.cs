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
    public partial class HRLoadingForm : Form
    {
        public HRLoadingForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
                lblPercent.Text = "Loading " + progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                this.Hide();
                HRMainForm mainForm = new HRMainForm();
                mainForm.Show();
            }
        }

        private void HRLoadingForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
