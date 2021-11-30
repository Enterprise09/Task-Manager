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
    public partial class Addjob : Form
    {
        public Addjob()
        {
            InitializeComponent();
        }

        private void Addjob_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
