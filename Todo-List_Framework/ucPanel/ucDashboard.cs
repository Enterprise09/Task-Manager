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
        private int rowsCount = 0;

        private TableLayoutPanel tableLayoutPanel;

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Login state : " + LoginSession.isLogin.ToString());
            conn.Open();
            query = "select state from Job where Id = @id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", LoginSession.id);
            SqlDataReader reader = command.ExecuteReader();

            /*
                state값을 가져오면서
                state값을 판별 각각의 카운트 증가
            
                state 카운트를 차트에 추가
            */

            while (reader.Read())
            {
                rowsCount++;
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

            reader.Close();
            displayToChart();

            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.ColumnCount = 2;

            query = "select * from Job where Id = @id";
            command.CommandText = query;
            int rows = 0;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Label lbl_from = new Label();
                lbl_from.Text = reader[1].ToString();      // From
                lbl_from.Font = new Font("MesloLGS NF", 17F, FontStyle.Bold);
                lbl_from.ForeColor = Color.FromArgb(64, 64, 64);
                lbl_from.TextAlign = ContentAlignment.MiddleLeft;
                lbl_from.Size = new Size(100, 40);

                Label lbl_state = new Label();
                if(reader[2].ToString() == "complete")
                {
                    lbl_state.Image = Properties.Resources.complete;
                }else if(reader[2].ToString() == "not yet")
                {
                    lbl_state.Image = Properties.Resources.notyet;
                }
                else
                {
                    lbl_state.Image = Properties.Resources.process_state;
                }
                lbl_state.ImageAlign = ContentAlignment.MiddleCenter;
                lbl_state.Size = new Size(28, 28);

                tableLayoutPanel.Controls.Add(lbl_from);
                tableLayoutPanel.Controls.Add(lbl_state);
                rows++;
            }

            tableLayoutPanel.ColumnStyles.Clear();
            tableLayoutPanel.RowStyles.Clear();
            tableLayoutPanel.Padding = new Padding(30);
            tableLayoutPanel.BackColor = Color.FromArgb(229, 229, 249);
            tableLayoutPanel.Location = new Point(700, 131);
            tableLayoutPanel.Size = new Size(500, 627);
            this.Controls.Add(tableLayoutPanel);

            conn.Close();

        }

        private void displayToChart()
        {
            if (completeCount == 0)
            {
                personal_chart.Series["Series1"].Points.Add(rowsCount - notYetCount);
                personal_chart.Series["Series1"].Points.Add(rowsCount - processCount);

                this.personal_chart.Series["Series1"].Points[0].LegendText = "진행 중";
                this.personal_chart.Series["Series1"].Points[0].Color = Color.Blue;

                this.personal_chart.Series["Series1"].Points[1].LegendText = "해야할 일";
                this.personal_chart.Series["Series1"].Points[1].Color = Color.Red;
            }
            else if (notYetCount == 0)
            {
                personal_chart.Series["Series1"].Points.Add(rowsCount - completeCount);
                personal_chart.Series["Series1"].Points.Add(rowsCount - processCount);

                this.personal_chart.Series["Series1"].Points[0].LegendText = "완료";
                this.personal_chart.Series["Series1"].Points[0].Color = Color.Green;

                this.personal_chart.Series["Series1"].Points[1].LegendText = "진행 중";
                this.personal_chart.Series["Series1"].Points[1].Color = Color.Blue;
            }
            else if (processCount == 0)
            {
                personal_chart.Series["Series1"].Points.Add(rowsCount - completeCount);
                personal_chart.Series["Series1"].Points.Add(rowsCount - notYetCount);

                this.personal_chart.Series["Series1"].Points[0].LegendText = "완료";
                this.personal_chart.Series["Series1"].Points[0].Color = Color.Green;

                this.personal_chart.Series["Series1"].Points[1].LegendText = "해야할 일";
                this.personal_chart.Series["Series1"].Points[1].Color = Color.Red;
            }
            else
            {
                personal_chart.Series["Series1"].Points.Add(rowsCount - completeCount);
                personal_chart.Series["Series1"].Points.Add(rowsCount - notYetCount);
                personal_chart.Series["Series1"].Points.Add(rowsCount - processCount);

                this.personal_chart.Series["Series1"].Points[0].LegendText = "완료";
                this.personal_chart.Series["Series1"].Points[0].Color = Color.Green;

                this.personal_chart.Series["Series1"].Points[1].LegendText = "진행 중";
                this.personal_chart.Series["Series1"].Points[1].Color = Color.Blue;

                this.personal_chart.Series["Series1"].Points[2].LegendText = "해야할 일";
                this.personal_chart.Series["Series1"].Points[2].Color = Color.Red;
            }
        }
    }
}
