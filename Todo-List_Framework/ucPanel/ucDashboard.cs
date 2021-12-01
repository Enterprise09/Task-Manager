using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        
        private void ucDashboard_Load(object sender, EventArgs e)
        {
            for(int i = 1; i <= 3; i++)
            {
                this.personal_chart.Series["Series1"].Points.Add(random.Next(500));
            }
            this.personal_chart.Series["Series1"].Points[0].LegendText = "완료";
            this.personal_chart.Series["Series1"].Points[0].Color = Color.Blue;

            this.personal_chart.Series["Series1"].Points[1].LegendText = "진행 중";
            this.personal_chart.Series["Series1"].Points[1].Color = Color.Green;

            this.personal_chart.Series["Series1"].Points[2].LegendText = "해야할 일";
            this.personal_chart.Series["Series1"].Points[2].Color = Color.Red;
        }
    }
}
