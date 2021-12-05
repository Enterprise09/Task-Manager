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

namespace Todo_List_Framework.ucView
{
    public partial class ContactView : UserControl
    {
        public ContactView()
        {
            InitializeComponent();
        }

        private SqlConnection conn =
            new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Documents\\DataBase.mdf;Integrated Security=True;Connect Timeout=30");
        private String query = null;

        private void ContactView_Click(object sender, EventArgs e)
        {

        }

        private void pb_delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            query = "delete from Contact where Id = @id and contact_phone = @phone";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", "ent");
            command.Parameters.AddWithValue("@phone", this.lbl_phone.Text);
            int result = command.ExecuteNonQuery();
            if(result == 1)
            {
                Console.WriteLine("Delete contact : " + lbl_phone.Text);
                MessageBox.Show("삭제 되었습니다.", "연락처 삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("삭제에 실패하였습니다.", "연락처 삭제", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }
    }
}
