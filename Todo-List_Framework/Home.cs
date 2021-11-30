using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo_List_Framework
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            for(int i = 1; i <=3; i++)
            {
                this.chart1.Series["Series1"].Points.Add(random.Next(500));
            }            
        }

        private void lbl_jobList_Click(object sender, EventArgs e)
        {
            this.Hide();
            JobList jobList = new JobList();
            jobList.Show();
            
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
