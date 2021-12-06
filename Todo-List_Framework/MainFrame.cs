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
        public MainFrame()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.lbl_profile_name.Text = LoginSession.id.ToUpper();
            this.lbl_profile_email.Text = LoginSession.id + "@gmail.com";
            this.mainPanel.Controls.Add(new ucPanel.ucDashboard());
            Console.WriteLine("Login state : " + LoginSession.isLogin.ToString());
        }
        
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "종료",
                "종료하시겠습니까?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
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
            this.mainPanel.Controls.Add(new ucPanel.ucDashboard());
            this.Indicator.Location = new Point(0, 333);
        }

        private void lbl_jobList_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(new ucPanel.ucJobList());
            this.Indicator.Location = new Point(0, 421);
        }


        private void lbl_notePad_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(new ucPanel.ucNotepad());
            this.Indicator.Location = new Point(0, 509);
        }

        private void lbl_contact_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(new ucPanel.ucContact());
            this.Indicator.Location = new Point(0, 597);
        }

        private void lbl_setting_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.ShowDialog();
        }

        private void lbl_lobout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "로그아웃", 
                "로그아웃 하시겠습니까?", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Information);
            if(result == DialogResult.Yes)
            {
                LoginSession.id = "";
                LoginSession.isLogin = false;
                this.Hide();
                (new LoginForm()).Show();
                //this.Close();
            }
        }
    }
}
