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
    public partial class AddJobForm : Form
    {
        public AddJobForm()
        {
            InitializeComponent();
        }

        private SqlConnection conn = 
            new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Documents\\DataBase.mdf;Integrated Security=True;Connect Timeout=30");
        private String query = null;
        private String state = "";

        private void AddJob_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lbl_jobTitle;
        }

        private void insertJob_button_Click(object sender, EventArgs e)
        {
            conn.Open();
            query = "insert into Job values(@id, @from, @state, @endline, @request)";
            SqlCommand command = new SqlCommand(query, conn);

            for (var i = 0; i < this.state_group.Controls.Count; i++)
            {
                RadioButton temp = (RadioButton)this.state_group.Controls[i];
                if (temp.Checked)
                {
                    state = temp.Text;
                    break;
                }
            }
            
            command.Parameters.AddWithValue("@id", LoginSession.id);
            command.Parameters.AddWithValue("@from", this.tb_from.Text);
            command.Parameters.AddWithValue("@state", this.state);
            command.Parameters.AddWithValue("@endline", this.tb_endline.Text);
            command.Parameters.AddWithValue("@request", this.tb_request.Text);
            int result = command.ExecuteNonQuery();
            conn.Close();

            if(result == 1)
            {
                MessageBox.Show("새로운 일을 추가하였습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.Close();
            }
            else
            {
                MessageBox.Show("오류가 발생하였습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            

            
        }

        private void tb_from_Enter(object sender, EventArgs e)
        {
            if(tb_from.Text == "From")
            {
                tb_from.Text = "";
            }
        }

        private void tb_from_Leave(object sender, EventArgs e)
        {
            if(tb_from.Text == "")
            {
                tb_from.Text = "From";
            }
        }

        private void tb_endline_Enter(object sender, EventArgs e)
        {
            if (tb_endline.Text == "End Line")
            {
                tb_endline.Text = "";
            }
        }

        private void tb_endline_Leave(object sender, EventArgs e)
        {
            if (tb_endline.Text == "")
            {
                tb_endline.Text = "End Line";
            }
        }

        private void tb_request_Enter(object sender, EventArgs e)
        {
            if (tb_request.Text == "Request")
            {
                tb_request.Text = "";
            }
        }

        private void tb_request_Leave(object sender, EventArgs e)
        {
            if (tb_request.Text == "")
            {
                tb_request.Text = "Request";
            }
        }

        private void AddJob_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
