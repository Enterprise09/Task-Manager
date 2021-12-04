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
            Console.WriteLine("ucJobList Loading");
            conn.Open();
            query = "select * from job where Id = @id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", "ent");
            SqlDataReader reader = command.ExecuteReader();
            int x = 42;
            int y = 500;
            while (reader.Read())
            {
                Console.WriteLine("JobList from : " + reader[1].ToString());

                ucView.JobView viewer = new ucView.JobView();
                viewer.CreateControl();
                
                viewer.lbl_from.Text = reader[1].ToString();
                if (reader[2].ToString() == "complete")
                {
                    viewer.lbl_state_img.Image = Properties.Resources.complete;
                    viewer.BackColor = Color.FromArgb(241, 254, 241);
                }
                else
                {
                    viewer.lbl_state_img.Image = Properties.Resources.notyet;
                    viewer.BackColor = Color.FromArgb(255, 235, 235);
                }
                viewer.lbl_endLine.Text = reader[3].ToString();
                viewer.lbl_request.Text = reader[4].ToString();
                viewer.Location = new Point(x, y);
                this.Controls.Add(viewer);
                x += 414;
            }
        }
    }
}
