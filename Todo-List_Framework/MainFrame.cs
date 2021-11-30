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
    public partial class MainFrame : Form
    {

        ucPanel.ucHome ucHome = new ucPanel.ucHome();
        ucPanel.ucJobList ucJobList = new ucPanel.ucJobList();
        ucPanel.ucNotepad ucNotepad = new ucPanel.ucNotepad();
        ucPanel.ucContact ucContact = new ucPanel.ucContact();

        public MainFrame()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Add(ucHome);
        }

        private void lbl_jobList_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(ucJobList);
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_notePad_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(ucNotepad);
        }

        private void lbl_addJob_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(ucContact);
        }
    }
}
