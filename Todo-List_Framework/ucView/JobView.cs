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

        private void lbl_state_img_Click(object sender, EventArgs e)
        {
            /*
                현재 색깔을 확인 후 
                1. 초록색 (complete) 상태 -> 빨간색 (not yet) 으로 DB변경
                2. 빨간색 (not yet) 상태 -> 파란색 (process) 으로 DB변경
                3. 파란색 (process) 상태 -> 초록색 (complete) 으로 DB변경
            */
            conn.Open();
            query = "select state from Job where Id = @id and request = @request";    
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", LoginSession.id);
            command.Parameters.AddWithValue("@request", lbl_request.Text);

            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            if(reader[0].ToString() == "complete")
            {
                query = "update Job set state = 'not yet' where Id = @id and request = @request";
            }else if(reader[0].ToString() == "not yet")
            {
                query = "update Job set state = 'process' where Id = @id and request = @request";
            }
            else
            {
                query = "update Job set state = 'complete' where Id = @id and request = @request";
            }

            reader.Close();

            SqlCommand updateComm = new SqlCommand(query, conn);
            updateComm.Parameters.AddWithValue("@id", LoginSession.id);
            updateComm.Parameters.AddWithValue("@request", lbl_request.Text);
            int result = updateComm.ExecuteNonQuery();
            if(result == 1)
            {
                MessageBox.Show("상태가 변경되었습니다. 새로고침 해주세요", "업무 상태 변경", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("상태 변경 중 오류가 발생하였습니다.", "업무 상태 변경", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
    }
}
