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
    public partial class ucContact : UserControl
    {
        public ucContact()
        {
            InitializeComponent();
        }

        private void pb_addContact_Click(object sender, EventArgs e)
        {
            (new AddContactForm()).Show();
        }

        private TableLayoutPanel tableLayout;
        private SqlConnection conn =
            new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Documents\\DataBase.mdf;Integrated Security=True;Connect Timeout=30");
        private String query = null;

        private void ucContact_Load(object sender, EventArgs e)
        {
            tableLayout = new TableLayoutPanel();
            tableLayout.ColumnCount = 4;

            conn.Open();
            query = "select * from Contact where Id = @id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", "ent");
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ucView.ContactView viewer = new ucView.ContactView();
                viewer.lbl_name.Text = reader[1].ToString();
                viewer.lbl_phone.Text = reader[2].ToString();
                viewer.lbl_note.Text = reader[3].ToString();
                tableLayout.Controls.Add(viewer);
            }

            tableLayout.Size = new Size(1200, 1000);
            tableLayout.Location = new Point(47, 76);
            this.Controls.Add(tableLayout);

            conn.Close();
        }
    }
}
