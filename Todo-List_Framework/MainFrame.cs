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

        ucPanel.ucDashboard ucDashboard = new ucPanel.ucDashboard();
        ucPanel.ucJobList ucJobList = new ucPanel.ucJobList();
        ucPanel.ucNotepad ucNotepad = new ucPanel.ucNotepad();
        ucPanel.ucContact ucContact = new ucPanel.ucContact();

        public MainFrame()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Add(ucDashboard);
        }

        
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "경고",
                "종료하시겠습니까?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
                return;
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_dashboard_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(ucDashboard);
            this.Indicator.Location = new Point(0, 333);
        }

        private void lbl_jobList_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(ucJobList);
            this.Indicator.Location = new Point(0, 421);
        }


        private void lbl_notePad_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(ucNotepad);
            this.Indicator.Location = new Point(0, 509);
        }

        private void lbl_contact_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(ucContact);
            this.Indicator.Location = new Point(0, 597);
        }

        private void lbl_setting_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.ShowDialog();
        }
    }
}
