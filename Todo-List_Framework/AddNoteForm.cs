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
    public partial class AddNoteForm : Form
    {
        public AddNoteForm()
        {
            InitializeComponent();
        }

        private SqlConnection conn =
            new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Documents\\DataBase.mdf;Integrated Security=True;Connect Timeout=30");
        private String query = null;

        private void AddNoteForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.lbl_noteTitle;
        }

        private void pb_addNote_Click(object sender, EventArgs e)
        {
            conn.Open();
            query = "insert into Note values(@id, @content, @register_date)";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", "ent");
            command.Parameters.AddWithValue("@content", tb_content.Text);
            command.Parameters.AddWithValue("@register_date", DateTime.Now.ToString("yyyy-MM-dd"));

            int result = command.ExecuteNonQuery();
            conn.Close();
            if (result == 1) {
                MessageBox.Show("노트를 성공적으로 추가하였습니다.", "노트 추가", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("노트를 추가하지 못했습니다.", "노트 추가 실패", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tb_content_Enter(object sender, EventArgs e)
        {
            if(tb_content.Text == "Content")
            {
                tb_content.Text = "";
            }
        }

        private void tb_content_Leave(object sender, EventArgs e)
        {
            if (tb_content.Text == "")
            {
                tb_content.Text = "Content";
            }
        }
    }
}
