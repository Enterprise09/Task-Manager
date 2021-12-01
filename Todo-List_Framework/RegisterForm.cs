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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "경고",
                "종료하시겠습니까?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if(result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
                return;
            }
        }

        private void pb_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new LoginForm()).Show();
        }
    }
}
