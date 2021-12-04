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
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }

        private SqlConnection conn =
            new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Documents\\DataBase.mdf;Integrated Security=True;Connect Timeout=30");
        private String query = null;

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lbl_contactTitle;
        }

        private void pb_addContact_Click(object sender, EventArgs e)
        {
            conn.Open();
            query = "insert into Contact values(@id, @who, @contact_phone, @contact_note)";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", "ent");
            command.Parameters.AddWithValue("@who", tb_who.Text);
            command.Parameters.AddWithValue("@contact_phone", tb_phone.Text);
            command.Parameters.AddWithValue("@contact_note", tb_note.Text);
            int result = command.ExecuteNonQuery();
            conn.Close();
            if (result == 1)
            {
                MessageBox.Show("연락처를 성공적으로 추가하였습니다.", "연락처 추가", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("연락처를 추가하지 못했습니다.", "연락처 추가 실패", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tb_who_Enter(object sender, EventArgs e)
        {
            if(tb_who.Text == "who")
            {
                tb_who.Text = "";
            }
        }

        private void tb_who_Leave(object sender, EventArgs e)
        {
            if (tb_who.Text == "")
            {
                tb_who.Text = "who";
            }
        }

        private void tb_phone_Enter(object sender, EventArgs e)
        {
            if (tb_who.Text == "phone")
            {
                tb_who.Text = "";
            }
        }

        private void tb_phone_Leave(object sender, EventArgs e)
        {
            if (tb_who.Text == "")
            {
                tb_who.Text = "phone";
            }
        }

        private void tb_note_Enter(object sender, EventArgs e)
        {
            if (tb_who.Text == "note")
            {
                tb_who.Text = "";
            }
        }

        private void tb_note_Leave(object sender, EventArgs e)
        {
            if (tb_who.Text == "")
            {
                tb_who.Text = "note";
            }
        }
    }
}
