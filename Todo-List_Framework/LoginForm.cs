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
using System.Data.SqlClient;

namespace Todo_List_Framework
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private SqlConnection conn =
            new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Documents\\DataBase.mdf;Integrated Security=True;Connect Timeout=30");
        private String query = null;

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label3;    //remove auto focus at text box
        }

        private void pb_login_Click(object sender, EventArgs e)
        {
            conn.Open();
            String id = tb_login_id.Text;
            String pw = tb_login_pw.Text;
            query = "select id, password from UserInfo where id = '" + id + "'";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                if (id.Equals(reader[0]))
                {
                    if (pw.Equals(reader[1]))
                    {
                        LoginSession.id = reader[0].ToString();
                        LoginSession.isLogin = true;
                        this.Hide();
                        (new MainFrame()).Show();
                        //this.Close();
                        Console.WriteLine("id : " + reader[0] + "\tpassword : " + reader[1]);
                    }
                    else
                    {
                        Console.WriteLine("로그인 실패 : 비밀번호 불일치");
                        MessageBox.Show("로그인 실패", "비밀번호가 일치하지 않습니다.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    Console.WriteLine("로그인 실패 : 일치하는 아이디 없음");
                    MessageBox.Show("로그인 실패", "아이디가 일치하지 않습니다.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                Console.WriteLine("로그인 실패 : 회원 정보 없음");
                MessageBox.Show("정보없음", "회원정보가 존재하지 않습니다.\n회원가입을 진행해주세요.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
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

        private void tb_login_id_Enter(object sender, EventArgs e)
        {
            if(tb_login_id.Text == "id or email")
            {
                tb_login_id.Text = "";
                tb_login_id.ForeColor = Color.Black;
            }
        }

        private void tb_login_id_Leave(object sender, EventArgs e)
        {
            if(tb_login_id.Text == "")
            {
                tb_login_id.Text = "id or email";
                tb_login_id.ForeColor = Color.Silver;
            }
        }

        private void tb_login_pw_Enter(object sender, EventArgs e)
        {
            if(tb_login_pw.Text == "password")
            {
                tb_login_pw.Text = "";
                tb_login_pw.ForeColor = Color.Black;
            }
        }

        private void tb_login_pw_Leave(object sender, EventArgs e)
        {
            if(tb_login_pw.Text == "")
            {
                tb_login_pw.Text = "password";
                tb_login_pw.ForeColor = Color.Silver;
            }
        }
    }
}
