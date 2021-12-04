using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private SqlConnection conn =
            new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Documents\\DataBase.mdf;Integrated Security=True;Connect Timeout=30");
        private String query = null;

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lbl_welcome;
        }

        private void pb_register_Click(object sender, EventArgs e)
        {
            if (tb_password.Text.Equals(tb_checkpw.Text))
            {
                conn.Open();
                query = "insert into UserInfo values(@id, @password, @phone, @age, @gender, @job)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", tb_id.Text);
                command.Parameters.AddWithValue("@password", tb_password.Text);
                command.Parameters.AddWithValue("@phone", tb_phone.Text);
                command.Parameters.AddWithValue("@age", tb_age.Text);
                command.Parameters.AddWithValue("@gender", tb_gender.Text);
                command.Parameters.AddWithValue("@job", tb_job.Text);
                int result = command.ExecuteNonQuery();
                conn.Close();
                if(result == 1)
                {
                    MessageBox.Show("회원가입", "회원가입에 성공하였습니다.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    (new LoginForm()).Show();
                }
                else
                {
                    MessageBox.Show("회원가입", "회원가입에 실패하였습니다.\n관리자에게 문의해주세요.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("비밀번호 확인", "비밀번호가 일치하지 않습니다.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void tb_id_Enter(object sender, EventArgs e)
        {
            if(tb_id.Text == "id or email")
            {
                tb_id.Text = "";
                tb_id.ForeColor = Color.Black;
            }
        }

        private void tb_id_Leave(object sender, EventArgs e)
        {
            if (tb_id.Text == "")
            {
                tb_id.Text = "id or email";
                tb_id.ForeColor = Color.Silver;
            }
        }

        private void tb_password_Enter(object sender, EventArgs e)
        {
            if (tb_password.Text == "password")
            {
                tb_password.Text = "";
                tb_password.ForeColor = Color.Black;
            }
        }

        private void tb_password_Leave(object sender, EventArgs e)
        {
            if (tb_password.Text == "")
            {
                tb_password.Text = "password";
                tb_password.ForeColor = Color.Silver;
            }
        }

        private void tb_checkpw_Enter(object sender, EventArgs e)
        {
            if (tb_checkpw.Text == "check password")
            {
                tb_checkpw.Text = "";
                tb_checkpw.ForeColor = Color.Black;
            }
        }

        private void tb_checkpw_Leave(object sender, EventArgs e)
        {
            if (tb_checkpw.Text == "")
            {
                tb_checkpw.Text = "check password";
                tb_checkpw.ForeColor = Color.Silver;
            }
        }

        private void tb_phone_Enter(object sender, EventArgs e)
        {
            if (tb_phone.Text == "phone number")
            {
                tb_phone.Text = "";
                tb_phone.ForeColor = Color.Black;
            }
        }

        private void tb_phone_Leave(object sender, EventArgs e)
        {
            if (tb_phone.Text == "")
            {
                tb_phone.Text = "phone number";
                tb_phone.ForeColor = Color.Silver;
            }
        }

        private void tb_age_Enter(object sender, EventArgs e)
        {
            if (tb_age.Text == "age")
            {
                tb_age.Text = "";
                tb_age.ForeColor = Color.Black;
            }
        }

        private void tb_age_Leave(object sender, EventArgs e)
        {
            if (tb_age.Text == "")
            {
                tb_age.Text = "age";
                tb_age.ForeColor = Color.Silver;
            }
        }

        private void tb_gender_Enter(object sender, EventArgs e)
        {
            if (tb_gender.Text == "gender")
            {
                tb_gender.Text = "";
                tb_gender.ForeColor = Color.Black;
            }
        }

        private void tb_gender_Leave(object sender, EventArgs e)
        {
            if (tb_gender.Text == "")
            {
                tb_gender.Text = "gender";
                tb_gender.ForeColor = Color.Silver;
            }
        }

        private void tb_job_Enter(object sender, EventArgs e)
        {
            if (tb_job.Text == "job")
            {
                tb_job.Text = "";
                tb_job.ForeColor = Color.Black;
            }
        }

        private void tb_job_Leave(object sender, EventArgs e)
        {
            if (tb_job.Text == "")
            {
                tb_job.Text = "job";
                tb_job.ForeColor = Color.Silver;
            }
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
