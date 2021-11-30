using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Todo_List
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void lbl_dashboard_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "Dashboard";
            form.Show();
        }

        private void lbl_joblist_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "JobList";
            form.Show();
        }

        private void lbl_addjob_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "AddJob";
            form.Show();
        }

        private void lbl_notepad_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "Notepad";
            form.Show();
        }
    }
}
