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
    public partial class ucDashboard : UserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
        }

        Random random = new Random();
        private SqlConnection conn =
            new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Documents\\DataBase.mdf;Integrated Security=True;Connect Timeout=30");
        private String query = null;
        private int completeCount = 0;
        private int processCount = 0;
        private int notYetCount = 0;

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            conn.Open();
            query = "select state from Job where Id = @id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", "ent");
            SqlDataReader reader = command.ExecuteReader();

            /*
                state값을 가져오면서
                state값을 판별 각각의 카운트 증가
            
                state 카운트를 차트에 추가
            */

            while (reader.Read())
            {
                if(reader[0].ToString() == "complete")
                {
                    completeCount++;
                }else if(reader[0].ToString() == "not yet")
                {
                    notYetCount++;
                }
                else
                {
                    processCount++;
                }
            }

            conn.Close();

            personal_chart.Series["Series1"].Points.Add(completeCount);
            personal_chart.Series["Series1"].Points.Add(notYetCount);
            personal_chart.Series["Series1"].Points.Add(processCount);

            this.personal_chart.Series["Series1"].Points[0].LegendText = "완료";
            this.personal_chart.Series["Series1"].Points[0].Color = Color.Green;

            this.personal_chart.Series["Series1"].Points[1].LegendText = "진행 중";
            this.personal_chart.Series["Series1"].Points[1].Color = Color.Blue;

            this.personal_chart.Series["Series1"].Points[2].LegendText = "해야할 일";
            this.personal_chart.Series["Series1"].Points[2].Color = Color.Red;
        }
    }
}
