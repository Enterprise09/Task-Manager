using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo_List_Framework.ucPanel
{
    public partial class ucJobList : UserControl
    {
        public ucJobList()
        {
            InitializeComponent();
        }

        private void pb_addJob_Click(object sender, EventArgs e)
        {
            (new AddJobForm()).ShowDialog();
        }
    }
}
