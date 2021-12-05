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
    public partial class JobView : UserControl
    {
        public JobView()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private SqlConnection conn =
            new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Documents\\DataBase.mdf;Integrated Security=True;Connect Timeout=30");
        private String query = null;

        private void lbl_del_button_Click(object sender, EventArgs e)
        {
            conn.Open();
            query = "delete from Job where Id = @id and request = @request";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", "ent");
            command.Parameters.AddWithValue("@request", lbl_request.Text);
            int result = command.ExecuteNonQuery();
            if (result == 1)
            {
                Console.WriteLine("delete Job : " + lbl_request.Text);
                MessageBox.Show("삭제 되었습니다.", "업무 삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("삭제에 실패하였습니다.", "업무 삭제", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }
    }
}
