using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Todo_List_Framework
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pb_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new MainFrame()).Show();
            //this.Close();
        }

        private void lbl_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new RegisterForm()).Show();
            //this.Close();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
