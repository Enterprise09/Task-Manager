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

namespace Todo_List_Framework.ucPanel
{
    public partial class ucJobList : UserControl
    {
        public ucJobList()
        {
            InitializeComponent();
        }

        private SqlConnection conn =
            new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Documents\\DataBase.mdf;Integrated Security=True;Connect Timeout=30");
        private String query = null;

        private void pb_addJob_Click(object sender, EventArgs e)
        {
            (new AddJobForm()).ShowDialog();
        }    

        private void ucJobList_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            Console.WriteLine("Login state : " + LoginSession.isLogin.ToString());
            refreshData();
        }

        public void refreshData()
        {
            conn.Open();
            query = "select * from job where Id = @id order by endline asc";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", LoginSession.id);
            SqlDataReader reader = command.ExecuteReader();
            int x = 52;
            int y = 500;
            bool toggle = true;
            while (reader.Read())
            {
                Console.WriteLine("JobList from : " + reader[1].ToString());

                ucView.JobView viewer = new ucView.JobView();
                //viewer.CreateControl();

                viewer.lbl_from.Text = reader[1].ToString();
                if (reader[2].ToString() == "complete")
                {
                    viewer.lbl_state_img.Image = Properties.Resources.complete;
                    viewer.BackColor = Color.FromArgb(241, 254, 241);
                }
                else if (reader[2].ToString() == "not yet")
                {
                    viewer.lbl_state_img.Image = Properties.Resources.notyet;
                    viewer.BackColor = Color.FromArgb(255, 235, 235);
                }
                else
                {
                    viewer.lbl_state_img.Image = Properties.Resources.process_state;
                    viewer.BackColor = Color.FromArgb(225, 225, 255);
                }
                viewer.lbl_endLine.Text = reader[3].ToString().Substring(0, 10);
                viewer.lbl_request.Text = reader[4].ToString();
                if (toggle)
                {
                    y = 500;
                }
                else
                {
                    y = 120;
                }
                toggle = !toggle;
                viewer.Location = new Point(x, y);
                this.Controls.Add(viewer);
                x += 250;
            }
            conn.Close();
            Console.WriteLine("connection close()");
            if(x < 1376)
            {
                x = 1376;
            }
            else
            {
                this.Width = x + 42;
            }
            
        }
    }
}
