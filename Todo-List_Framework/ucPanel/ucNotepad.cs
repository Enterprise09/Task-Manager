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
    public partial class ucNotepad : UserControl
    {
        public ucNotepad()
        {
            InitializeComponent();
        }

        private SqlConnection conn =
            new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Documents\\DataBase.mdf;Integrated Security=True;Connect Timeout=30");
        private String query = null;
        private TableLayoutPanel tableLayout;

        private void ucNotepad_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

            tableLayout = new TableLayoutPanel();
            tableLayout.ColumnCount = 4;

            conn.Open();
            query = "select * from Note where Id = @id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", "ent");
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ucView.NoteView viewer = new ucView.NoteView();
                viewer.tb_content.Text = reader[1].ToString();
                viewer.lbl_register_date.Text = reader[2].ToString().Substring(0, 10);
                tableLayout.Controls.Add(viewer);
            }

            tableLayout.Size = new Size(1200, 1000);
            tableLayout.Location = new Point(47, 76);
            this.Controls.Add(tableLayout);

            conn.Close();
        }
        
        private void pb_AddNote_Click(object sender, EventArgs e)
        {
            (new AddNoteForm()).Show();
        }
    }
}
